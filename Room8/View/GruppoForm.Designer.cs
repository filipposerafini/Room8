namespace Room8.View
{
    partial class GruppoForm
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
            this._mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._gruppoLabel = new System.Windows.Forms.Label();
            this._confirmPanel = new System.Windows.Forms.Panel();
            this._confermaButton = new System.Windows.Forms.Button();
            this._annullaButton = new System.Windows.Forms.Button();
            this._formTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._membriLabel = new System.Windows.Forms.Label();
            this._nameGroupTableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._pagatoLabel = new System.Windows.Forms.Label();
            this._nomeGruppoTextBox = new System.Windows.Forms.TextBox();
            this._caricaPanel = new System.Windows.Forms.Panel();
            this._fileLabel = new System.Windows.Forms.Label();
            this._fotoButton = new System.Windows.Forms.Button();
            this._pictureBox = new System.Windows.Forms.PictureBox();
            this._addPanel = new System.Windows.Forms.Panel();
            this._addUserTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._addUserSplitContainer = new System.Windows.Forms.SplitContainer();
            this._mailLabel = new System.Windows.Forms.Label();
            this._mailTextBox = new System.Windows.Forms.TextBox();
            this._removeButton = new System.Windows.Forms.Button();
            this._creatorGroupLabel = new System.Windows.Forms.Label();
            this._aggiungiPersonaLinkLabel = new System.Windows.Forms.LinkLabel();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this._mainTableLayoutPanel.SuspendLayout();
            this._confirmPanel.SuspendLayout();
            this._formTableLayoutPanel.SuspendLayout();
            this._nameGroupTableLayoutPanel1.SuspendLayout();
            this._caricaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).BeginInit();
            this._addPanel.SuspendLayout();
            this._addUserTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._addUserSplitContainer)).BeginInit();
            this._addUserSplitContainer.Panel1.SuspendLayout();
            this._addUserSplitContainer.Panel2.SuspendLayout();
            this._addUserSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // _mainTableLayoutPanel
            // 
            this._mainTableLayoutPanel.ColumnCount = 1;
            this._mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._mainTableLayoutPanel.Controls.Add(this._gruppoLabel, 0, 0);
            this._mainTableLayoutPanel.Controls.Add(this._confirmPanel, 0, 2);
            this._mainTableLayoutPanel.Controls.Add(this._formTableLayoutPanel, 0, 1);
            this._mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._mainTableLayoutPanel.Name = "_mainTableLayoutPanel";
            this._mainTableLayoutPanel.RowCount = 3;
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._mainTableLayoutPanel.Size = new System.Drawing.Size(357, 318);
            this._mainTableLayoutPanel.TabIndex = 2;
            // 
            // _gruppoLabel
            // 
            this._gruppoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._gruppoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._gruppoLabel.Location = new System.Drawing.Point(3, 0);
            this._gruppoLabel.Name = "_gruppoLabel";
            this._gruppoLabel.Size = new System.Drawing.Size(351, 34);
            this._gruppoLabel.TabIndex = 0;
            this._gruppoLabel.Text = "Gruppo";
            this._gruppoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _confirmPanel
            // 
            this._confirmPanel.Controls.Add(this._confermaButton);
            this._confirmPanel.Controls.Add(this._annullaButton);
            this._confirmPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._confirmPanel.Location = new System.Drawing.Point(0, 279);
            this._confirmPanel.Margin = new System.Windows.Forms.Padding(0);
            this._confirmPanel.Name = "_confirmPanel";
            this._confirmPanel.Size = new System.Drawing.Size(357, 39);
            this._confirmPanel.TabIndex = 1;
            // 
            // _confermaButton
            // 
            this._confermaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._confermaButton.Location = new System.Drawing.Point(189, 4);
            this._confermaButton.Name = "_confermaButton";
            this._confermaButton.Size = new System.Drawing.Size(75, 23);
            this._confermaButton.TabIndex = 1;
            this._confermaButton.Text = "Conferma";
            this._confermaButton.UseVisualStyleBackColor = true;
            // 
            // _annullaButton
            // 
            this._annullaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._annullaButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._annullaButton.Location = new System.Drawing.Point(270, 4);
            this._annullaButton.Name = "_annullaButton";
            this._annullaButton.Size = new System.Drawing.Size(75, 23);
            this._annullaButton.TabIndex = 0;
            this._annullaButton.Text = "Annulla";
            this._annullaButton.UseVisualStyleBackColor = true;
            // 
            // _formTableLayoutPanel
            // 
            this._formTableLayoutPanel.ColumnCount = 1;
            this._formTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._formTableLayoutPanel.Controls.Add(this._membriLabel, 0, 1);
            this._formTableLayoutPanel.Controls.Add(this._nameGroupTableLayoutPanel1, 0, 0);
            this._formTableLayoutPanel.Controls.Add(this._addPanel, 0, 2);
            this._formTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._formTableLayoutPanel.Location = new System.Drawing.Point(3, 37);
            this._formTableLayoutPanel.Name = "_formTableLayoutPanel";
            this._formTableLayoutPanel.RowCount = 3;
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._formTableLayoutPanel.Size = new System.Drawing.Size(351, 239);
            this._formTableLayoutPanel.TabIndex = 2;
            // 
            // _membriLabel
            // 
            this._membriLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._membriLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._membriLabel.Location = new System.Drawing.Point(3, 93);
            this._membriLabel.Name = "_membriLabel";
            this._membriLabel.Size = new System.Drawing.Size(345, 33);
            this._membriLabel.TabIndex = 1;
            this._membriLabel.Text = "Membri del gruppo:";
            this._membriLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // _nameGroupTableLayoutPanel1
            // 
            this._nameGroupTableLayoutPanel1.ColumnCount = 2;
            this._nameGroupTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.17094F));
            this._nameGroupTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.82906F));
            this._nameGroupTableLayoutPanel1.Controls.Add(this._pagatoLabel, 0, 0);
            this._nameGroupTableLayoutPanel1.Controls.Add(this._nomeGruppoTextBox, 1, 0);
            this._nameGroupTableLayoutPanel1.Controls.Add(this._caricaPanel, 1, 1);
            this._nameGroupTableLayoutPanel1.Controls.Add(this._pictureBox, 0, 1);
            this._nameGroupTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._nameGroupTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this._nameGroupTableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this._nameGroupTableLayoutPanel1.Name = "_nameGroupTableLayoutPanel1";
            this._nameGroupTableLayoutPanel1.RowCount = 2;
            this._nameGroupTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._nameGroupTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this._nameGroupTableLayoutPanel1.Size = new System.Drawing.Size(351, 93);
            this._nameGroupTableLayoutPanel1.TabIndex = 3;
            // 
            // _pagatoLabel
            // 
            this._pagatoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pagatoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._pagatoLabel.Location = new System.Drawing.Point(3, 0);
            this._pagatoLabel.Name = "_pagatoLabel";
            this._pagatoLabel.Size = new System.Drawing.Size(135, 38);
            this._pagatoLabel.TabIndex = 0;
            this._pagatoLabel.Text = "Nome del gruppo:";
            this._pagatoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _nomeGruppoTextBox
            // 
            this._nomeGruppoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._nomeGruppoTextBox.Location = new System.Drawing.Point(161, 9);
            this._nomeGruppoTextBox.Name = "_nomeGruppoTextBox";
            this._nomeGruppoTextBox.Size = new System.Drawing.Size(170, 20);
            this._nomeGruppoTextBox.TabIndex = 1;
            // 
            // _caricaPanel
            // 
            this._caricaPanel.Controls.Add(this._fileLabel);
            this._caricaPanel.Controls.Add(this._fotoButton);
            this._caricaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._caricaPanel.Location = new System.Drawing.Point(144, 41);
            this._caricaPanel.Name = "_caricaPanel";
            this._caricaPanel.Size = new System.Drawing.Size(204, 49);
            this._caricaPanel.TabIndex = 5;
            // 
            // _fileLabel
            // 
            this._fileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this._fileLabel.AutoSize = true;
            this._fileLabel.Location = new System.Drawing.Point(98, 18);
            this._fileLabel.Name = "_fileLabel";
            this._fileLabel.Size = new System.Drawing.Size(78, 13);
            this._fileLabel.TabIndex = 5;
            this._fileLabel.Text = "Seleziona file...";
            // 
            // _fotoButton
            // 
            this._fotoButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._fotoButton.Location = new System.Drawing.Point(17, 13);
            this._fotoButton.Name = "_fotoButton";
            this._fotoButton.Size = new System.Drawing.Size(75, 23);
            this._fotoButton.TabIndex = 4;
            this._fotoButton.Text = "Carica foto";
            this._fotoButton.UseVisualStyleBackColor = true;
            // 
            // _pictureBox
            // 
            this._pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._pictureBox.Image = global::Room8.Properties.Resources.defaultgroup;
            this._pictureBox.Location = new System.Drawing.Point(45, 40);
            this._pictureBox.Margin = new System.Windows.Forms.Padding(0);
            this._pictureBox.Name = "_pictureBox";
            this._pictureBox.Size = new System.Drawing.Size(50, 50);
            this._pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._pictureBox.TabIndex = 6;
            this._pictureBox.TabStop = false;
            // 
            // _addPanel
            // 
            this._addPanel.AutoScroll = true;
            this._addPanel.Controls.Add(this._addUserTableLayoutPanel);
            this._addPanel.Controls.Add(this._creatorGroupLabel);
            this._addPanel.Controls.Add(this._aggiungiPersonaLinkLabel);
            this._addPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._addPanel.Location = new System.Drawing.Point(0, 126);
            this._addPanel.Margin = new System.Windows.Forms.Padding(0);
            this._addPanel.Name = "_addPanel";
            this._addPanel.Size = new System.Drawing.Size(351, 113);
            this._addPanel.TabIndex = 4;
            // 
            // _addUserTableLayoutPanel
            // 
            this._addUserTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._addUserTableLayoutPanel.ColumnCount = 1;
            this._addUserTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._addUserTableLayoutPanel.Controls.Add(this._addUserSplitContainer, 0, 0);
            this._addUserTableLayoutPanel.Location = new System.Drawing.Point(3, 32);
            this._addUserTableLayoutPanel.Name = "_addUserTableLayoutPanel";
            this._addUserTableLayoutPanel.RowCount = 1;
            this._addUserTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._addUserTableLayoutPanel.Size = new System.Drawing.Size(345, 51);
            this._addUserTableLayoutPanel.TabIndex = 5;
            // 
            // _addUserSplitContainer
            // 
            this._addUserSplitContainer.Location = new System.Drawing.Point(3, 3);
            this._addUserSplitContainer.Name = "_addUserSplitContainer";
            // 
            // _addUserSplitContainer.Panel1
            // 
            this._addUserSplitContainer.Panel1.Controls.Add(this._mailLabel);
            this._addUserSplitContainer.Panel1.Controls.Add(this._mailTextBox);
            // 
            // _addUserSplitContainer.Panel2
            // 
            this._addUserSplitContainer.Panel2.Controls.Add(this._removeButton);
            this._addUserSplitContainer.Size = new System.Drawing.Size(339, 45);
            this._addUserSplitContainer.SplitterDistance = 265;
            this._addUserSplitContainer.TabIndex = 0;
            // 
            // _mailLabel
            // 
            this._mailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this._mailLabel.AutoSize = true;
            this._mailLabel.Location = new System.Drawing.Point(22, 14);
            this._mailLabel.Name = "_mailLabel";
            this._mailLabel.Size = new System.Drawing.Size(35, 13);
            this._mailLabel.TabIndex = 2;
            this._mailLabel.Text = "E-mail";
            // 
            // _mailTextBox
            // 
            this._mailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this._mailTextBox.Location = new System.Drawing.Point(68, 11);
            this._mailTextBox.Name = "_mailTextBox";
            this._mailTextBox.Size = new System.Drawing.Size(187, 20);
            this._mailTextBox.TabIndex = 1;
            // 
            // _removeButton
            // 
            this._removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this._removeButton.Location = new System.Drawing.Point(21, 9);
            this._removeButton.Name = "_removeButton";
            this._removeButton.Size = new System.Drawing.Size(27, 23);
            this._removeButton.TabIndex = 0;
            this._removeButton.Text = "X";
            this._removeButton.UseVisualStyleBackColor = true;
            // 
            // _creatorGroupLabel
            // 
            this._creatorGroupLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this._creatorGroupLabel.AutoSize = true;
            this._creatorGroupLabel.Location = new System.Drawing.Point(9, 16);
            this._creatorGroupLabel.Name = "_creatorGroupLabel";
            this._creatorGroupLabel.Size = new System.Drawing.Size(64, 13);
            this._creatorGroupLabel.TabIndex = 3;
            this._creatorGroupLabel.Text = "Tua mail qui";
            // 
            // _aggiungiPersonaLinkLabel
            // 
            this._aggiungiPersonaLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this._aggiungiPersonaLinkLabel.AutoSize = true;
            this._aggiungiPersonaLinkLabel.Location = new System.Drawing.Point(232, 16);
            this._aggiungiPersonaLinkLabel.Name = "_aggiungiPersonaLinkLabel";
            this._aggiungiPersonaLinkLabel.Size = new System.Drawing.Size(116, 13);
            this._aggiungiPersonaLinkLabel.TabIndex = 2;
            this._aggiungiPersonaLinkLabel.TabStop = true;
            this._aggiungiPersonaLinkLabel.Text = "+Aggiungi una persona";
            this._aggiungiPersonaLinkLabel.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
            // 
            // GruppoForm
            // 
            this.AcceptButton = this._confermaButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 318);
            this.Controls.Add(this._mainTableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(373, 356);
            this.Name = "GruppoForm";
            this.Text = "Room8 - Gruppo";
            this._mainTableLayoutPanel.ResumeLayout(false);
            this._confirmPanel.ResumeLayout(false);
            this._formTableLayoutPanel.ResumeLayout(false);
            this._nameGroupTableLayoutPanel1.ResumeLayout(false);
            this._nameGroupTableLayoutPanel1.PerformLayout();
            this._caricaPanel.ResumeLayout(false);
            this._caricaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).EndInit();
            this._addPanel.ResumeLayout(false);
            this._addPanel.PerformLayout();
            this._addUserTableLayoutPanel.ResumeLayout(false);
            this._addUserSplitContainer.Panel1.ResumeLayout(false);
            this._addUserSplitContainer.Panel1.PerformLayout();
            this._addUserSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._addUserSplitContainer)).EndInit();
            this._addUserSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _mainTableLayoutPanel;
        private System.Windows.Forms.Label _gruppoLabel;
        private System.Windows.Forms.Panel _confirmPanel;
        private System.Windows.Forms.Button _confermaButton;
        private System.Windows.Forms.Button _annullaButton;
        private System.Windows.Forms.TableLayoutPanel _formTableLayoutPanel;
        private System.Windows.Forms.Label _pagatoLabel;
        private System.Windows.Forms.Label _membriLabel;
        private System.Windows.Forms.TableLayoutPanel _nameGroupTableLayoutPanel1;
        private System.Windows.Forms.TextBox _nomeGruppoTextBox;
        private System.Windows.Forms.Panel _addPanel;
        private System.Windows.Forms.Label _creatorGroupLabel;
        private System.Windows.Forms.LinkLabel _aggiungiPersonaLinkLabel;
        private System.Windows.Forms.ErrorProvider _errorProvider;
        private System.Windows.Forms.TableLayoutPanel _addUserTableLayoutPanel;
        private System.Windows.Forms.SplitContainer _addUserSplitContainer;
        private System.Windows.Forms.Label _mailLabel;
        private System.Windows.Forms.TextBox _mailTextBox;
        private System.Windows.Forms.Button _removeButton;
        private System.Windows.Forms.Panel _caricaPanel;
        private System.Windows.Forms.Label _fileLabel;
        private System.Windows.Forms.Button _fotoButton;
        private System.Windows.Forms.PictureBox _pictureBox;
    }
}