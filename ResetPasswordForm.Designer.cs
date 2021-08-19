namespace LAB_5_OAIP
{
    partial class ResetPasswordForm
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
            this.ResetPassLabel = new System.Windows.Forms.Label();
            this.EMLabel = new System.Windows.Forms.Label();
            this.EMtextBox = new System.Windows.Forms.TextBox();
            this.Codebutton = new System.Windows.Forms.Button();
            this.CodeLabel = new System.Windows.Forms.Label();
            this.CodetextBox = new System.Windows.Forms.TextBox();
            this.Codebutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResetPassLabel
            // 
            this.ResetPassLabel.AutoSize = true;
            this.ResetPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetPassLabel.Location = new System.Drawing.Point(43, 30);
            this.ResetPassLabel.Name = "ResetPassLabel";
            this.ResetPassLabel.Size = new System.Drawing.Size(216, 20);
            this.ResetPassLabel.TabIndex = 0;
            this.ResetPassLabel.Text = "Восстановление пароля";
            // 
            // EMLabel
            // 
            this.EMLabel.AutoSize = true;
            this.EMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EMLabel.Location = new System.Drawing.Point(23, 95);
            this.EMLabel.Name = "EMLabel";
            this.EMLabel.Size = new System.Drawing.Size(148, 18);
            this.EMLabel.TabIndex = 1;
            this.EMLabel.Text = "Электронная почта:";
            // 
            // EMtextBox
            // 
            this.EMtextBox.Location = new System.Drawing.Point(26, 131);
            this.EMtextBox.Name = "EMtextBox";
            this.EMtextBox.Size = new System.Drawing.Size(233, 20);
            this.EMtextBox.TabIndex = 2;
            // 
            // Codebutton
            // 
            this.Codebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Codebutton.Location = new System.Drawing.Point(152, 157);
            this.Codebutton.Name = "Codebutton";
            this.Codebutton.Size = new System.Drawing.Size(107, 28);
            this.Codebutton.TabIndex = 3;
            this.Codebutton.Text = "Отправить код";
            this.Codebutton.UseVisualStyleBackColor = true;
            this.Codebutton.Click += new System.EventHandler(this.Codebutton_Click);
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CodeLabel.Location = new System.Drawing.Point(23, 214);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(40, 18);
            this.CodeLabel.TabIndex = 4;
            this.CodeLabel.Text = "Код:";
            // 
            // CodetextBox
            // 
            this.CodetextBox.Location = new System.Drawing.Point(26, 247);
            this.CodetextBox.Name = "CodetextBox";
            this.CodetextBox.Size = new System.Drawing.Size(233, 20);
            this.CodetextBox.TabIndex = 5;
            // 
            // Codebutton1
            // 
            this.Codebutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Codebutton1.Location = new System.Drawing.Point(26, 274);
            this.Codebutton1.Name = "Codebutton1";
            this.Codebutton1.Size = new System.Drawing.Size(233, 55);
            this.Codebutton1.TabIndex = 6;
            this.Codebutton1.Text = "Восстановить пароль";
            this.Codebutton1.UseVisualStyleBackColor = true;
            this.Codebutton1.Click += new System.EventHandler(this.Codebutton1_Click);
            // 
            // ResetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 352);
            this.Controls.Add(this.Codebutton1);
            this.Controls.Add(this.CodetextBox);
            this.Controls.Add(this.CodeLabel);
            this.Controls.Add(this.Codebutton);
            this.Controls.Add(this.EMtextBox);
            this.Controls.Add(this.EMLabel);
            this.Controls.Add(this.ResetPassLabel);
            this.Name = "ResetPasswordForm";
            this.Text = "ResetPasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ResetPassLabel;
        private System.Windows.Forms.Label EMLabel;
        private System.Windows.Forms.TextBox EMtextBox;
        private System.Windows.Forms.Button Codebutton;
        private System.Windows.Forms.Label CodeLabel;
        private System.Windows.Forms.TextBox CodetextBox;
        private System.Windows.Forms.Button Codebutton1;
    }
}