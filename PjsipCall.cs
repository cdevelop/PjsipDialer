using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjsipDialer
{
    public delegate void CallDisconnected(PjsipCall call,bool remote_hangup);
    public delegate void CallIncoming(string remoteUri);
    public delegate void CallStatusText(string status);

    public class PjsipCall : Call
    {
        private bool isOnLine = false;
        public bool IsOnline { get { return isOnLine; } }

        private CallDisconnected onCallDisconnected;
        public CallDisconnected OnCallDisconnected { set { onCallDisconnected = value; } }

        private CallIncoming onCallIncoming;
        public CallIncoming OnCallIncoming { set { onCallIncoming = value; } }

        private CallStatusText onCallStatusText;
        public CallStatusText OnCallStatusText { set { onCallStatusText = value; } }


        private AudioMediaRecorder recorder = null;
        private AudioMediaPlayer player = null;
        public PjsipCall(PjsipAccount acc, int call_id = -1)
            : base(acc, call_id)
        {
        }

        /// <summary>
        /// Обрабатываем событие изменения статуса звонка
        /// </summary>
        /// <param name="prm"></param>
        public override void onCallState(OnCallStateParam prm)
        {
            CallInfo ci = getInfo();
            isOnLine = isActive();





            if (ci.state == pjsip_inv_state.PJSIP_INV_STATE_INCOMING)
            {
                if (onCallIncoming != null) onCallIncoming(ci.remoteUri);
            }

            if (onCallStatusText != null) onCallStatusText(ci.stateText);

            if (ci.state == pjsip_inv_state.PJSIP_INV_STATE_DISCONNECTED)
            {
                if (recorder != null)
                {
                    recorder.Dispose();
                }

                if (player != null)
                {
                    player.Dispose();
                }

                bool remote_hangup = false;
                if (prm.e.type == pjsip_event_id_e.PJSIP_EVENT_TSX_STATE)
                {
                    if(prm.e.body.tsxState.src.rdata.info.IndexOf("Request msg BYE")>=0){
                        remote_hangup = true;
                    }
                }

                if (onCallDisconnected != null) onCallDisconnected(this, remote_hangup);
            }

        }

        /// <summary>
        /// Обрабатываем событие изменения статуса медиа
        /// </summary>
        /// <param name="prm"></param>
        public override void onCallMediaState(OnCallMediaStateParam prm)
        {
            CallInfo ci = getInfo();
            AudioMedia aud_med;

            try
            {
                aud_med = getAudioMedia(-1);
            }
            catch { return; }

            AudDevManager mgr = Endpoint.instance().audDevManager();

            AudioMedia play_dev_med = mgr.getPlaybackDevMedia();
            aud_med.startTransmit(play_dev_med);

            AudioMedia cap_aud_med = mgr.getCaptureDevMedia();
            cap_aud_med.startTransmit(aud_med);




            //录音文件
            if (recorder == null)
            {
                recorder = new AudioMediaRecorder();

                recorder.createRecorder("D:/1.wav");

                cap_aud_med.startTransmit(recorder);
                aud_med.startTransmit(recorder);
            }




        }



        /// <summary>
        /// 放音
        /// </summary>
        /// <param name="prm"></param>
        public void playfile(String file)
        {
            AudioMedia aud_med;

            try
            {
                aud_med = getAudioMedia(-1);

                AudDevManager mgr = Endpoint.instance().audDevManager();

                AudioMedia play_dev_med = mgr.getPlaybackDevMedia();

                player = new AudioMediaPlayer();
                player.createPlayer(file, 1);
                player.startTransmit(play_dev_med);
                player.startTransmit(aud_med);
            }
            catch { return; }


        }
    }
}
