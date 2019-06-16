namespace MTP_project
{
    partial class MainForm
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
            this.RegisterGogButton = new System.Windows.Forms.Button();
            this.WebPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // RegisterGogButton
            // 
            this.RegisterGogButton.Location = new System.Drawing.Point(163, 191);
            this.RegisterGogButton.Name = "RegisterGogButton";
            this.RegisterGogButton.Size = new System.Drawing.Size(106, 23);
            this.RegisterGogButton.TabIndex = 1;
            this.RegisterGogButton.Text = "Register in GOG";
            this.RegisterGogButton.UseVisualStyleBackColor = true;
            this.RegisterGogButton.Click += new System.EventHandler(this.RegisterGogButton_Click);
            // 
            // WebPanel
            // 
            this.WebPanel.Location = new System.Drawing.Point(412, 30);
            this.WebPanel.Name = "WebPanel";
            this.WebPanel.Size = new System.Drawing.Size(347, 397);
            this.WebPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WebPanel);
            this.Controls.Add(this.RegisterGogButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button RegisterGogButton;
        private System.Windows.Forms.Panel WebPanel;
    }
}