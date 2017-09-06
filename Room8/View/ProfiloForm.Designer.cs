namespace Room8.View
{
    partial class ProfiloForm
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
            this._tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._registratiLabel = new System.Windows.Forms.Label();
            this._confermaPanel = new System.Windows.Forms.Panel();
            this._annullaButton = new System.Windows.Forms.Button();
            this._confermaButton = new System.Windows.Forms.Button();
            this._centralTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._formTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._vecchiaPasswordTextBox = new System.Windows.Forms.TextBox();
            this._nomeLabel = new System.Windows.Forms.Label();
            this._cognomeLabel = new System.Windows.Forms.Label();
            this._mailLabel = new System.Windows.Forms.Label();
            this._nomeTextBox = new System.Windows.Forms.TextBox();
            this._mailTextBox = new System.Windows.Forms.TextBox();
            this._cognomeTextBox = new System.Windows.Forms.TextBox();
            this._telefonoTextBox = new System.Windows.Forms.TextBox();
            this._telefonoLabel = new System.Windows.Forms.Label();
            this._confermaNuovaPasswordTextBox = new System.Windows.Forms.TextBox();
            this._nuovaPasswordTextBox = new System.Windows.Forms.TextBox();
            this._confermaPasswordLabel = new System.Windows.Forms.Label();
            this._passwordLabel = new System.Windows.Forms.Label();
            this._vecchiaMailLabel = new System.Windows.Forms.Label();
            this._imageTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._fotoPanel = new System.Windows.Forms.Panel();
            this._fileLabel = new System.Windows.Forms.Label();
            this._fotoButton = new System.Windows.Forms.Button();
            this._pictureBox = new System.Windows.Forms.PictureBox();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this._tableLayoutPanel.SuspendLayout();
            this._confermaPanel.SuspendLayout();
            this._centralTableLayoutPanel.SuspendLayout();
            this._formTableLayoutPanel.SuspendLayout();
            this._imageTableLayoutPanel.SuspendLayout();
            this._fotoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // _tableLayoutPanel
            // 
            this._tableLayoutPanel.ColumnCount = 1;
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanel.Controls.Add(this._registratiLabel, 0, 0);
            this._tableLayoutPanel.Controls.Add(this._confermaPanel, 0, 2);
            this._tableLayoutPanel.Controls.Add(this._centralTableLayoutPanel, 0, 1);
            this._tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._tableLayoutPanel.Name = "_tableLayoutPanel";
            this._tableLayoutPanel.RowCount = 3;
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._tableLayoutPanel.Size = new System.Drawing.Size(521, 312);
            this._tableLayoutPanel.TabIndex = 2;
            // 
            // _registratiLabel
            // 
            this._registratiLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._registratiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._registratiLabel.Location = new System.Drawing.Point(3, 0);
            this._registratiLabel.Name = "_registratiLabel";
            this._registratiLabel.Size = new System.Drawing.Size(515, 33);
            this._registratiLabel.TabIndex = 0;
            this._registratiLabel.Text = "Il tuo account";
            this._registratiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _confermaPanel
            // 
            this._confermaPanel.Controls.Add(this._annullaButton);
            this._confermaPanel.Controls.Add(this._confermaButton);
            this._confermaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._confermaPanel.Location = new System.Drawing.Point(0, 265);
            this._confermaPanel.Margin = new System.Windows.Forms.Padding(0);
            this._confermaPanel.Name = "_confermaPanel";
            this._confermaPanel.Size = new System.Drawing.Size(521, 47);
            this._confermaPanel.TabIndex = 14;
            // 
            // _annullaButton
            // 
            this._annullaButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._annullaButton.Location = new System.Drawing.Point(434, 8);
            this._annullaButton.Name = "_annullaButton";
            this._annullaButton.Size = new System.Drawing.Size(75, 23);
            this._annullaButton.TabIndex = 14;
            this._annullaButton.Text = "Annulla";
            this._annullaButton.UseVisualStyleBackColor = true;
			this._annullaButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            // 
            // _confermaButton
            // 
            this._confermaButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._confermaButton.Location = new System.Drawing.Point(356, 8);
            this._confermaButton.Name = "_confermaButton";
            this._confermaButton.Size = new System.Drawing.Size(75, 23);
            this._confermaButton.TabIndex = 13;
            this._confermaButton.Text = "Conferma";
            this._confermaButton.UseVisualStyleBackColor = true;
            // 
            // _centralTableLayoutPanel
            // 
            this._centralTableLayoutPanel.ColumnCount = 2;
            this._centralTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._centralTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 330F));
            this._centralTableLayoutPanel.Controls.Add(this._formTableLayoutPanel, 1, 0);
            this._centralTableLayoutPanel.Controls.Add(this._imageTableLayoutPanel, 0, 0);
            this._centralTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._centralTableLayoutPanel.Location = new System.Drawing.Point(0, 33);
            this._centralTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this._centralTableLayoutPanel.Name = "_centralTableLayoutPanel";
            this._centralTableLayoutPanel.RowCount = 1;
            this._centralTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._centralTableLayoutPanel.Size = new System.Drawing.Size(521, 232);
            this._centralTableLayoutPanel.TabIndex = 15;
            // 
            // _formTableLayoutPanel
            // 
            this._formTableLayoutPanel.ColumnCount = 2;
            this._formTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.30664F));
            this._formTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.69336F));
            this._formTableLayoutPanel.Controls.Add(this._vecchiaPasswordTextBox, 1, 3);
            this._formTableLayoutPanel.Controls.Add(this._nomeLabel, 0, 0);
            this._formTableLayoutPanel.Controls.Add(this._cognomeLabel, 0, 1);
            this._formTableLayoutPanel.Controls.Add(this._mailLabel, 0, 2);
            this._formTableLayoutPanel.Controls.Add(this._nomeTextBox, 1, 0);
            this._formTableLayoutPanel.Controls.Add(this._mailTextBox, 1, 2);
            this._formTableLayoutPanel.Controls.Add(this._cognomeTextBox, 1, 1);
            this._formTableLayoutPanel.Controls.Add(this._telefonoTextBox, 1, 6);
            this._formTableLayoutPanel.Controls.Add(this._telefonoLabel, 0, 6);
            this._formTableLayoutPanel.Controls.Add(this._confermaNuovaPasswordTextBox, 1, 5);
            this._formTableLayoutPanel.Controls.Add(this._nuovaPasswordTextBox, 1, 4);
            this._formTableLayoutPanel.Controls.Add(this._confermaPasswordLabel, 0, 5);
            this._formTableLayoutPanel.Controls.Add(this._passwordLabel, 0, 4);
            this._formTableLayoutPanel.Controls.Add(this._vecchiaMailLabel, 0, 3);
            this._formTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._formTableLayoutPanel.Location = new System.Drawing.Point(191, 0);
            this._formTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this._formTableLayoutPanel.Name = "_formTableLayoutPanel";
            this._formTableLayoutPanel.RowCount = 7;
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this._formTableLayoutPanel.Size = new System.Drawing.Size(330, 232);
            this._formTableLayoutPanel.TabIndex = 0;
            // 
            // _vecchiaPasswordTextBox
            // 
            this._vecchiaPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._vecchiaPasswordTextBox.Location = new System.Drawing.Point(142, 105);
            this._vecchiaPasswordTextBox.Name = "_vecchiaPasswordTextBox";
            this._vecchiaPasswordTextBox.PasswordChar = '•';
            this._vecchiaPasswordTextBox.Size = new System.Drawing.Size(160, 20);
            this._vecchiaPasswordTextBox.TabIndex = 12;
            // 
            // _nomeLabel
            // 
            this._nomeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._nomeLabel.Location = new System.Drawing.Point(3, 0);
            this._nomeLabel.Name = "_nomeLabel";
            this._nomeLabel.Size = new System.Drawing.Size(133, 33);
            this._nomeLabel.TabIndex = 0;
            this._nomeLabel.Text = "Nome:";
            this._nomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _cognomeLabel
            // 
            this._cognomeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cognomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cognomeLabel.Location = new System.Drawing.Point(3, 33);
            this._cognomeLabel.Name = "_cognomeLabel";
            this._cognomeLabel.Size = new System.Drawing.Size(133, 33);
            this._cognomeLabel.TabIndex = 2;
            this._cognomeLabel.Text = "Cognome:";
            this._cognomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _mailLabel
            // 
            this._mailLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._mailLabel.Location = new System.Drawing.Point(3, 66);
            this._mailLabel.Name = "_mailLabel";
            this._mailLabel.Size = new System.Drawing.Size(133, 33);
            this._mailLabel.TabIndex = 3;
            this._mailLabel.Text = "E-Mail:";
            this._mailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _nomeTextBox
            // 
            this._nomeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._nomeTextBox.Location = new System.Drawing.Point(142, 6);
            this._nomeTextBox.Name = "_nomeTextBox";
            this._nomeTextBox.Size = new System.Drawing.Size(160, 20);
            this._nomeTextBox.TabIndex = 6;
            // 
            // _mailTextBox
            // 
            this._mailTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._mailTextBox.Location = new System.Drawing.Point(142, 72);
            this._mailTextBox.Name = "_mailTextBox";
            this._mailTextBox.Size = new System.Drawing.Size(160, 20);
            this._mailTextBox.TabIndex = 8;
            // 
            // _cognomeTextBox
            // 
            this._cognomeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._cognomeTextBox.Location = new System.Drawing.Point(142, 39);
            this._cognomeTextBox.Name = "_cognomeTextBox";
            this._cognomeTextBox.Size = new System.Drawing.Size(160, 20);
            this._cognomeTextBox.TabIndex = 7;
            // 
            // _telefonoTextBox
            // 
            this._telefonoTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._telefonoTextBox.Location = new System.Drawing.Point(142, 205);
            this._telefonoTextBox.Name = "_telefonoTextBox";
            this._telefonoTextBox.Size = new System.Drawing.Size(160, 20);
            this._telefonoTextBox.TabIndex = 11;
            // 
            // _telefonoLabel
            // 
            this._telefonoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._telefonoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._telefonoLabel.Location = new System.Drawing.Point(3, 198);
            this._telefonoLabel.Name = "_telefonoLabel";
            this._telefonoLabel.Size = new System.Drawing.Size(133, 34);
            this._telefonoLabel.TabIndex = 1;
            this._telefonoLabel.Text = "Telefono:";
            this._telefonoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _confermaNuovaPasswordTextBox
            // 
            this._confermaNuovaPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._confermaNuovaPasswordTextBox.Location = new System.Drawing.Point(142, 171);
            this._confermaNuovaPasswordTextBox.Name = "_confermaNuovaPasswordTextBox";
            this._confermaNuovaPasswordTextBox.PasswordChar = '•';
            this._confermaNuovaPasswordTextBox.Size = new System.Drawing.Size(160, 20);
            this._confermaNuovaPasswordTextBox.TabIndex = 10;
            // 
            // _nuovaPasswordTextBox
            // 
            this._nuovaPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._nuovaPasswordTextBox.Location = new System.Drawing.Point(142, 138);
            this._nuovaPasswordTextBox.Name = "_nuovaPasswordTextBox";
            this._nuovaPasswordTextBox.PasswordChar = '•';
            this._nuovaPasswordTextBox.Size = new System.Drawing.Size(160, 20);
            this._nuovaPasswordTextBox.TabIndex = 9;
            // 
            // _confermaPasswordLabel
            // 
            this._confermaPasswordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._confermaPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._confermaPasswordLabel.Location = new System.Drawing.Point(3, 165);
            this._confermaPasswordLabel.Name = "_confermaPasswordLabel";
            this._confermaPasswordLabel.Size = new System.Drawing.Size(133, 33);
            this._confermaPasswordLabel.TabIndex = 5;
            this._confermaPasswordLabel.Text = "Conferma nuova password:";
            this._confermaPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _passwordLabel
            // 
            this._passwordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._passwordLabel.Location = new System.Drawing.Point(3, 132);
            this._passwordLabel.Name = "_passwordLabel";
            this._passwordLabel.Size = new System.Drawing.Size(133, 33);
            this._passwordLabel.TabIndex = 4;
            this._passwordLabel.Text = "Nuova password:";
            this._passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _vecchiaMailLabel
            // 
            this._vecchiaMailLabel.AutoSize = true;
            this._vecchiaMailLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._vecchiaMailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._vecchiaMailLabel.Location = new System.Drawing.Point(3, 99);
            this._vecchiaMailLabel.Name = "_vecchiaMailLabel";
            this._vecchiaMailLabel.Size = new System.Drawing.Size(133, 33);
            this._vecchiaMailLabel.TabIndex = 13;
            this._vecchiaMailLabel.Text = "Vecchia password";
            this._vecchiaMailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _imageTableLayoutPanel
            // 
            this._imageTableLayoutPanel.ColumnCount = 1;
            this._imageTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._imageTableLayoutPanel.Controls.Add(this._fotoPanel, 0, 1);
            this._imageTableLayoutPanel.Controls.Add(this._pictureBox, 0, 0);
            this._imageTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._imageTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._imageTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this._imageTableLayoutPanel.Name = "_imageTableLayoutPanel";
            this._imageTableLayoutPanel.RowCount = 2;
            this._imageTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.52788F));
            this._imageTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.47212F));
            this._imageTableLayoutPanel.Size = new System.Drawing.Size(191, 232);
            this._imageTableLayoutPanel.TabIndex = 1;
            // 
            // _fotoPanel
            // 
            this._fotoPanel.Controls.Add(this._fileLabel);
            this._fotoPanel.Controls.Add(this._fotoButton);
            this._fotoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._fotoPanel.Location = new System.Drawing.Point(0, 191);
            this._fotoPanel.Margin = new System.Windows.Forms.Padding(0);
            this._fotoPanel.Name = "_fotoPanel";
            this._fotoPanel.Size = new System.Drawing.Size(191, 41);
            this._fotoPanel.TabIndex = 13;
            // 
            // _fileLabel
            // 
            this._fileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this._fileLabel.AutoSize = true;
            this._fileLabel.Location = new System.Drawing.Point(97, 17);
            this._fileLabel.Name = "_fileLabel";
            this._fileLabel.Size = new System.Drawing.Size(78, 13);
            this._fileLabel.TabIndex = 3;
            this._fileLabel.Text = "Seleziona file...";
            // 
            // _fotoButton
            // 
            this._fotoButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._fotoButton.Location = new System.Drawing.Point(16, 12);
            this._fotoButton.Name = "_fotoButton";
            this._fotoButton.Size = new System.Drawing.Size(75, 23);
            this._fotoButton.TabIndex = 2;
            this._fotoButton.Text = "Carica foto";
            this._fotoButton.UseVisualStyleBackColor = true;
            // 
            // _pictureBox
            // 
            this._pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pictureBox.Image = global::Room8.Properties.Resources._default;
            this._pictureBox.Location = new System.Drawing.Point(0, 0);
            this._pictureBox.Margin = new System.Windows.Forms.Padding(0);
            this._pictureBox.Name = "_pictureBox";
            this._pictureBox.Size = new System.Drawing.Size(191, 191);
            this._pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._pictureBox.TabIndex = 0;
            this._pictureBox.TabStop = false;
            // 
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
            // 
            // ProfiloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 312);
            this.Controls.Add(this._tableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(537, 350);
            this.Name = "ProfiloForm";
            this.Text = "Room8 - Profilo";
            this._tableLayoutPanel.ResumeLayout(false);
            this._confermaPanel.ResumeLayout(false);
            this._centralTableLayoutPanel.ResumeLayout(false);
            this._formTableLayoutPanel.ResumeLayout(false);
            this._formTableLayoutPanel.PerformLayout();
            this._imageTableLayoutPanel.ResumeLayout(false);
            this._fotoPanel.ResumeLayout(false);
            this._fotoPanel.PerformLayout();
			this.AcceptButton = this._confermaButton;
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel;
        private System.Windows.Forms.Label _registratiLabel;
        private System.Windows.Forms.Panel _confermaPanel;
        private System.Windows.Forms.Button _annullaButton;
        private System.Windows.Forms.Button _confermaButton;
        private System.Windows.Forms.TableLayoutPanel _centralTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel _formTableLayoutPanel;
        private System.Windows.Forms.TextBox _vecchiaPasswordTextBox;
        private System.Windows.Forms.Label _nomeLabel;
        private System.Windows.Forms.Label _cognomeLabel;
        private System.Windows.Forms.Label _mailLabel;
        private System.Windows.Forms.TextBox _nomeTextBox;
        private System.Windows.Forms.TextBox _mailTextBox;
        private System.Windows.Forms.TextBox _cognomeTextBox;
        private System.Windows.Forms.TextBox _telefonoTextBox;
        private System.Windows.Forms.Label _telefonoLabel;
        private System.Windows.Forms.TextBox _confermaNuovaPasswordTextBox;
        private System.Windows.Forms.TextBox _nuovaPasswordTextBox;
        private System.Windows.Forms.Label _confermaPasswordLabel;
        private System.Windows.Forms.Label _passwordLabel;
        private System.Windows.Forms.Label _vecchiaMailLabel;
        private System.Windows.Forms.TableLayoutPanel _imageTableLayoutPanel;
        private System.Windows.Forms.Panel _fotoPanel;
        private System.Windows.Forms.Label _fileLabel;
        private System.Windows.Forms.Button _fotoButton;
        private System.Windows.Forms.PictureBox _pictureBox;
        private System.Windows.Forms.ErrorProvider _errorProvider;
    }
}