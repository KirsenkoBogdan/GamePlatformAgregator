namespace MTP_project
{
    partial class RegistrationForm
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
            this.Email_label = new System.Windows.Forms.Label();
            this.Login_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.ConfirmPasswor_label = new System.Windows.Forms.Label();
            this.Email_textBox = new System.Windows.Forms.TextBox();
            this.Login_textBox = new System.Windows.Forms.TextBox();
            this.ConfirmPassword_textBox = new System.Windows.Forms.TextBox();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.Register_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.LoginAddition_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Email_label
            // 
            this.Email_label.AutoSize = true;
            this.Email_label.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email_label.Location = new System.Drawing.Point(12, 73);
            this.Email_label.Name = "Email_label";
            this.Email_label.Size = new System.Drawing.Size(84, 26);
            this.Email_label.TabIndex = 0;
            this.Email_label.Text = "E-mail:";
            // 
            // Login_label
            // 
            this.Login_label.AutoSize = true;
            this.Login_label.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_label.Location = new System.Drawing.Point(12, 134);
            this.Login_label.Name = "Login_label";
            this.Login_label.Size = new System.Drawing.Size(85, 26);
            this.Login_label.TabIndex = 1;
            this.Login_label.Text = "Login*:";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password_label.Location = new System.Drawing.Point(12, 202);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(129, 26);
            this.Password_label.TabIndex = 2;
            this.Password_label.Text = "Password*:";
            // 
            // ConfirmPasswor_label
            // 
            this.ConfirmPasswor_label.AutoSize = true;
            this.ConfirmPasswor_label.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmPasswor_label.Location = new System.Drawing.Point(12, 263);
            this.ConfirmPasswor_label.Name = "ConfirmPasswor_label";
            this.ConfirmPasswor_label.Size = new System.Drawing.Size(211, 26);
            this.ConfirmPasswor_label.TabIndex = 3;
            this.ConfirmPasswor_label.Text = "Confirm password:";
            // 
            // Email_textBox
            // 
            this.Email_textBox.Location = new System.Drawing.Point(233, 79);
            this.Email_textBox.Name = "Email_textBox";
            this.Email_textBox.Size = new System.Drawing.Size(199, 20);
            this.Email_textBox.TabIndex = 4;
            // 
            // Login_textBox
            // 
            this.Login_textBox.Location = new System.Drawing.Point(233, 140);
            this.Login_textBox.Name = "Login_textBox";
            this.Login_textBox.Size = new System.Drawing.Size(199, 20);
            this.Login_textBox.TabIndex = 5;
            // 
            // ConfirmPassword_textBox
            // 
            this.ConfirmPassword_textBox.Location = new System.Drawing.Point(233, 269);
            this.ConfirmPassword_textBox.Name = "ConfirmPassword_textBox";
            this.ConfirmPassword_textBox.Size = new System.Drawing.Size(199, 20);
            this.ConfirmPassword_textBox.TabIndex = 6;
            this.ConfirmPassword_textBox.UseSystemPasswordChar = true;
            // 
            // Password_textBox
            // 
            this.Password_textBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Password_textBox.Location = new System.Drawing.Point(218, 208);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.Size = new System.Drawing.Size(293, 20);
            this.Password_textBox.TabIndex = 7;
            this.Password_textBox.Enter += new System.EventHandler(this.Password_textBox_Enter);
            // 
            // Register_button
            // 
            this.Register_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Register_button.Location = new System.Drawing.Point(76, 366);
            this.Register_button.Name = "Register_button";
            this.Register_button.Size = new System.Drawing.Size(155, 32);
            this.Register_button.TabIndex = 8;
            this.Register_button.Text = "Register";
            this.Register_button.UseVisualStyleBackColor = true;
            // 
            // Back_button
            // 
            this.Back_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_button.Location = new System.Drawing.Point(305, 366);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(155, 32);
            this.Back_button.TabIndex = 9;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // LoginAddition_label
            // 
            this.LoginAddition_label.AutoSize = true;
            this.LoginAddition_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginAddition_label.Location = new System.Drawing.Point(230, 163);
            this.LoginAddition_label.Name = "LoginAddition_label";
            this.LoginAddition_label.Size = new System.Drawing.Size(102, 13);
            this.LoginAddition_label.TabIndex = 10;
            this.LoginAddition_label.Text = "*Only A-Z, a-z or 0-9";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(169, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "Registration from";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(523, 463);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LoginAddition_label);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Register_button);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.ConfirmPassword_textBox);
            this.Controls.Add(this.Login_textBox);
            this.Controls.Add(this.Email_textBox);
            this.Controls.Add(this.ConfirmPasswor_label);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Login_label);
            this.Controls.Add(this.Email_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Email_label;
        private System.Windows.Forms.Label Login_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Label ConfirmPasswor_label;
        private System.Windows.Forms.TextBox Email_textBox;
        private System.Windows.Forms.TextBox Login_textBox;
        private System.Windows.Forms.TextBox ConfirmPassword_textBox;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.Button Register_button;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Label LoginAddition_label;
        private System.Windows.Forms.Label label7;
    }
}