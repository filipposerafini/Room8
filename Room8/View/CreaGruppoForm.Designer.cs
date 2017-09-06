namespace Room8.View
{
    partial class CreaGruppoForm
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
            this._saldaLabel = new System.Windows.Forms.Label();
            this._confirmPanel = new System.Windows.Forms.Panel();
            this._confermaButton = new System.Windows.Forms.Button();
            this._annullaButton = new System.Windows.Forms.Button();
            this._formTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._membriLabel = new System.Windows.Forms.Label();
            this._nameGroupTableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._pagatoLabel = new System.Windows.Forms.Label();
            this._nomeGruppoTextBox = new System.Windows.Forms.TextBox();
            this._addPanel = new System.Windows.Forms.Panel();
            this._creatorGroupLabel = new System.Windows.Forms.Label();
            this._aggiungiPersonaLinkLabel = new System.Windows.Forms.LinkLabel();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this._mainTableLayoutPanel.SuspendLayout();
            this._confirmPanel.SuspendLayout();
            this._formTableLayoutPanel.SuspendLayout();
            this._nameGroupTableLayoutPanel1.SuspendLayout();
            this._addPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // _mainTableLayoutPanel
            // 
            this._mainTableLayoutPanel.ColumnCount = 1;
            this._mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._mainTableLayoutPanel.Controls.Add(this._saldaLabel, 0, 0);
            this._mainTableLayoutPanel.Controls.Add(this._confirmPanel, 0, 2);
            this._mainTableLayoutPanel.Controls.Add(this._formTableLayoutPanel, 0, 1);
            this._mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._mainTableLayoutPanel.Name = "_mainTableLayoutPanel";
            this._mainTableLayoutPanel.RowCount = 3;
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._mainTableLayoutPanel.Size = new System.Drawing.Size(362, 262);
            this._mainTableLayoutPanel.TabIndex = 2;
            // 
            // _saldaLabel
            // 
            this._saldaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._saldaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._saldaLabel.Location = new System.Drawing.Point(3, 0);
            this._saldaLabel.Name = "_saldaLabel";
            this._saldaLabel.Size = new System.Drawing.Size(356, 34);
            this._saldaLabel.TabIndex = 0;
            this._saldaLabel.Text = "Crea gruppo";
            this._saldaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _confirmPanel
            // 
            this._confirmPanel.Controls.Add(this._confermaButton);
            this._confirmPanel.Controls.Add(this._annullaButton);
            this._confirmPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._confirmPanel.Location = new System.Drawing.Point(0, 223);
            this._confirmPanel.Margin = new System.Windows.Forms.Padding(0);
            this._confirmPanel.Name = "_confirmPanel";
            this._confirmPanel.Size = new System.Drawing.Size(362, 39);
            this._confirmPanel.TabIndex = 1;
            // 
            // _confermaButton
            // 
            this._confermaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._confermaButton.Location = new System.Drawing.Point(194, 4);
            this._confermaButton.Name = "_confermaButton";
            this._confermaButton.Size = new System.Drawing.Size(75, 23);
            this._confermaButton.TabIndex = 1;
            this._confermaButton.Text = "Conferma";
            this._confermaButton.UseVisualStyleBackColor = true;
            // 
            // _annullaButton
            // 
            this._annullaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._annullaButton.Location = new System.Drawing.Point(275, 4);
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
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._formTableLayoutPanel.Size = new System.Drawing.Size(356, 183);
            this._formTableLayoutPanel.TabIndex = 2;
            // 
            // _membriLabel
            // 
            this._membriLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._membriLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._membriLabel.Location = new System.Drawing.Point(3, 70);
            this._membriLabel.Name = "_membriLabel";
            this._membriLabel.Size = new System.Drawing.Size(350, 40);
            this._membriLabel.TabIndex = 1;
            this._membriLabel.Text = "Membri del gruppo:";
            this._membriLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // _nameGroupTableLayoutPanel1
            // 
            this._nameGroupTableLayoutPanel1.ColumnCount = 2;
            this._nameGroupTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._nameGroupTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._nameGroupTableLayoutPanel1.Controls.Add(this._pagatoLabel, 0, 0);
            this._nameGroupTableLayoutPanel1.Controls.Add(this._nomeGruppoTextBox, 1, 0);
            this._nameGroupTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._nameGroupTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this._nameGroupTableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this._nameGroupTableLayoutPanel1.Name = "_nameGroupTableLayoutPanel1";
            this._nameGroupTableLayoutPanel1.RowCount = 1;
            this._nameGroupTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._nameGroupTableLayoutPanel1.Size = new System.Drawing.Size(356, 70);
            this._nameGroupTableLayoutPanel1.TabIndex = 3;
            // 
            // _pagatoLabel
            // 
            this._pagatoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pagatoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._pagatoLabel.Location = new System.Drawing.Point(3, 0);
            this._pagatoLabel.Name = "_pagatoLabel";
            this._pagatoLabel.Size = new System.Drawing.Size(172, 70);
            this._pagatoLabel.TabIndex = 0;
            this._pagatoLabel.Text = "Nome del gruppo:";
            this._pagatoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _nomeGruppoTextBox
            // 
            this._nomeGruppoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._nomeGruppoTextBox.Location = new System.Drawing.Point(181, 25);
            this._nomeGruppoTextBox.Name = "_nomeGruppoTextBox";
            this._nomeGruppoTextBox.Size = new System.Drawing.Size(172, 20);
            this._nomeGruppoTextBox.TabIndex = 1;
            // 
            // _addPanel
            // 
            this._addPanel.Controls.Add(this._creatorGroupLabel);
            this._addPanel.Controls.Add(this._aggiungiPersonaLinkLabel);
            this._addPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._addPanel.Location = new System.Drawing.Point(0, 110);
            this._addPanel.Margin = new System.Windows.Forms.Padding(0);
            this._addPanel.Name = "_addPanel";
            this._addPanel.Size = new System.Drawing.Size(356, 73);
            this._addPanel.TabIndex = 4;
            // 
            // _creatorGroupLabel
            // 
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
            this._aggiungiPersonaLinkLabel.Location = new System.Drawing.Point(231, 16);
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
            // CreaGruppoForm
            // 
            this.AcceptButton = this._confermaButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 262);
            this.Controls.Add(this._mainTableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(378, 300);
            this.Name = "CreaGruppoForm";
            this.Text = "Room8 - Crea gruppo";
            this._mainTableLayoutPanel.ResumeLayout(false);
            this._confirmPanel.ResumeLayout(false);
            this._formTableLayoutPanel.ResumeLayout(false);
            this._nameGroupTableLayoutPanel1.ResumeLayout(false);
            this._nameGroupTableLayoutPanel1.PerformLayout();
            this._addPanel.ResumeLayout(false);
            this._addPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _mainTableLayoutPanel;
        private System.Windows.Forms.Label _saldaLabel;
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
    }
}