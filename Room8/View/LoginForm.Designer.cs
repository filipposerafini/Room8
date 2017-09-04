namespace Room8
{
    partial class LoginForm
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
			this._titoloLabel = new System.Windows.Forms.Label();
			this._mailTextBox = new System.Windows.Forms.TextBox();
			this._passwordTextBox = new System.Windows.Forms.TextBox();
			this._accediButton = new System.Windows.Forms.Button();
			this._registratiButton = new System.Windows.Forms.Button();
			this._mailLabel = new System.Windows.Forms.Label();
			this._passwordLabel = new System.Windows.Forms.Label();
			this._errorProvider = new System.Windows.Forms.ErrorProvider();
            this.SuspendLayout();
			// 
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
            // 
            // labelTitolo
            // 
            this._titoloLabel.AutoSize = true;
            this._titoloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._titoloLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this._titoloLabel.Location = new System.Drawing.Point(88, 24);
            this._titoloLabel.Name = "labelTitolo";
            this._titoloLabel.Size = new System.Drawing.Size(143, 42);
            this._titoloLabel.TabIndex = 0;
            this._titoloLabel.Text = "Room8";
            // 
            // textBoxMail
            // 
            this._mailTextBox.Location = new System.Drawing.Point(68, 117);
            this._mailTextBox.Name = "textBoxMail";
            this._mailTextBox.Size = new System.Drawing.Size(175, 20);
            this._mailTextBox.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            this._passwordTextBox.Location = new System.Drawing.Point(68, 170);
            this._passwordTextBox.Name = "textBoxPassword";
            this._passwordTextBox.PasswordChar = '•';
            this._passwordTextBox.Size = new System.Drawing.Size(175, 20);
            this._passwordTextBox.TabIndex = 2;
            // 
            // buttonAccedi
            // 
            this._accediButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._accediButton.Location = new System.Drawing.Point(95, 212);
            this._accediButton.Name = "buttonAccedi";
            this._accediButton.Size = new System.Drawing.Size(123, 37);
            this._accediButton.TabIndex = 3;
            this._accediButton.Text = "Accedi";
            this._accediButton.UseVisualStyleBackColor = true;
            // 
            // buttonRegistrati
            // 
            this._registratiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._registratiButton.Location = new System.Drawing.Point(95, 255);
            this._registratiButton.Name = "buttonRegistrati";
            this._registratiButton.Size = new System.Drawing.Size(123, 36);
            this._registratiButton.TabIndex = 4;
            this._registratiButton.Text = "Registrati";
            this._registratiButton.UseVisualStyleBackColor = true;
            // 
            // labelMail
            // 
            this._mailLabel.AutoSize = true;
            this._mailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._mailLabel.Location = new System.Drawing.Point(132, 98);
            this._mailLabel.Name = "labelMail";
            this._mailLabel.Size = new System.Drawing.Size(49, 16);
            this._mailLabel.TabIndex = 5;
            this._mailLabel.Text = "E-mail:";
            // 
            // labelPassword
            // 
            this._passwordLabel.AutoSize = true;
            this._passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._passwordLabel.Location = new System.Drawing.Point(119, 151);
            this._passwordLabel.Name = "labelPassword";
            this._passwordLabel.Size = new System.Drawing.Size(71, 16);
            this._passwordLabel.TabIndex = 6;
            this._passwordLabel.Text = "Password:";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 326);
            this.Controls.Add(this._passwordLabel);
            this.Controls.Add(this._mailLabel);
            this.Controls.Add(this._registratiButton);
            this.Controls.Add(this._accediButton);
            this.Controls.Add(this._passwordTextBox);
            this.Controls.Add(this._mailTextBox);
            this.Controls.Add(this._titoloLabel);
            this.MaximumSize = new System.Drawing.Size(329, 364);
            this.MinimumSize = new System.Drawing.Size(329, 364);
            this.Name = "FormLogin";
            this.Text = "Room8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _titoloLabel;
        private System.Windows.Forms.TextBox _mailTextBox;
        private System.Windows.Forms.TextBox _passwordTextBox;
        private System.Windows.Forms.Button _accediButton;
        private System.Windows.Forms.Button _registratiButton;
        private System.Windows.Forms.Label _mailLabel;
        private System.Windows.Forms.Label _passwordLabel;
		private System.Windows.Forms.ErrorProvider _errorProvider;
    }
}