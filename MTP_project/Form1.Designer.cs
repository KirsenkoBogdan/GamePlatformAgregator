namespace MTP_project
{
    partial class AuthorizationForm
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
            this.Login_label = new System.Windows.Forms.Label();
            this.Login_textBox = new System.Windows.Forms.TextBox();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.Password_label = new System.Windows.Forms.Label();
            this.Name_label = new System.Windows.Forms.Label();
            this.Enter_button = new System.Windows.Forms.Button();
            this.ShowPassword_checkBox = new System.Windows.Forms.CheckBox();
            this.ToRegister_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.ResponseLabel = new System.Windows.Forms.Label();
            this.ForgotPassword_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login_label
            // 
            this.Login_label.AutoSize = true;
            this.Login_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_label.Location = new System.Drawing.Point(104, 126);
            this.Login_label.Name = "Login_label";
            this.Login_label.Size = new System.Drawing.Size(78, 29);
            this.Login_label.TabIndex = 0;
            this.Login_label.Text = "Login";
            // 
            // Login_textBox
            // 
            this.Login_textBox.Location = new System.Drawing.Point(187, 132);
            this.Login_textBox.Name = "Login_textBox";
            this.Login_textBox.Size = new System.Drawing.Size(133, 20);
            this.Login_textBox.TabIndex = 2;
            // 
            // Password_textBox
            // 
            this.Password_textBox.Location = new System.Drawing.Point(187, 197);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.Size = new System.Drawing.Size(133, 20);
            this.Password_textBox.TabIndex = 3;
            this.Password_textBox.UseSystemPasswordChar = true;
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password_label.Location = new System.Drawing.Point(57, 191);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(128, 29);
            this.Password_label.TabIndex = 4;
            this.Password_label.Text = "Password";
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_label.Location = new System.Drawing.Point(41, 48);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(331, 29);
            this.Name_label.TabIndex = 5;
            this.Name_label.Text = "Welcome to our application";
            // 
            // Enter_button
            // 
            this.Enter_button.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Enter_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enter_button.Location = new System.Drawing.Point(74, 277);
            this.Enter_button.Name = "Enter_button";
            this.Enter_button.Size = new System.Drawing.Size(107, 26);
            this.Enter_button.TabIndex = 6;
            this.Enter_button.Text = "Enter";
            this.Enter_button.UseVisualStyleBackColor = false;
            this.Enter_button.Click += new System.EventHandler(this.Enter_button_Click);
            // 
            // ShowPassword_checkBox
            // 
            this.ShowPassword_checkBox.AutoSize = true;
            this.ShowPassword_checkBox.Location = new System.Drawing.Point(187, 237);
            this.ShowPassword_checkBox.Name = "ShowPassword_checkBox";
            this.ShowPassword_checkBox.Size = new System.Drawing.Size(101, 17);
            this.ShowPassword_checkBox.TabIndex = 7;
            this.ShowPassword_checkBox.Text = "Show password";
            this.ShowPassword_checkBox.UseVisualStyleBackColor = true;
            this.ShowPassword_checkBox.CheckedChanged += new System.EventHandler(this.ShowPassword_checkBox_CheckedChanged);
            // 
            // ToRegister_button
            // 
            this.ToRegister_button.BackColor = System.Drawing.Color.Teal;
            this.ToRegister_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ToRegister_button.FlatAppearance.BorderSize = 0;
            this.ToRegister_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToRegister_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToRegister_button.Location = new System.Drawing.Point(74, 336);
            this.ToRegister_button.Name = "ToRegister_button";
            this.ToRegister_button.Size = new System.Drawing.Size(246, 24);
            this.ToRegister_button.TabIndex = 8;
            this.ToRegister_button.Text = "Don`t have acount? Click here to register";
            this.ToRegister_button.UseVisualStyleBackColor = false;
            this.ToRegister_button.Click += new System.EventHandler(this.ToRegister_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_button.Location = new System.Drawing.Point(229, 277);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(107, 26);
            this.Exit_button.TabIndex = 9;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // ResponseLabel
            // 
            this.ResponseLabel.AutoSize = true;
            this.ResponseLabel.Location = new System.Drawing.Point(116, 257);
            this.ResponseLabel.Name = "ResponseLabel";
            this.ResponseLabel.Size = new System.Drawing.Size(0, 13);
            this.ResponseLabel.TabIndex = 10;
            // 
            // ForgotPassword_button
            // 
            this.ForgotPassword_button.BackColor = System.Drawing.Color.Teal;
            this.ForgotPassword_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ForgotPassword_button.FlatAppearance.BorderSize = 0;
            this.ForgotPassword_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForgotPassword_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForgotPassword_button.Location = new System.Drawing.Point(74, 366);
            this.ForgotPassword_button.Name = "ForgotPassword_button";
            this.ForgotPassword_button.Size = new System.Drawing.Size(246, 24);
            this.ForgotPassword_button.TabIndex = 11;
            this.ForgotPassword_button.Text = "Forgot your password? Click here";
            this.ForgotPassword_button.UseVisualStyleBackColor = false;
            this.ForgotPassword_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(387, 407);
            this.Controls.Add(this.ForgotPassword_button);
            this.Controls.Add(this.ResponseLabel);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.ToRegister_button);
            this.Controls.Add(this.ShowPassword_checkBox);
            this.Controls.Add(this.Enter_button);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.Login_textBox);
            this.Controls.Add(this.Login_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login_label;
        private System.Windows.Forms.TextBox Login_textBox;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Button Enter_button;
        private System.Windows.Forms.CheckBox ShowPassword_checkBox;
        private System.Windows.Forms.Button ToRegister_button;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Label ResponseLabel;
        private System.Windows.Forms.Button ForgotPassword_button;
    }
}

