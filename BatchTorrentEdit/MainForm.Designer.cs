namespace BatchTorrentEdit
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.TextBox_TorrentNameStartsWith = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_SelectTorrentsMsg = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_BeforTarkerHostName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBox_NewTarkerHostName = new System.Windows.Forms.TextBox();
            this.CheckBox_AddTarkerMod = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Test = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LabelTarker_Old = new System.Windows.Forms.Label();
            this.LabelTarker_New = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "选择种子文件所在的文件夹";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBox_TorrentNameStartsWith
            // 
            this.TextBox_TorrentNameStartsWith.Location = new System.Drawing.Point(187, 126);
            this.TextBox_TorrentNameStartsWith.Name = "TextBox_TorrentNameStartsWith";
            this.TextBox_TorrentNameStartsWith.Size = new System.Drawing.Size(241, 23);
            this.TextBox_TorrentNameStartsWith.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "TorrentNameStartsWith";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "种子名称开通包含过滤";
            // 
            // Label_SelectTorrentsMsg
            // 
            this.Label_SelectTorrentsMsg.AutoSize = true;
            this.Label_SelectTorrentsMsg.Location = new System.Drawing.Point(40, 167);
            this.Label_SelectTorrentsMsg.Name = "Label_SelectTorrentsMsg";
            this.Label_SelectTorrentsMsg.Size = new System.Drawing.Size(15, 17);
            this.Label_SelectTorrentsMsg.TabIndex = 4;
            this.Label_SelectTorrentsMsg.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "旧Tarker域名信息";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "BeforTarkerHostName";
            // 
            // TextBox_BeforTarkerHostName
            // 
            this.TextBox_BeforTarkerHostName.Location = new System.Drawing.Point(187, 228);
            this.TextBox_BeforTarkerHostName.Name = "TextBox_BeforTarkerHostName";
            this.TextBox_BeforTarkerHostName.Size = new System.Drawing.Size(241, 23);
            this.TextBox_BeforTarkerHostName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "新Tarker域名信息";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "NewTarkerHostName";
            // 
            // TextBox_NewTarkerHostName
            // 
            this.TextBox_NewTarkerHostName.Location = new System.Drawing.Point(187, 293);
            this.TextBox_NewTarkerHostName.Name = "TextBox_NewTarkerHostName";
            this.TextBox_NewTarkerHostName.Size = new System.Drawing.Size(241, 23);
            this.TextBox_NewTarkerHostName.TabIndex = 8;
            // 
            // CheckBox_AddTarkerMod
            // 
            this.CheckBox_AddTarkerMod.AutoSize = true;
            this.CheckBox_AddTarkerMod.Location = new System.Drawing.Point(187, 342);
            this.CheckBox_AddTarkerMod.Name = "CheckBox_AddTarkerMod";
            this.CheckBox_AddTarkerMod.Size = new System.Drawing.Size(117, 21);
            this.CheckBox_AddTarkerMod.TabIndex = 11;
            this.CheckBox_AddTarkerMod.Text = "AddTarkerMod";
            this.CheckBox_AddTarkerMod.UseVisualStyleBackColor = true;
            this.CheckBox_AddTarkerMod.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "新增Tarker模式";
            this.label7.Visible = false;
            // 
            // Test
            // 
            this.Test.Location = new System.Drawing.Point(476, 367);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(75, 23);
            this.Test.TabIndex = 13;
            this.Test.Text = "Test";
            this.Test.UseVisualStyleBackColor = true;
            this.Test.Visible = false;
            this.Test.Click += new System.EventHandler(this.Test_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(580, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "RUN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LabelTarker_Old
            // 
            this.LabelTarker_Old.AutoSize = true;
            this.LabelTarker_Old.Location = new System.Drawing.Point(37, 442);
            this.LabelTarker_Old.Name = "LabelTarker_Old";
            this.LabelTarker_Old.Size = new System.Drawing.Size(71, 17);
            this.LabelTarker_Old.TabIndex = 15;
            this.LabelTarker_Old.Text = "Tarker Old";
            // 
            // LabelTarker_New
            // 
            this.LabelTarker_New.AutoSize = true;
            this.LabelTarker_New.Location = new System.Drawing.Point(36, 474);
            this.LabelTarker_New.Name = "LabelTarker_New";
            this.LabelTarker_New.Size = new System.Drawing.Size(76, 17);
            this.LabelTarker_New.TabIndex = 16;
            this.LabelTarker_New.Text = "Tarker New";
            this.LabelTarker_New.Click += new System.EventHandler(this.label8_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(460, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Like https://tarker.bbb.com";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(460, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Like https://tarker.ccc.com";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LabelTarker_New);
            this.Controls.Add(this.LabelTarker_Old);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Test);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CheckBox_AddTarkerMod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextBox_NewTarkerHostName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBox_BeforTarkerHostName);
            this.Controls.Add(this.Label_SelectTorrentsMsg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_TorrentNameStartsWith);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "BatchTorrentEdit";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox TextBox_TorrentNameStartsWith;
        private Label label1;
        private Label label2;
        private Label Label_SelectTorrentsMsg;
        private Label label3;
        private Label label4;
        private TextBox TextBox_BeforTarkerHostName;
        private Label label5;
        private Label label6;
        private TextBox TextBox_NewTarkerHostName;
        private CheckBox CheckBox_AddTarkerMod;
        private Label label7;
        private Button Test;
        private Button button2;
        private Label LabelTarker_Old;
        private Label LabelTarker_New;
        private Label label8;
        private Label label9;
    }
}