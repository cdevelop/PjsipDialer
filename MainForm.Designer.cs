namespace PjsipDialer
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gbAccounts = new System.Windows.Forms.GroupBox();
            this.lbAccounts = new System.Windows.Forms.CheckedListBox();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.miDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btAccAdd = new System.Windows.Forms.ToolStripButton();
            this.pNumPad = new System.Windows.Forms.Panel();
            this.callinfo = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            this.btCall = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.btNum0 = new System.Windows.Forms.Button();
            this.btAsterisk = new System.Windows.Forms.Button();
            this.btNum9 = new System.Windows.Forms.Button();
            this.btNum8 = new System.Windows.Forms.Button();
            this.btNum7 = new System.Windows.Forms.Button();
            this.btNum6 = new System.Windows.Forms.Button();
            this.btNum5 = new System.Windows.Forms.Button();
            this.btNum4 = new System.Windows.Forms.Button();
            this.btNum3 = new System.Windows.Forms.Button();
            this.btNum2 = new System.Windows.Forms.Button();
            this.btNum1 = new System.Windows.Forms.Button();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.lbCheckedAccount = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.gbAccounts.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.pNumPad.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAccounts
            // 
            this.gbAccounts.Controls.Add(this.lbAccounts);
            this.gbAccounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbAccounts.Location = new System.Drawing.Point(0, 42);
            this.gbAccounts.Margin = new System.Windows.Forms.Padding(6);
            this.gbAccounts.Name = "gbAccounts";
            this.gbAccounts.Padding = new System.Windows.Forms.Padding(6);
            this.gbAccounts.Size = new System.Drawing.Size(434, 185);
            this.gbAccounts.TabIndex = 0;
            this.gbAccounts.TabStop = false;
            this.gbAccounts.Text = "Список аккаунтов";
            // 
            // lbAccounts
            // 
            this.lbAccounts.ContextMenuStrip = this.contextMenu;
            this.lbAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAccounts.FormattingEnabled = true;
            this.lbAccounts.Location = new System.Drawing.Point(6, 34);
            this.lbAccounts.Margin = new System.Windows.Forms.Padding(6);
            this.lbAccounts.Name = "lbAccounts";
            this.lbAccounts.Size = new System.Drawing.Size(422, 145);
            this.lbAccounts.TabIndex = 0;
            this.lbAccounts.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lbAccounts_ItemCheck);
            this.lbAccounts.SelectedIndexChanged += new System.EventHandler(this.lbAccounts_SelectedIndexChanged);
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miEdit,
            this.miDelete});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(137, 80);
            // 
            // miEdit
            // 
            this.miEdit.Enabled = false;
            this.miEdit.Name = "miEdit";
            this.miEdit.Size = new System.Drawing.Size(136, 38);
            this.miEdit.Text = "编辑";
            this.miEdit.Click += new System.EventHandler(this.btAccEdit_Click);
            // 
            // miDelete
            // 
            this.miDelete.Enabled = false;
            this.miDelete.Name = "miDelete";
            this.miDelete.Size = new System.Drawing.Size(136, 38);
            this.miDelete.Text = "删除";
            this.miDelete.Click += new System.EventHandler(this.btAccDel_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip.Location = new System.Drawing.Point(0, 844);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.statusStrip.Size = new System.Drawing.Size(434, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btAccAdd});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.toolStrip.Size = new System.Drawing.Size(434, 42);
            this.toolStrip.TabIndex = 2;
            // 
            // btAccAdd
            // 
            this.btAccAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btAccAdd.Image = ((System.Drawing.Image)(resources.GetObject("btAccAdd.Image")));
            this.btAccAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAccAdd.Name = "btAccAdd";
            this.btAccAdd.Size = new System.Drawing.Size(46, 36);
            this.btAccAdd.Text = "添加";
            this.btAccAdd.Click += new System.EventHandler(this.btAccAdd_Click);
            // 
            // pNumPad
            // 
            this.pNumPad.Controls.Add(this.callinfo);
            this.pNumPad.Controls.Add(this.btBack);
            this.pNumPad.Controls.Add(this.btCall);
            this.pNumPad.Controls.Add(this.label11);
            this.pNumPad.Controls.Add(this.label6);
            this.pNumPad.Controls.Add(this.label7);
            this.pNumPad.Controls.Add(this.label8);
            this.pNumPad.Controls.Add(this.label5);
            this.pNumPad.Controls.Add(this.label3);
            this.pNumPad.Controls.Add(this.label4);
            this.pNumPad.Controls.Add(this.label2);
            this.pNumPad.Controls.Add(this.label1);
            this.pNumPad.Controls.Add(this.button9);
            this.pNumPad.Controls.Add(this.btNum0);
            this.pNumPad.Controls.Add(this.btAsterisk);
            this.pNumPad.Controls.Add(this.btNum9);
            this.pNumPad.Controls.Add(this.btNum8);
            this.pNumPad.Controls.Add(this.btNum7);
            this.pNumPad.Controls.Add(this.btNum6);
            this.pNumPad.Controls.Add(this.btNum5);
            this.pNumPad.Controls.Add(this.btNum4);
            this.pNumPad.Controls.Add(this.btNum3);
            this.pNumPad.Controls.Add(this.btNum2);
            this.pNumPad.Controls.Add(this.btNum1);
            this.pNumPad.Controls.Add(this.tbNumber);
            this.pNumPad.Controls.Add(this.lbCheckedAccount);
            this.pNumPad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pNumPad.Location = new System.Drawing.Point(0, 227);
            this.pNumPad.Margin = new System.Windows.Forms.Padding(6);
            this.pNumPad.Name = "pNumPad";
            this.pNumPad.Size = new System.Drawing.Size(434, 617);
            this.pNumPad.TabIndex = 3;
            // 
            // callinfo
            // 
            this.callinfo.AutoSize = true;
            this.callinfo.Location = new System.Drawing.Point(23, 511);
            this.callinfo.Name = "callinfo";
            this.callinfo.Size = new System.Drawing.Size(0, 24);
            this.callinfo.TabIndex = 25;
            // 
            // btBack
            // 
            this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btBack.Image = ((System.Drawing.Image)(resources.GetObject("btBack.Image")));
            this.btBack.Location = new System.Drawing.Point(288, 478);
            this.btBack.Margin = new System.Windows.Forms.Padding(6);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(120, 78);
            this.btBack.TabIndex = 24;
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btCall
            // 
            this.btCall.Enabled = false;
            this.btCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCall.Image = ((System.Drawing.Image)(resources.GetObject("btCall.Image")));
            this.btCall.Location = new System.Drawing.Point(156, 478);
            this.btCall.Margin = new System.Windows.Forms.Padding(6);
            this.btCall.Name = "btCall";
            this.btCall.Size = new System.Drawing.Size(120, 78);
            this.btCall.TabIndex = 23;
            this.btCall.UseVisualStyleBackColor = true;
            this.btCall.Click += new System.EventHandler(this.btCall_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(202, 447);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 24);
            this.label11.TabIndex = 22;
            this.label11.Text = "+";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 356);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "PQRS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(310, 356);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "WXYZ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(186, 356);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "TUV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 258);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "GHI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "MNO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "JKL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "DEF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "ABC";
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.ForeColor = System.Drawing.Color.Blue;
            this.button9.Location = new System.Drawing.Point(288, 386);
            this.button9.Margin = new System.Windows.Forms.Padding(6);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(120, 63);
            this.button9.TabIndex = 13;
            this.button9.Text = "#";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.btNum_Click);
            // 
            // btNum0
            // 
            this.btNum0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btNum0.ForeColor = System.Drawing.Color.Blue;
            this.btNum0.Location = new System.Drawing.Point(156, 386);
            this.btNum0.Margin = new System.Windows.Forms.Padding(6);
            this.btNum0.Name = "btNum0";
            this.btNum0.Size = new System.Drawing.Size(120, 63);
            this.btNum0.TabIndex = 12;
            this.btNum0.Text = "0";
            this.btNum0.UseVisualStyleBackColor = true;
            this.btNum0.Click += new System.EventHandler(this.btNum_Click);
            // 
            // btAsterisk
            // 
            this.btAsterisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAsterisk.ForeColor = System.Drawing.Color.Blue;
            this.btAsterisk.Location = new System.Drawing.Point(24, 386);
            this.btAsterisk.Margin = new System.Windows.Forms.Padding(6);
            this.btAsterisk.Name = "btAsterisk";
            this.btAsterisk.Size = new System.Drawing.Size(120, 63);
            this.btAsterisk.TabIndex = 11;
            this.btAsterisk.Text = "*";
            this.btAsterisk.UseVisualStyleBackColor = true;
            this.btAsterisk.Click += new System.EventHandler(this.btNum_Click);
            // 
            // btNum9
            // 
            this.btNum9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btNum9.ForeColor = System.Drawing.Color.Blue;
            this.btNum9.Location = new System.Drawing.Point(288, 288);
            this.btNum9.Margin = new System.Windows.Forms.Padding(6);
            this.btNum9.Name = "btNum9";
            this.btNum9.Size = new System.Drawing.Size(120, 63);
            this.btNum9.TabIndex = 10;
            this.btNum9.Text = "9";
            this.btNum9.UseVisualStyleBackColor = true;
            this.btNum9.Click += new System.EventHandler(this.btNum_Click);
            // 
            // btNum8
            // 
            this.btNum8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btNum8.ForeColor = System.Drawing.Color.Blue;
            this.btNum8.Location = new System.Drawing.Point(156, 288);
            this.btNum8.Margin = new System.Windows.Forms.Padding(6);
            this.btNum8.Name = "btNum8";
            this.btNum8.Size = new System.Drawing.Size(120, 63);
            this.btNum8.TabIndex = 9;
            this.btNum8.Text = "8";
            this.btNum8.UseVisualStyleBackColor = true;
            this.btNum8.Click += new System.EventHandler(this.btNum_Click);
            // 
            // btNum7
            // 
            this.btNum7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btNum7.ForeColor = System.Drawing.Color.Blue;
            this.btNum7.Location = new System.Drawing.Point(24, 288);
            this.btNum7.Margin = new System.Windows.Forms.Padding(6);
            this.btNum7.Name = "btNum7";
            this.btNum7.Size = new System.Drawing.Size(120, 63);
            this.btNum7.TabIndex = 8;
            this.btNum7.Text = "7";
            this.btNum7.UseVisualStyleBackColor = true;
            this.btNum7.Click += new System.EventHandler(this.btNum_Click);
            // 
            // btNum6
            // 
            this.btNum6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btNum6.ForeColor = System.Drawing.Color.Blue;
            this.btNum6.Location = new System.Drawing.Point(288, 190);
            this.btNum6.Margin = new System.Windows.Forms.Padding(6);
            this.btNum6.Name = "btNum6";
            this.btNum6.Size = new System.Drawing.Size(120, 63);
            this.btNum6.TabIndex = 7;
            this.btNum6.Text = "6";
            this.btNum6.UseVisualStyleBackColor = true;
            this.btNum6.Click += new System.EventHandler(this.btNum_Click);
            // 
            // btNum5
            // 
            this.btNum5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btNum5.ForeColor = System.Drawing.Color.Blue;
            this.btNum5.Location = new System.Drawing.Point(156, 190);
            this.btNum5.Margin = new System.Windows.Forms.Padding(6);
            this.btNum5.Name = "btNum5";
            this.btNum5.Size = new System.Drawing.Size(120, 63);
            this.btNum5.TabIndex = 6;
            this.btNum5.Text = "5";
            this.btNum5.UseVisualStyleBackColor = true;
            this.btNum5.Click += new System.EventHandler(this.btNum_Click);
            // 
            // btNum4
            // 
            this.btNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btNum4.ForeColor = System.Drawing.Color.Blue;
            this.btNum4.Location = new System.Drawing.Point(24, 190);
            this.btNum4.Margin = new System.Windows.Forms.Padding(6);
            this.btNum4.Name = "btNum4";
            this.btNum4.Size = new System.Drawing.Size(120, 63);
            this.btNum4.TabIndex = 5;
            this.btNum4.Text = "4";
            this.btNum4.UseVisualStyleBackColor = true;
            this.btNum4.Click += new System.EventHandler(this.btNum_Click);
            // 
            // btNum3
            // 
            this.btNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btNum3.ForeColor = System.Drawing.Color.Blue;
            this.btNum3.Location = new System.Drawing.Point(288, 92);
            this.btNum3.Margin = new System.Windows.Forms.Padding(6);
            this.btNum3.Name = "btNum3";
            this.btNum3.Size = new System.Drawing.Size(120, 63);
            this.btNum3.TabIndex = 4;
            this.btNum3.Text = "3";
            this.btNum3.UseVisualStyleBackColor = true;
            this.btNum3.Click += new System.EventHandler(this.btNum_Click);
            // 
            // btNum2
            // 
            this.btNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btNum2.ForeColor = System.Drawing.Color.Blue;
            this.btNum2.Location = new System.Drawing.Point(156, 92);
            this.btNum2.Margin = new System.Windows.Forms.Padding(6);
            this.btNum2.Name = "btNum2";
            this.btNum2.Size = new System.Drawing.Size(120, 63);
            this.btNum2.TabIndex = 3;
            this.btNum2.Text = "2";
            this.btNum2.UseVisualStyleBackColor = true;
            this.btNum2.Click += new System.EventHandler(this.btNum_Click);
            // 
            // btNum1
            // 
            this.btNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btNum1.ForeColor = System.Drawing.Color.Blue;
            this.btNum1.Location = new System.Drawing.Point(24, 92);
            this.btNum1.Margin = new System.Windows.Forms.Padding(6);
            this.btNum1.Name = "btNum1";
            this.btNum1.Size = new System.Drawing.Size(120, 63);
            this.btNum1.TabIndex = 2;
            this.btNum1.Text = "1";
            this.btNum1.UseVisualStyleBackColor = true;
            this.btNum1.Click += new System.EventHandler(this.btNum_Click);
            // 
            // tbNumber
            // 
            this.tbNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbNumber.Enabled = false;
            this.tbNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNumber.ForeColor = System.Drawing.Color.Blue;
            this.tbNumber.Location = new System.Drawing.Point(0, 31);
            this.tbNumber.Margin = new System.Windows.Forms.Padding(6);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.ReadOnly = true;
            this.tbNumber.Size = new System.Drawing.Size(434, 38);
            this.tbNumber.TabIndex = 1;
            this.tbNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNumber.TextChanged += new System.EventHandler(this.tbNumber_TextChanged);
            // 
            // lbCheckedAccount
            // 
            this.lbCheckedAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCheckedAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCheckedAccount.Location = new System.Drawing.Point(0, 0);
            this.lbCheckedAccount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbCheckedAccount.Name = "lbCheckedAccount";
            this.lbCheckedAccount.Size = new System.Drawing.Size(434, 31);
            this.lbCheckedAccount.TabIndex = 0;
            this.lbCheckedAccount.Text = "CheckedAccount";
            this.lbCheckedAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "call_disable.png");
            this.imageList.Images.SetKeyName(1, "call.png");
            this.imageList.Images.SetKeyName(2, "hungup.png");
            // 
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 866);
            this.Controls.Add(this.pNumPad);
            this.Controls.Add(this.gbAccounts);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PJSIP звонилка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.gbAccounts.ResumeLayout(false);
            this.contextMenu.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.pNumPad.ResumeLayout(false);
            this.pNumPad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAccounts;
        private System.Windows.Forms.CheckedListBox lbAccounts;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btAccAdd;
        private System.Windows.Forms.Panel pNumPad;
        private System.Windows.Forms.Label lbCheckedAccount;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btCall;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btNum0;
        private System.Windows.Forms.Button btAsterisk;
        private System.Windows.Forms.Button btNum9;
        private System.Windows.Forms.Button btNum8;
        private System.Windows.Forms.Button btNum7;
        private System.Windows.Forms.Button btNum6;
        private System.Windows.Forms.Button btNum5;
        private System.Windows.Forms.Button btNum4;
        private System.Windows.Forms.Button btNum3;
        private System.Windows.Forms.Button btNum2;
        private System.Windows.Forms.Button btNum1;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem miEdit;
        private System.Windows.Forms.ToolStripMenuItem miDelete;
        private System.Windows.Forms.Label callinfo;
    }
}

