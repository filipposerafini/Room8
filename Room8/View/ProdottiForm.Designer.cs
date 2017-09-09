namespace Room8.View
{
    partial class ProdottiForm
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
            this._prodottiPanel = new System.Windows.Forms.Panel();
            this._aggiungiButton = new System.Windows.Forms.Button();
            this._mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._formTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._scrollPanel = new System.Windows.Forms.Panel();
            this._prodottiLabel = new System.Windows.Forms.Label();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this._prodottoTextBox = new System.Windows.Forms.TextBox();
            this._prodottoLabel = new System.Windows.Forms.Label();
            this._checkBox = new System.Windows.Forms.CheckBox();
            this._rimuoviButton = new System.Windows.Forms.Button();
            this._prodottiPanel.SuspendLayout();
            this._mainTableLayoutPanel.SuspendLayout();
            this._formTableLayoutPanel.SuspendLayout();
            this._scrollPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // _prodottiPanel
            // 
            this._prodottiPanel.Controls.Add(this._rimuoviButton);
            this._prodottiPanel.Controls.Add(this._prodottoLabel);
            this._prodottiPanel.Controls.Add(this._prodottoTextBox);
            this._prodottiPanel.Controls.Add(this._aggiungiButton);
            this._prodottiPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._prodottiPanel.Location = new System.Drawing.Point(0, 206);
            this._prodottiPanel.Margin = new System.Windows.Forms.Padding(0);
            this._prodottiPanel.Name = "_prodottiPanel";
            this._prodottiPanel.Size = new System.Drawing.Size(311, 74);
            this._prodottiPanel.TabIndex = 1;
            // 
            // _aggiungiButton
            // 
            this._aggiungiButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._aggiungiButton.Location = new System.Drawing.Point(224, 32);
            this._aggiungiButton.Name = "_aggiungiButton";
            this._aggiungiButton.Size = new System.Drawing.Size(75, 23);
            this._aggiungiButton.TabIndex = 1;
            this._aggiungiButton.Text = "Aggiungi";
            this._aggiungiButton.UseVisualStyleBackColor = true;
            // 
            // _mainTableLayoutPanel
            // 
            this._mainTableLayoutPanel.ColumnCount = 1;
            this._mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._mainTableLayoutPanel.Controls.Add(this._prodottiPanel, 0, 2);
            this._mainTableLayoutPanel.Controls.Add(this._formTableLayoutPanel, 0, 1);
            this._mainTableLayoutPanel.Controls.Add(this._prodottiLabel, 0, 0);
            this._mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._mainTableLayoutPanel.Name = "_mainTableLayoutPanel";
            this._mainTableLayoutPanel.RowCount = 3;
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.21122F));
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.78571F));
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.07143F));
            this._mainTableLayoutPanel.Size = new System.Drawing.Size(311, 280);
            this._mainTableLayoutPanel.TabIndex = 4;
            // 
            // _formTableLayoutPanel
            // 
            this._formTableLayoutPanel.ColumnCount = 1;
            this._formTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._formTableLayoutPanel.Controls.Add(this._scrollPanel, 0, 0);
            this._formTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._formTableLayoutPanel.Location = new System.Drawing.Point(3, 37);
            this._formTableLayoutPanel.Name = "_formTableLayoutPanel";
            this._formTableLayoutPanel.RowCount = 1;
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this._formTableLayoutPanel.Size = new System.Drawing.Size(305, 166);
            this._formTableLayoutPanel.TabIndex = 2;
            // 
            // _scrollPanel
            // 
            this._scrollPanel.AutoScroll = true;
            this._scrollPanel.Controls.Add(this._checkBox);
            this._scrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._scrollPanel.Location = new System.Drawing.Point(0, 0);
            this._scrollPanel.Margin = new System.Windows.Forms.Padding(0);
            this._scrollPanel.Name = "_scrollPanel";
            this._scrollPanel.Size = new System.Drawing.Size(305, 166);
            this._scrollPanel.TabIndex = 0;
            // 
            // _prodottiLabel
            // 
            this._prodottiLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._prodottiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._prodottiLabel.Location = new System.Drawing.Point(3, 0);
            this._prodottiLabel.Name = "_prodottiLabel";
            this._prodottiLabel.Size = new System.Drawing.Size(305, 34);
            this._prodottiLabel.TabIndex = 0;
            this._prodottiLabel.Text = "Prodotti";
            this._prodottiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
            // 
            // _prodottoTextBox
            // 
            this._prodottoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._prodottoTextBox.Location = new System.Drawing.Point(68, 34);
            this._prodottoTextBox.Name = "_prodottoTextBox";
            this._prodottoTextBox.Size = new System.Drawing.Size(150, 20);
            this._prodottoTextBox.TabIndex = 2;
            // 
            // _prodottoLabel
            // 
            this._prodottoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._prodottoLabel.AutoSize = true;
            this._prodottoLabel.Location = new System.Drawing.Point(12, 37);
            this._prodottoLabel.Name = "_prodottoLabel";
            this._prodottoLabel.Size = new System.Drawing.Size(50, 13);
            this._prodottoLabel.TabIndex = 3;
            this._prodottoLabel.Text = "Prodotto:";
            // 
            // _checkBox
            // 
            this._checkBox.AutoSize = true;
            this._checkBox.Location = new System.Drawing.Point(9, 13);
            this._checkBox.Name = "_checkBox";
            this._checkBox.Size = new System.Drawing.Size(80, 17);
            this._checkBox.TabIndex = 0;
            this._checkBox.Text = "checkBox1";
            this._checkBox.UseVisualStyleBackColor = true;
            // 
            // _rimuoviButton
            // 
            this._rimuoviButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._rimuoviButton.Location = new System.Drawing.Point(193, 4);
            this._rimuoviButton.Name = "_rimuoviButton";
            this._rimuoviButton.Size = new System.Drawing.Size(106, 23);
            this._rimuoviButton.TabIndex = 4;
            this._rimuoviButton.Text = "Rimuovi selezionati";
            this._rimuoviButton.UseVisualStyleBackColor = true;
            // 
            // ProdottiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 280);
            this.Controls.Add(this._mainTableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(327, 318);
            this.Name = "ProdottiForm";
            this.Text = "Room8 - Prodotti";
            this._prodottiPanel.ResumeLayout(false);
            this._prodottiPanel.PerformLayout();
            this._mainTableLayoutPanel.ResumeLayout(false);
            this._formTableLayoutPanel.ResumeLayout(false);
            this._scrollPanel.ResumeLayout(false);
            this._scrollPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _prodottiPanel;
        private System.Windows.Forms.Button _aggiungiButton;
        private System.Windows.Forms.TableLayoutPanel _mainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel _formTableLayoutPanel;
        private System.Windows.Forms.Panel _scrollPanel;
        private System.Windows.Forms.Label _prodottiLabel;
        private System.Windows.Forms.ErrorProvider _errorProvider;
        private System.Windows.Forms.Button _rimuoviButton;
        private System.Windows.Forms.Label _prodottoLabel;
        private System.Windows.Forms.TextBox _prodottoTextBox;
        private System.Windows.Forms.CheckBox _checkBox;
    }
}