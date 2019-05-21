namespace MTP_project
{
    partial class ForgotPassword_1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ForgotPassworDescription_label = new System.Windows.Forms.Label();
            this.ConfirmLoginMail_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 20);
            this.textBox1.TabIndex = 0;
            // 
            // ForgotPassworDescription_label
            // 
            this.ForgotPassworDescription_label.AutoSize = true;
            this.ForgotPassworDescription_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForgotPassworDescription_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ForgotPassworDescription_label.Location = new System.Drawing.Point(38, 180);
            this.ForgotPassworDescription_label.Name = "ForgotPassworDescription_label";
            this.ForgotPassworDescription_label.Size = new System.Drawing.Size(187, 13);
            this.ForgotPassworDescription_label.TabIndex = 1;
            this.ForgotPassworDescription_label.Text = "Please? input you login or email";
            // 
            // ConfirmLoginMail_button
            // 
            this.ConfirmLoginMail_button.Location = new System.Drawing.Point(41, 250);
            this.ConfirmLoginMail_button.Name = "ConfirmLoginMail_button";
            this.ConfirmLoginMail_button.Size = new System.Drawing.Size(75, 23);
            this.ConfirmLoginMail_button.TabIndex = 2;
            this.ConfirmLoginMail_button.Text = "Ok";
            this.ConfirmLoginMail_button.UseVisualStyleBackColor = true;
            // 
            // ForgotPassword_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(387, 407);
            this.Controls.Add(this.ConfirmLoginMail_button);
            this.Controls.Add(this.ForgotPassworDescription_label);
            this.Controls.Add(this.textBox1);
            this.Name = "ForgotPassword_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ForgotPassworDescription_label;
        private System.Windows.Forms.Button ConfirmLoginMail_button;
    }
}