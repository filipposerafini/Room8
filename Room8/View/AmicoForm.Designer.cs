namespace Room8.View
{
    partial class AmicoForm
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
            this._mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._nomeTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._nomeAmicoLabel = new System.Windows.Forms.Label();
            this._pictureBox = new System.Windows.Forms.PictureBox();
            this._centralTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._bilancioTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._bilancioLabel = new System.Windows.Forms.Label();
            this._importoTotaleLabel = new System.Windows.Forms.Label();
            this._mainPanel = new System.Windows.Forms.Panel();
            this._confermaPanel = new System.Windows.Forms.Panel();
            this._annullaButton = new System.Windows.Forms.Button();
            this._confermaButton = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this._mainTableLayoutPanel.SuspendLayout();
            this._nomeTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).BeginInit();
            this._centralTableLayoutPanel.SuspendLayout();
            this._bilancioTableLayoutPanel.SuspendLayout();
            this._mainPanel.SuspendLayout();
            this._confermaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mainTableLayoutPanel
            // 
            this._mainTableLayoutPanel.ColumnCount = 1;
            this._mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._mainTableLayoutPanel.Controls.Add(this._nomeTableLayoutPanel, 0, 0);
            this._mainTableLayoutPanel.Controls.Add(this._centralTableLayoutPanel, 0, 1);
            this._mainTableLayoutPanel.Controls.Add(this._confermaPanel, 0, 2);
            this._mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._mainTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this._mainTableLayoutPanel.Name = "_mainTableLayoutPanel";
            this._mainTableLayoutPanel.RowCount = 3;
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.38998F));
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.79412F));
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.8159F));
            this._mainTableLayoutPanel.Size = new System.Drawing.Size(451, 229);
            this._mainTableLayoutPanel.TabIndex = 0;
            // 
            // _nomeTableLayoutPanel
            // 
            this._nomeTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this._nomeTableLayoutPanel.ColumnCount = 2;
            this._nomeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._nomeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this._nomeTableLayoutPanel.Controls.Add(this._nomeAmicoLabel, 1, 0);
            this._nomeTableLayoutPanel.Controls.Add(this._pictureBox, 0, 0);
            this._nomeTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._nomeTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._nomeTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this._nomeTableLayoutPanel.Name = "_nomeTableLayoutPanel";
            this._nomeTableLayoutPanel.RowCount = 1;
            this._nomeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._nomeTableLayoutPanel.Size = new System.Drawing.Size(451, 46);
            this._nomeTableLayoutPanel.TabIndex = 0;
            // 
            // _nomeAmicoLabel
            // 
            this._nomeAmicoLabel.AutoSize = true;
            this._nomeAmicoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._nomeAmicoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._nomeAmicoLabel.Location = new System.Drawing.Point(94, 1);
            this._nomeAmicoLabel.Name = "_nomeAmicoLabel";
            this._nomeAmicoLabel.Size = new System.Drawing.Size(353, 44);
            this._nomeAmicoLabel.TabIndex = 0;
            this._nomeAmicoLabel.Text = "Nome Amico";
            this._nomeAmicoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _pictureBox
            // 
            this._pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pictureBox.Image = global::Room8.Properties.Resources._default;
            this._pictureBox.Location = new System.Drawing.Point(1, 1);
            this._pictureBox.Margin = new System.Windows.Forms.Padding(0);
            this._pictureBox.Name = "_pictureBox";
            this._pictureBox.Size = new System.Drawing.Size(89, 44);
            this._pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._pictureBox.TabIndex = 1;
            this._pictureBox.TabStop = false;
            // 
            // _centralTableLayoutPanel
            // 
            this._centralTableLayoutPanel.ColumnCount = 2;
            this._centralTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._centralTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this._centralTableLayoutPanel.Controls.Add(this._bilancioTableLayoutPanel, 1, 0);
            this._centralTableLayoutPanel.Controls.Add(this._mainPanel, 0, 0);
            this._centralTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._centralTableLayoutPanel.Location = new System.Drawing.Point(0, 46);
            this._centralTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this._centralTableLayoutPanel.Name = "_centralTableLayoutPanel";
            this._centralTableLayoutPanel.RowCount = 1;
            this._centralTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._centralTableLayoutPanel.Size = new System.Drawing.Size(451, 136);
            this._centralTableLayoutPanel.TabIndex = 16;
            // 
            // _bilancioTableLayoutPanel
            // 
            this._bilancioTableLayoutPanel.ColumnCount = 1;
            this._bilancioTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._bilancioTableLayoutPanel.Controls.Add(this._bilancioLabel, 0, 0);
            this._bilancioTableLayoutPanel.Controls.Add(this._importoTotaleLabel, 0, 1);
            this._bilancioTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._bilancioTableLayoutPanel.Location = new System.Drawing.Point(344, 0);
            this._bilancioTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this._bilancioTableLayoutPanel.Name = "_bilancioTableLayoutPanel";
            this._bilancioTableLayoutPanel.RowCount = 2;
            this._bilancioTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this._bilancioTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this._bilancioTableLayoutPanel.Size = new System.Drawing.Size(107, 136);
            this._bilancioTableLayoutPanel.TabIndex = 0;
            // 
            // _bilancioLabel
            // 
            this._bilancioLabel.AutoSize = true;
            this._bilancioLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._bilancioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bilancioLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this._bilancioLabel.Location = new System.Drawing.Point(3, 0);
            this._bilancioLabel.Name = "_bilancioLabel";
            this._bilancioLabel.Size = new System.Drawing.Size(101, 38);
            this._bilancioLabel.TabIndex = 0;
            this._bilancioLabel.Text = "Bilancio:";
            this._bilancioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _importoTotaleLabel
            // 
            this._importoTotaleLabel.AutoSize = true;
            this._importoTotaleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this._importoTotaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._importoTotaleLabel.Location = new System.Drawing.Point(3, 38);
            this._importoTotaleLabel.Name = "_importoTotaleLabel";
            this._importoTotaleLabel.Size = new System.Drawing.Size(101, 20);
            this._importoTotaleLabel.TabIndex = 1;
            this._importoTotaleLabel.Text = "Soldi";
            this._importoTotaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _mainPanel
            // 
            this._mainPanel.AutoScroll = true;
            this._mainPanel.Controls.Add(this.listBox);
            this._mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainPanel.Location = new System.Drawing.Point(0, 0);
            this._mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this._mainPanel.Name = "_mainPanel";
            this._mainPanel.Size = new System.Drawing.Size(344, 136);
            this._mainPanel.TabIndex = 2;
            // 
            // _confermaPanel
            // 
            this._confermaPanel.Controls.Add(this._annullaButton);
            this._confermaPanel.Controls.Add(this._confermaButton);
            this._confermaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._confermaPanel.Location = new System.Drawing.Point(0, 182);
            this._confermaPanel.Margin = new System.Windows.Forms.Padding(0);
            this._confermaPanel.Name = "_confermaPanel";
            this._confermaPanel.Size = new System.Drawing.Size(451, 47);
            this._confermaPanel.TabIndex = 15;
            // 
            // _annullaButton
            // 
            this._annullaButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._annullaButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._annullaButton.Location = new System.Drawing.Point(364, 8);
            this._annullaButton.Name = "_annullaButton";
            this._annullaButton.Size = new System.Drawing.Size(75, 23);
            this._annullaButton.TabIndex = 14;
            this._annullaButton.Text = "Annulla";
            this._annullaButton.UseVisualStyleBackColor = true;
            // 
            // _confermaButton
            // 
            this._confermaButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._confermaButton.Location = new System.Drawing.Point(286, 8);
            this._confermaButton.Name = "_confermaButton";
            this._confermaButton.Size = new System.Drawing.Size(75, 23);
            this._confermaButton.TabIndex = 13;
            this._confermaButton.Text = "Conferma";
            this._confermaButton.UseVisualStyleBackColor = true;
            // 
            // listBox
            // 
            this.listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(0, 0);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(344, 136);
            this.listBox.TabIndex = 0;
            // 
            // AmicoForm
            // 
            this.AcceptButton = this._confermaButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 229);
            this.Controls.Add(this._mainTableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(467, 267);
            this.Name = "AmicoForm";
            this.Text = "Room8 - Amico";
            this._mainTableLayoutPanel.ResumeLayout(false);
            this._nomeTableLayoutPanel.ResumeLayout(false);
            this._nomeTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).EndInit();
            this._centralTableLayoutPanel.ResumeLayout(false);
            this._bilancioTableLayoutPanel.ResumeLayout(false);
            this._bilancioTableLayoutPanel.PerformLayout();
            this._mainPanel.ResumeLayout(false);
            this._confermaPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _mainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel _nomeTableLayoutPanel;
        private System.Windows.Forms.Label _nomeAmicoLabel;
        private System.Windows.Forms.PictureBox _pictureBox;
        private System.Windows.Forms.Panel _confermaPanel;
        private System.Windows.Forms.Button _annullaButton;
        private System.Windows.Forms.Button _confermaButton;
        private System.Windows.Forms.TableLayoutPanel _centralTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel _bilancioTableLayoutPanel;
        private System.Windows.Forms.Label _bilancioLabel;
        private System.Windows.Forms.Label _importoTotaleLabel;
        private System.Windows.Forms.Panel _mainPanel;
        private System.Windows.Forms.ListBox listBox;
    }
}