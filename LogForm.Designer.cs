namespace LAB_5_OAIP
{
    partial class LogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LogINLABEL = new System.Windows.Forms.Label();
            this.LLabel = new System.Windows.Forms.Label();
            this.LTextBox = new System.Windows.Forms.TextBox();
            this.PLabel = new System.Windows.Forms.Label();
            this.PTextBox = new System.Windows.Forms.TextBox();
            this.LogButton = new System.Windows.Forms.Button();
            this.linkLabelRegist = new System.Windows.Forms.LinkLabel();
            this.linkLabelPassword = new System.Windows.Forms.LinkLabel();
            this.LogcheckBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // LogINLABEL
            // 
            this.LogINLABEL.AutoSize = true;
            this.LogINLABEL.Font = new System.Drawing.Font("Balsamiq Sans", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogINLABEL.Location = new System.Drawing.Point(88, 44);
            this.LogINLABEL.Name = "LogINLABEL";
            this.LogINLABEL.Size = new System.Drawing.Size(143, 35);
            this.LogINLABEL.TabIndex = 0;
            this.LogINLABEL.Text = "Авторизация";
            // 
            // LLabel
            // 
            this.LLabel.AutoSize = true;
            this.LLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LLabel.Location = new System.Drawing.Point(31, 117);
            this.LLabel.Name = "LLabel";
            this.LLabel.Size = new System.Drawing.Size(54, 18);
            this.LLabel.TabIndex = 1;
            this.LLabel.Text = "Логин:";
            // 
            // LTextBox
            // 
            this.LTextBox.Location = new System.Drawing.Point(34, 149);
            this.LTextBox.Name = "LTextBox";
            this.LTextBox.Size = new System.Drawing.Size(232, 20);
            this.LTextBox.TabIndex = 2;
            // 
            // PLabel
            // 
            this.PLabel.AutoSize = true;
            this.PLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PLabel.Location = new System.Drawing.Point(31, 199);
            this.PLabel.Name = "PLabel";
            this.PLabel.Size = new System.Drawing.Size(65, 18);
            this.PLabel.TabIndex = 3;
            this.PLabel.Text = "Пароль:";
            // 
            // PTextBox
            // 
            this.PTextBox.Location = new System.Drawing.Point(34, 231);
            this.PTextBox.Name = "PTextBox";
            this.PTextBox.Size = new System.Drawing.Size(232, 20);
            this.PTextBox.TabIndex = 4;
            this.PTextBox.TextChanged += new System.EventHandler(this.PTextBox_TextChanged);
            // 
            // LogButton
            // 
            this.LogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogButton.Location = new System.Drawing.Point(34, 273);
            this.LogButton.Name = "LogButton";
            this.LogButton.Size = new System.Drawing.Size(232, 31);
            this.LogButton.TabIndex = 5;
            this.LogButton.Text = "Авторизироваться";
            this.LogButton.UseVisualStyleBackColor = true;
            this.LogButton.Click += new System.EventHandler(this.LogButton_Click);
            // 
            // linkLabelRegist
            // 
            this.linkLabelRegist.AutoSize = true;
            this.linkLabelRegist.Location = new System.Drawing.Point(34, 311);
            this.linkLabelRegist.Name = "linkLabelRegist";
            this.linkLabelRegist.Size = new System.Drawing.Size(72, 13);
            this.linkLabelRegist.TabIndex = 6;
            this.linkLabelRegist.TabStop = true;
            this.linkLabelRegist.Text = "Регистрация";
            this.linkLabelRegist.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRegist_LinkClicked);
            // 
            // linkLabelPassword
            // 
            this.linkLabelPassword.AutoSize = true;
            this.linkLabelPassword.Location = new System.Drawing.Point(175, 311);
            this.linkLabelPassword.Name = "linkLabelPassword";
            this.linkLabelPassword.Size = new System.Drawing.Size(91, 13);
            this.linkLabelPassword.TabIndex = 7;
            this.linkLabelPassword.TabStop = true;
            this.linkLabelPassword.Text = "Забыли пароль?";
            this.linkLabelPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPassword_LinkClicked);
            // 
            // LogcheckBox1
            // 
            this.LogcheckBox1.AutoSize = true;
            this.LogcheckBox1.Location = new System.Drawing.Point(151, 208);
            this.LogcheckBox1.Name = "LogcheckBox1";
            this.LogcheckBox1.Size = new System.Drawing.Size(115, 17);
            this.LogcheckBox1.TabIndex = 8;
            this.LogcheckBox1.Text = "показать/скрыть";
            this.LogcheckBox1.UseVisualStyleBackColor = true;
            this.LogcheckBox1.CheckedChanged += new System.EventHandler(this.LogcheckBox1_CheckedChanged);
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 377);
            this.Controls.Add(this.LogcheckBox1);
            this.Controls.Add(this.linkLabelPassword);
            this.Controls.Add(this.linkLabelRegist);
            this.Controls.Add(this.LogButton);
            this.Controls.Add(this.PTextBox);
            this.Controls.Add(this.PLabel);
            this.Controls.Add(this.LTextBox);
            this.Controls.Add(this.LLabel);
            this.Controls.Add(this.LogINLABEL);
            this.Name = "LogForm";
            this.Text = "LogForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogINLABEL;
        private System.Windows.Forms.Label LLabel;
        private System.Windows.Forms.TextBox LTextBox;
        private System.Windows.Forms.Label PLabel;
        private System.Windows.Forms.TextBox PTextBox;
        private System.Windows.Forms.Button LogButton;
        private System.Windows.Forms.LinkLabel linkLabelRegist;
        private System.Windows.Forms.LinkLabel linkLabelPassword;
        private System.Windows.Forms.CheckBox LogcheckBox1;
    }
}