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
            this.components = new System.ComponentModel.Container();
            this._titoloLabel = new System.Windows.Forms.Label();
            this._mailTextBox = new System.Windows.Forms.TextBox();
            this._passwordTextBox = new System.Windows.Forms.TextBox();
            this._accediButton = new System.Windows.Forms.Button();
            this._registratiButton = new System.Windows.Forms.Button();
            this._mailLabel = new System.Windows.Forms.Label();
            this._passwordLabel = new System.Windows.Forms.Label();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this._tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._mailPanel = new System.Windows.Forms.Panel();
            this._passwordPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this._tableLayoutPanel.SuspendLayout();
            this._mailPanel.SuspendLayout();
            this._passwordPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _titoloLabel
            // 
            this._titoloLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._titoloLabel.AutoSize = true;
            this._titoloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._titoloLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this._titoloLabel.Location = new System.Drawing.Point(85, 18);
            this._titoloLabel.Name = "_titoloLabel";
            this._titoloLabel.Size = new System.Drawing.Size(143, 42);
            this._titoloLabel.TabIndex = 0;
            this._titoloLabel.Text = "Room8";
            // 
            // _mailTextBox
            // 
            this._mailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._mailTextBox.Location = new System.Drawing.Point(70, 44);
            this._mailTextBox.Name = "_mailTextBox";
            this._mailTextBox.Size = new System.Drawing.Size(181, 20);
            this._mailTextBox.TabIndex = 1;
            this._mailTextBox.Text = "user1@mail.com";
            // 
            // _passwordTextBox
            // 
            this._passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._passwordTextBox.Location = new System.Drawing.Point(70, 28);
            this._passwordTextBox.Name = "_passwordTextBox";
            this._passwordTextBox.PasswordChar = '•';
            this._passwordTextBox.Size = new System.Drawing.Size(181, 20);
            this._passwordTextBox.TabIndex = 2;
            this._passwordTextBox.Text = "password1";
            // 
            // _accediButton
            // 
            this._accediButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._accediButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._accediButton.Location = new System.Drawing.Point(95, 237);
            this._accediButton.Name = "_accediButton";
            this._accediButton.Size = new System.Drawing.Size(123, 37);
            this._accediButton.TabIndex = 3;
            this._accediButton.Text = "Accedi";
            this._accediButton.UseVisualStyleBackColor = true;
            // 
            // _registratiButton
            // 
            this._registratiButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._registratiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._registratiButton.Location = new System.Drawing.Point(95, 281);
            this._registratiButton.Name = "_registratiButton";
            this._registratiButton.Size = new System.Drawing.Size(123, 36);
            this._registratiButton.TabIndex = 4;
            this._registratiButton.Text = "Registrati";
            this._registratiButton.UseVisualStyleBackColor = true;
            // 
            // _mailLabel
            // 
            this._mailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this._mailLabel.AutoSize = true;
            this._mailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._mailLabel.Location = new System.Drawing.Point(134, 25);
            this._mailLabel.Name = "_mailLabel";
            this._mailLabel.Size = new System.Drawing.Size(49, 16);
            this._mailLabel.TabIndex = 5;
            this._mailLabel.Text = "E-mail:";
            // 
            // _passwordLabel
            // 
            this._passwordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this._passwordLabel.AutoSize = true;
            this._passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._passwordLabel.Location = new System.Drawing.Point(125, 9);
            this._passwordLabel.Name = "_passwordLabel";
            this._passwordLabel.Size = new System.Drawing.Size(71, 16);
            this._passwordLabel.TabIndex = 6;
            this._passwordLabel.Text = "Password:";
            // 
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
            // 
            // _tableLayoutPanel
            // 
            this._tableLayoutPanel.ColumnCount = 1;
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanel.Controls.Add(this._titoloLabel, 0, 0);
            this._tableLayoutPanel.Controls.Add(this._registratiButton, 0, 4);
            this._tableLayoutPanel.Controls.Add(this._mailPanel, 0, 1);
            this._tableLayoutPanel.Controls.Add(this._accediButton, 0, 3);
            this._tableLayoutPanel.Controls.Add(this._passwordPanel, 0, 2);
            this._tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._tableLayoutPanel.Name = "_tableLayoutPanel";
            this._tableLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this._tableLayoutPanel.RowCount = 5;
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tableLayoutPanel.Size = new System.Drawing.Size(313, 326);
            this._tableLayoutPanel.TabIndex = 7;
            // 
            // _mailPanel
            // 
            this._mailPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._mailPanel.Controls.Add(this._mailTextBox);
            this._mailPanel.Controls.Add(this._mailLabel);
            this._mailPanel.Location = new System.Drawing.Point(0, 78);
            this._mailPanel.Margin = new System.Windows.Forms.Padding(0);
            this._mailPanel.Name = "_mailPanel";
            this._mailPanel.Size = new System.Drawing.Size(313, 78);
            this._mailPanel.TabIndex = 1;
            // 
            // _passwordPanel
            // 
            this._passwordPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._passwordPanel.Controls.Add(this._passwordTextBox);
            this._passwordPanel.Controls.Add(this._passwordLabel);
            this._passwordPanel.Location = new System.Drawing.Point(0, 156);
            this._passwordPanel.Margin = new System.Windows.Forms.Padding(0);
            this._passwordPanel.Name = "_passwordPanel";
            this._passwordPanel.Size = new System.Drawing.Size(313, 78);
            this._passwordPanel.TabIndex = 2;
            // 
            // LoginForm
            // 
            this.AcceptButton = this._accediButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 326);
            this.Controls.Add(this._tableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(329, 364);
            this.Name = "LoginForm";
            this.Text = "Room8 - Login";
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this._tableLayoutPanel.ResumeLayout(false);
            this._tableLayoutPanel.PerformLayout();
            this._mailPanel.ResumeLayout(false);
            this._mailPanel.PerformLayout();
            this._passwordPanel.ResumeLayout(false);
            this._passwordPanel.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel;
        private System.Windows.Forms.Panel _mailPanel;
        private System.Windows.Forms.Panel _passwordPanel;
    }
}