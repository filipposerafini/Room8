namespace Room8.View
{
    partial class RegistratiForm
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
            this._tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._nomeLabel = new System.Windows.Forms.Label();
            this._cognomeLabel = new System.Windows.Forms.Label();
            this._mailLabel = new System.Windows.Forms.Label();
            this._passwordLabel = new System.Windows.Forms.Label();
            this._confermaPasswordLabel = new System.Windows.Forms.Label();
            this._telefonoLabel = new System.Windows.Forms.Label();
            this._nomeTextBox = new System.Windows.Forms.TextBox();
            this._cognomeTextBox = new System.Windows.Forms.TextBox();
            this._mailTextBox = new System.Windows.Forms.TextBox();
            this._passwordTextBox = new System.Windows.Forms.TextBox();
            this._confermaPasswordTextBox = new System.Windows.Forms.TextBox();
            this._telefonoTextBox = new System.Windows.Forms.TextBox();
            this._confermaButton = new System.Windows.Forms.Button();
            this._splitContainer = new System.Windows.Forms.SplitContainer();
            this._registratiLabel = new System.Windows.Forms.Label();
            this._annullaButton = new System.Windows.Forms.Button();
            this._tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).BeginInit();
            this._splitContainer.Panel1.SuspendLayout();
            this._splitContainer.Panel2.SuspendLayout();
            this._splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tableLayoutPanel
            // 
            this._tableLayoutPanel.ColumnCount = 2;
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this._tableLayoutPanel.Controls.Add(this._nomeLabel, 0, 0);
            this._tableLayoutPanel.Controls.Add(this._cognomeLabel, 0, 1);
            this._tableLayoutPanel.Controls.Add(this._mailLabel, 0, 2);
            this._tableLayoutPanel.Controls.Add(this._passwordLabel, 0, 3);
            this._tableLayoutPanel.Controls.Add(this._confermaPasswordLabel, 0, 4);
            this._tableLayoutPanel.Controls.Add(this._telefonoLabel, 0, 5);
            this._tableLayoutPanel.Controls.Add(this._nomeTextBox, 1, 0);
            this._tableLayoutPanel.Controls.Add(this._mailTextBox, 1, 2);
            this._tableLayoutPanel.Controls.Add(this._passwordTextBox, 1, 3);
            this._tableLayoutPanel.Controls.Add(this._confermaPasswordTextBox, 1, 4);
            this._tableLayoutPanel.Controls.Add(this._telefonoTextBox, 1, 5);
            this._tableLayoutPanel.Controls.Add(this._cognomeTextBox, 1, 1);
            this._tableLayoutPanel.Controls.Add(this._annullaButton, 0, 6);
            this._tableLayoutPanel.Controls.Add(this._confermaButton, 1, 6);
            this._tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._tableLayoutPanel.Name = "_tableLayoutPanel";
            this._tableLayoutPanel.RowCount = 7;
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this._tableLayoutPanel.Size = new System.Drawing.Size(396, 274);
            this._tableLayoutPanel.TabIndex = 0;
            // 
            // _nomeLabel
            // 
            this._nomeLabel.AutoSize = true;
            this._nomeLabel.Location = new System.Drawing.Point(3, 0);
            this._nomeLabel.Name = "_nomeLabel";
            this._nomeLabel.Size = new System.Drawing.Size(35, 13);
            this._nomeLabel.TabIndex = 0;
            this._nomeLabel.Text = "Nome";
            // 
            // _cognomeLabel
            // 
            this._cognomeLabel.AutoSize = true;
            this._cognomeLabel.Location = new System.Drawing.Point(3, 39);
            this._cognomeLabel.Name = "_cognomeLabel";
            this._cognomeLabel.Size = new System.Drawing.Size(52, 13);
            this._cognomeLabel.TabIndex = 2;
            this._cognomeLabel.Text = "Cognome";
            // 
            // _mailLabel
            // 
            this._mailLabel.AutoSize = true;
            this._mailLabel.Location = new System.Drawing.Point(3, 78);
            this._mailLabel.Name = "_mailLabel";
            this._mailLabel.Size = new System.Drawing.Size(36, 13);
            this._mailLabel.TabIndex = 3;
            this._mailLabel.Text = "E-Mail";
            // 
            // _passwordLabel
            // 
            this._passwordLabel.AutoSize = true;
            this._passwordLabel.Location = new System.Drawing.Point(3, 117);
            this._passwordLabel.Name = "_passwordLabel";
            this._passwordLabel.Size = new System.Drawing.Size(53, 13);
            this._passwordLabel.TabIndex = 4;
            this._passwordLabel.Text = "Password";
            // 
            // _confermaPasswordLabel
            // 
            this._confermaPasswordLabel.AutoSize = true;
            this._confermaPasswordLabel.Location = new System.Drawing.Point(3, 156);
            this._confermaPasswordLabel.Name = "_confermaPasswordLabel";
            this._confermaPasswordLabel.Size = new System.Drawing.Size(101, 13);
            this._confermaPasswordLabel.TabIndex = 5;
            this._confermaPasswordLabel.Text = "Conferma Password";
            // 
            // _telefonoLabel
            // 
            this._telefonoLabel.AutoSize = true;
            this._telefonoLabel.Location = new System.Drawing.Point(3, 195);
            this._telefonoLabel.Name = "_telefonoLabel";
            this._telefonoLabel.Size = new System.Drawing.Size(49, 13);
            this._telefonoLabel.TabIndex = 1;
            this._telefonoLabel.Text = "Telefono";
            // 
            // _nomeTextBox
            // 
            this._nomeTextBox.Location = new System.Drawing.Point(121, 3);
            this._nomeTextBox.Name = "_nomeTextBox";
            this._nomeTextBox.Size = new System.Drawing.Size(100, 20);
            this._nomeTextBox.TabIndex = 6;
            // 
            // _cognomeTextBox
            // 
            this._cognomeTextBox.Location = new System.Drawing.Point(121, 42);
            this._cognomeTextBox.Name = "_cognomeTextBox";
            this._cognomeTextBox.Size = new System.Drawing.Size(100, 20);
            this._cognomeTextBox.TabIndex = 7;
            // 
            // _mailTextBox
            // 
            this._mailTextBox.Location = new System.Drawing.Point(121, 81);
            this._mailTextBox.Name = "_mailTextBox";
            this._mailTextBox.Size = new System.Drawing.Size(100, 20);
            this._mailTextBox.TabIndex = 8;
            // 
            // _passwordTextBox
            // 
            this._passwordTextBox.Location = new System.Drawing.Point(121, 120);
            this._passwordTextBox.Name = "_passwordTextBox";
            this._passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this._passwordTextBox.TabIndex = 9;
            // 
            // _confermaPasswordTextBox
            // 
            this._confermaPasswordTextBox.Location = new System.Drawing.Point(121, 159);
            this._confermaPasswordTextBox.Name = "_confermaPasswordTextBox";
            this._confermaPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this._confermaPasswordTextBox.TabIndex = 10;
            // 
            // _telefonoTextBox
            // 
            this._telefonoTextBox.Location = new System.Drawing.Point(121, 198);
            this._telefonoTextBox.Name = "_telefonoTextBox";
            this._telefonoTextBox.Size = new System.Drawing.Size(100, 20);
            this._telefonoTextBox.TabIndex = 11;
            // 
            // _confermaButton
            // 
            this._confermaButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._confermaButton.Location = new System.Drawing.Point(121, 237);
            this._confermaButton.Name = "_confermaButton";
            this._confermaButton.Size = new System.Drawing.Size(75, 23);
            this._confermaButton.TabIndex = 13;
            this._confermaButton.Text = "Conferma";
            this._confermaButton.UseVisualStyleBackColor = true;
            // 
            // _splitContainer
            // 
            this._splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitContainer.Location = new System.Drawing.Point(0, 0);
            this._splitContainer.Name = "_splitContainer";
            this._splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // _splitContainer.Panel1
            // 
            this._splitContainer.Panel1.Controls.Add(this._registratiLabel);
            // 
            // _splitContainer.Panel2
            // 
            this._splitContainer.Panel2.Controls.Add(this._tableLayoutPanel);
            this._splitContainer.Size = new System.Drawing.Size(396, 311);
            this._splitContainer.SplitterDistance = 33;
            this._splitContainer.TabIndex = 1;
            // 
            // _registratiLabel
            // 
            this._registratiLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._registratiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._registratiLabel.Location = new System.Drawing.Point(0, 0);
            this._registratiLabel.Name = "_registratiLabel";
            this._registratiLabel.Size = new System.Drawing.Size(396, 33);
            this._registratiLabel.TabIndex = 0;
            this._registratiLabel.Text = "Registrazione";
            this._registratiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _annullaButton
            // 
            this._annullaButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._annullaButton.Location = new System.Drawing.Point(3, 237);
            this._annullaButton.Name = "_annullaButton";
            this._annullaButton.Size = new System.Drawing.Size(75, 23);
            this._annullaButton.TabIndex = 14;
            this._annullaButton.Text = "Annulla";
            this._annullaButton.UseVisualStyleBackColor = true;
            // 
            // RegistratiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 311);
            this.Controls.Add(this._splitContainer);
            this.Name = "RegistratiForm";
            this.Text = "RegistratiForm";
            this._tableLayoutPanel.ResumeLayout(false);
            this._tableLayoutPanel.PerformLayout();
            this._splitContainer.Panel1.ResumeLayout(false);
            this._splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).EndInit();
            this._splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel;
        private System.Windows.Forms.Label _nomeLabel;
        private System.Windows.Forms.Label _cognomeLabel;
        private System.Windows.Forms.Label _mailLabel;
        private System.Windows.Forms.Label _passwordLabel;
        private System.Windows.Forms.Label _confermaPasswordLabel;
        private System.Windows.Forms.Label _telefonoLabel;
        private System.Windows.Forms.TextBox _nomeTextBox;
        private System.Windows.Forms.TextBox _cognomeTextBox;
        private System.Windows.Forms.TextBox _mailTextBox;
        private System.Windows.Forms.TextBox _passwordTextBox;
        private System.Windows.Forms.TextBox _confermaPasswordTextBox;
        private System.Windows.Forms.TextBox _telefonoTextBox;
        private System.Windows.Forms.Button _confermaButton;
        private System.Windows.Forms.SplitContainer _splitContainer;
        private System.Windows.Forms.Label _registratiLabel;
        private System.Windows.Forms.Button _annullaButton;
    }
}