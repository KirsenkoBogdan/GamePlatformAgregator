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
            this.SuspendLayout();
            // 
            // Login_label
            // 
            this.Login_label.AutoSize = true;
            this.Login_label.Font = new System.Drawing.Font("MS Outlook", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_label.Location = new System.Drawing.Point(104, 126);
            this.Login_label.Name = "Login_label";
            this.Login_label.Size = new System.Drawing.Size(77, 28);
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
            this.Password_label.Font = new System.Drawing.Font("MS Outlook", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password_label.Location = new System.Drawing.Point(57, 191);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(124, 28);
            this.Password_label.TabIndex = 4;
            this.Password_label.Text = "Password";
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Font = new System.Drawing.Font("MS Outlook", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_label.Location = new System.Drawing.Point(41, 48);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(323, 28);
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
            // label1
            // 
            //this.label1.AutoSize = true;
            //this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            //this.label1.Location = new System.Drawing.Point(104, 126);
            //this.label1.Name = "label1";
            //this.label1.Size = new System.Drawing.Size(78, 29);
            //this.label1.TabIndex = 0;
            //this.label1.Text = "Login";
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            //// 
            //// textBox1
            //// 
            //this.textBox1.Location = new System.Drawing.Point(187, 132);
            //this.textBox1.Name = "textBox1";
            //this.textBox1.Size = new System.Drawing.Size(133, 20);
            //this.textBox1.TabIndex = 2;
            //// 
            //// textBox2
            //// 
            //this.textBox2.Location = new System.Drawing.Point(187, 197);
            //this.textBox2.Name = "textBox2";
            //this.textBox2.PasswordChar = '*';
            //this.textBox2.Size = new System.Drawing.Size(133, 20);
            //this.textBox2.TabIndex = 3;
            //// 
            //// label3
            //// 
            //this.label3.AutoSize = true;
            //this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            //this.label3.Location = new System.Drawing.Point(57, 191);
            //this.label3.Name = "label3";
            //this.label3.Size = new System.Drawing.Size(128, 29);
            //this.label3.TabIndex = 4;
            //this.label3.Text = "Password";
            //// 
            //// label2
            //// 
            //this.label2.AutoSize = true;
            //this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            //this.label2.Location = new System.Drawing.Point(42, 9);
            //this.label2.Name = "label2";
            //this.label2.Size = new System.Drawing.Size(331, 29);
            //this.label2.TabIndex = 5;
            //this.label2.Text = "Welcome to our application";
            //// 
            //// button1
            //// 
            //this.button1.BackColor = System.Drawing.Color.BlanchedAlmond;
            //this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            //this.button1.Location = new System.Drawing.Point(74, 277);
            //this.button1.Name = "button1";
            //this.button1.Size = new System.Drawing.Size(107, 26);
            //this.button1.TabIndex = 6;
            //this.button1.Text = "Enter";
            //this.button1.UseVisualStyleBackColor = false;
            //this.button1.Click += new System.EventHandler(this.button1_Click);
            //// 
            //// checkBox1
            //// 
            //this.checkBox1.AutoSize = true;
            //this.checkBox1.Location = new System.Drawing.Point(187, 237);
            //this.checkBox1.Name = "checkBox1";
            //this.checkBox1.Size = new System.Drawing.Size(101, 17);
            //this.checkBox1.TabIndex = 7;
            //this.checkBox1.Text = "Show password";
            //this.checkBox1.UseVisualStyleBackColor = true;
            //this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            //// 
            //// button2
            //// 
            //this.button2.BackColor = System.Drawing.Color.Teal;
            //this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            //this.button2.FlatAppearance.BorderSize = 0;
            //this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            //this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            //this.button2.Location = new System.Drawing.Point(74, 336);
            //this.button2.Name = "button2";
            //this.button2.Size = new System.Drawing.Size(246, 24);
            //this.button2.TabIndex = 8;
            //this.button2.Text = "Don`t have acount? Click here to register";
            //this.button2.UseVisualStyleBackColor = false;
            //this.button2.Click += new System.EventHandler(this.button2_Click);
            //// 
            //// button3
            //// 
            //this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            //this.button3.Location = new System.Drawing.Point(229, 277);
            //this.button3.Name = "button3";
            //this.button3.Size = new System.Drawing.Size(107, 26);
            //this.button3.TabIndex = 9;
            //this.button3.Text = "Exit";
            //this.button3.UseVisualStyleBackColor = true;
            //this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(387, 407);
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
    }
}

