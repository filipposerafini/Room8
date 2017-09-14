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
            this._passwordTextBox = new System.Windows.Forms.TextBox();
            this._mailLabel = new System.Windows.Forms.Label();
            this._passwordLabel = new System.Windows.Forms.Label();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this._tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._mailTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._registratiButton = new System.Windows.Forms.Button();
            this._accediButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this._tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _titoloLabel
            // 
            this._titoloLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._titoloLabel.AutoSize = true;
            this._titoloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._titoloLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this._titoloLabel.Location = new System.Drawing.Point(46, 20);
            this._titoloLabel.Name = "_titoloLabel";
            this._titoloLabel.Size = new System.Drawing.Size(185, 55);
            this._titoloLabel.TabIndex = 0;
            this._titoloLabel.Text = "Room8";
            // 
            // _passwordTextBox
            // 
            this._passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._passwordTextBox.Location = new System.Drawing.Point(25, 186);
            this._passwordTextBox.Name = "_passwordTextBox";
            this._passwordTextBox.PasswordChar = '•';
            this._passwordTextBox.Size = new System.Drawing.Size(227, 20);
            this._passwordTextBox.TabIndex = 2;
            this._passwordTextBox.Text = "qwerqwerqwer";
            // 
            // _mailLabel
            // 
            this._mailLabel.AutoSize = true;
            this._mailLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._mailLabel.Location = new System.Drawing.Point(3, 96);
            this._mailLabel.Name = "_mailLabel";
            this._mailLabel.Size = new System.Drawing.Size(272, 23);
            this._mailLabel.TabIndex = 5;
            this._mailLabel.Text = "E-mail:";
            this._mailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _passwordLabel
            // 
            this._passwordLabel.AutoSize = true;
            this._passwordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._passwordLabel.Location = new System.Drawing.Point(3, 160);
            this._passwordLabel.Name = "_passwordLabel";
            this._passwordLabel.Size = new System.Drawing.Size(272, 19);
            this._passwordLabel.TabIndex = 6;
            this._passwordLabel.Text = "Password:";
            this._passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
            // 
            // _tableLayoutPanel
            // 
            this._tableLayoutPanel.ColumnCount = 1;
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanel.Controls.Add(this._mailTextBox, 0, 2);
            this._tableLayoutPanel.Controls.Add(this._mailLabel, 0, 1);
            this._tableLayoutPanel.Controls.Add(this._titoloLabel, 0, 0);
            this._tableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 5);
            this._tableLayoutPanel.Controls.Add(this._passwordLabel, 0, 3);
            this._tableLayoutPanel.Controls.Add(this._passwordTextBox, 0, 4);
            this._tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._tableLayoutPanel.Name = "_tableLayoutPanel";
            this._tableLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this._tableLayoutPanel.RowCount = 6;
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.68628F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.627451F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.29412F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.058824F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.80392F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.60785F));
            this._tableLayoutPanel.Size = new System.Drawing.Size(278, 273);
            this._tableLayoutPanel.TabIndex = 7;
            // 
            // _mailTextBox
            // 
            this._mailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._mailTextBox.Location = new System.Drawing.Point(25, 129);
            this._mailTextBox.Name = "_mailTextBox";
            this._mailTextBox.Size = new System.Drawing.Size(228, 20);
            this._mailTextBox.TabIndex = 7;
            this._mailTextBox.Text = "filippo@mail.com";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this._accediButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._registratiButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 213);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(278, 55);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // _registratiButton
            // 
            this._registratiButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._registratiButton.Location = new System.Drawing.Point(25, 16);
            this._registratiButton.Name = "_registratiButton";
            this._registratiButton.Size = new System.Drawing.Size(88, 23);
            this._registratiButton.TabIndex = 6;
            this._registratiButton.Text = "Registrati";
            this._registratiButton.UseVisualStyleBackColor = true;
            // 
            // _accediButton
            // 
            this._accediButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._accediButton.Location = new System.Drawing.Point(167, 16);
            this._accediButton.Name = "_accediButton";
            this._accediButton.Size = new System.Drawing.Size(82, 23);
            this._accediButton.TabIndex = 5;
            this._accediButton.Text = "Accedi";
            this._accediButton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 273);
            this.Controls.Add(this._tableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(294, 311);
            this.Name = "LoginForm";
            this.Text = "Room8 - Login";
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this._tableLayoutPanel.ResumeLayout(false);
            this._tableLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _titoloLabel;
        private System.Windows.Forms.TextBox _passwordTextBox;
        private System.Windows.Forms.Label _mailLabel;
        private System.Windows.Forms.Label _passwordLabel;
		private System.Windows.Forms.ErrorProvider _errorProvider;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button _accediButton;
        private System.Windows.Forms.Button _registratiButton;
        private System.Windows.Forms.TextBox _mailTextBox;
    }
}