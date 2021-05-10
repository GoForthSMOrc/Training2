namespace ExamTraining
{
    partial class Authorization
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
            this.Autho = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.logBox = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Autho
            // 
            this.Autho.AutoSize = true;
            this.Autho.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Autho.Location = new System.Drawing.Point(105, 54);
            this.Autho.Name = "Autho";
            this.Autho.Size = new System.Drawing.Size(203, 36);
            this.Autho.TabIndex = 0;
            this.Autho.Text = "Авторизация";
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(48, 155);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(91, 31);
            this.Login.TabIndex = 1;
            this.Login.Text = "Логин";
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pass.Location = new System.Drawing.Point(48, 211);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(107, 31);
            this.Pass.TabIndex = 2;
            this.Pass.Text = "Пароль";
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(224, 222);
            this.passBox.Multiline = true;
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '*';
            this.passBox.Size = new System.Drawing.Size(144, 46);
            this.passBox.TabIndex = 3;
            this.passBox.UseSystemPasswordChar = true;
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(224, 140);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(144, 46);
            this.logBox.TabIndex = 4;
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(111, 353);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(199, 85);
            this.EnterButton.TabIndex = 5;
            this.EnterButton.Text = "Войти";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 450);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Autho);
            this.Name = "Authorization";
            this.Text = "Authorization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Autho;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.Button EnterButton;
    }
}