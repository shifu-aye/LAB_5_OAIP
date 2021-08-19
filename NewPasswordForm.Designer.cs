namespace LAB_5_OAIP
{
    partial class NewPasswordForm
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
            this.NewPasswordLabel = new System.Windows.Forms.Label();
            this.NewPasswordtextBox = new System.Windows.Forms.TextBox();
            this.NewPassLabel = new System.Windows.Forms.Label();
            this.Donebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.AutoSize = true;
            this.NewPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewPasswordLabel.Location = new System.Drawing.Point(68, 31);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(130, 20);
            this.NewPasswordLabel.TabIndex = 0;
            this.NewPasswordLabel.Text = "Новый пароль";
            // 
            // NewPasswordtextBox
            // 
            this.NewPasswordtextBox.Location = new System.Drawing.Point(16, 107);
            this.NewPasswordtextBox.Name = "NewPasswordtextBox";
            this.NewPasswordtextBox.Size = new System.Drawing.Size(238, 20);
            this.NewPasswordtextBox.TabIndex = 1;
            // 
            // NewPassLabel
            // 
            this.NewPassLabel.AutoSize = true;
            this.NewPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewPassLabel.Location = new System.Drawing.Point(13, 76);
            this.NewPassLabel.Name = "NewPassLabel";
            this.NewPassLabel.Size = new System.Drawing.Size(104, 16);
            this.NewPassLabel.TabIndex = 2;
            this.NewPassLabel.Text = "Новый пароль:";
            // 
            // Donebutton
            // 
            this.Donebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Donebutton.Location = new System.Drawing.Point(16, 133);
            this.Donebutton.Name = "Donebutton";
            this.Donebutton.Size = new System.Drawing.Size(238, 23);
            this.Donebutton.TabIndex = 3;
            this.Donebutton.Text = "Готово";
            this.Donebutton.UseVisualStyleBackColor = true;
            this.Donebutton.Click += new System.EventHandler(this.Donebutton_Click);
            // 
            // NewPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 171);
            this.Controls.Add(this.Donebutton);
            this.Controls.Add(this.NewPassLabel);
            this.Controls.Add(this.NewPasswordtextBox);
            this.Controls.Add(this.NewPasswordLabel);
            this.Name = "NewPasswordForm";
            this.Text = "NewPasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewPasswordLabel;
        private System.Windows.Forms.TextBox NewPasswordtextBox;
        private System.Windows.Forms.Label NewPassLabel;
        private System.Windows.Forms.Button Donebutton;
    }
}