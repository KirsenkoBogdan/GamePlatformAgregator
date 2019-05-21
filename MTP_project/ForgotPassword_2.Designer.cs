namespace MTP_project
{
    partial class ForgotPassword_2
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
            this.ForgotPasswordTempPassword_label = new System.Windows.Forms.Label();
            this.TempPassword_textBox = new System.Windows.Forms.TextBox();
            this.ConfirmTempPassword_button = new System.Windows.Forms.Button();
            this.ResponseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ForgotPasswordTempPassword_label
            // 
            this.ForgotPasswordTempPassword_label.AllowDrop = true;
            this.ForgotPasswordTempPassword_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForgotPasswordTempPassword_label.Location = new System.Drawing.Point(15, 146);
            this.ForgotPasswordTempPassword_label.Name = "ForgotPasswordTempPassword_label";
            this.ForgotPasswordTempPassword_label.Size = new System.Drawing.Size(329, 54);
            this.ForgotPasswordTempPassword_label.TabIndex = 0;
            this.ForgotPasswordTempPassword_label.Text = "Please confirm your request with password that was send to your email";
            this.ForgotPasswordTempPassword_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TempPassword_textBox
            // 
            this.TempPassword_textBox.Location = new System.Drawing.Point(15, 215);
            this.TempPassword_textBox.Name = "TempPassword_textBox";
            this.TempPassword_textBox.Size = new System.Drawing.Size(295, 20);
            this.TempPassword_textBox.TabIndex = 1;
            // 
            // ConfirmTempPassword_button
            // 
            this.ConfirmTempPassword_button.Location = new System.Drawing.Point(15, 254);
            this.ConfirmTempPassword_button.Name = "ConfirmTempPassword_button";
            this.ConfirmTempPassword_button.Size = new System.Drawing.Size(75, 23);
            this.ConfirmTempPassword_button.TabIndex = 2;
            this.ConfirmTempPassword_button.Text = "Confirm";
            this.ConfirmTempPassword_button.UseVisualStyleBackColor = true;
            this.ConfirmTempPassword_button.Click += new System.EventHandler(this.ConfirmTempPassword_button_Click);
            // 
            // ResponseLabel
            // 
            this.ResponseLabel.AutoSize = true;
            this.ResponseLabel.Location = new System.Drawing.Point(34, 301);
            this.ResponseLabel.Name = "ResponseLabel";
            this.ResponseLabel.Size = new System.Drawing.Size(0, 13);
            this.ResponseLabel.TabIndex = 3;
            // 
            // ForgotPassword_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(387, 407);
            this.Controls.Add(this.ResponseLabel);
            this.Controls.Add(this.ConfirmTempPassword_button);
            this.Controls.Add(this.TempPassword_textBox);
            this.Controls.Add(this.ForgotPasswordTempPassword_label);
            this.Name = "ForgotPassword_2";
            this.Text = "ForgotPassword_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ForgotPasswordTempPassword_label;
        private System.Windows.Forms.TextBox TempPassword_textBox;
        private System.Windows.Forms.Button ConfirmTempPassword_button;
        private System.Windows.Forms.Label ResponseLabel;
    }
}