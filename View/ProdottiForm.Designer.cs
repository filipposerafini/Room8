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
            this._prodottoLabel = new System.Windows.Forms.Label();
            this._prodottoTextBox = new System.Windows.Forms.TextBox();
            this._rimuoviButton = new System.Windows.Forms.Button();
            this._mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._quantitaPanel = new System.Windows.Forms.Panel();
            this._numericUpDown = new System.Windows.Forms.NumericUpDown();
            this._quantitaLabel = new System.Windows.Forms.Label();
            this._prodottiLabel = new System.Windows.Forms.Label();
            this._contorlPanel = new System.Windows.Forms.Panel();
            this._aggiungiButton = new System.Windows.Forms.Button();
            this._dataGridView = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodottoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this._prodottiPanel.SuspendLayout();
            this._mainTableLayoutPanel.SuspendLayout();
            this._quantitaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDown)).BeginInit();
            this._contorlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodottoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // _prodottiPanel
            // 
            this._prodottiPanel.Controls.Add(this._prodottoLabel);
            this._prodottiPanel.Controls.Add(this._prodottoTextBox);
            this._prodottiPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._prodottiPanel.Location = new System.Drawing.Point(0, 160);
            this._prodottiPanel.Margin = new System.Windows.Forms.Padding(0);
            this._prodottiPanel.Name = "_prodottiPanel";
            this._prodottiPanel.Size = new System.Drawing.Size(311, 40);
            this._prodottiPanel.TabIndex = 1;
            // 
            // _prodottoLabel
            // 
            this._prodottoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._prodottoLabel.AutoSize = true;
            this._prodottoLabel.Location = new System.Drawing.Point(12, 12);
            this._prodottoLabel.Name = "_prodottoLabel";
            this._prodottoLabel.Size = new System.Drawing.Size(50, 13);
            this._prodottoLabel.TabIndex = 3;
            this._prodottoLabel.Text = "Prodotto:";
            // 
            // _prodottoTextBox
            // 
            this._prodottoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._prodottoTextBox.Location = new System.Drawing.Point(68, 9);
            this._prodottoTextBox.Name = "_prodottoTextBox";
            this._prodottoTextBox.Size = new System.Drawing.Size(222, 20);
            this._prodottoTextBox.TabIndex = 2;
            // 
            // _rimuoviButton
            // 
            this._rimuoviButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._rimuoviButton.AutoSize = true;
            this._rimuoviButton.Location = new System.Drawing.Point(9, 2);
            this._rimuoviButton.Name = "_rimuoviButton";
            this._rimuoviButton.Size = new System.Drawing.Size(107, 23);
            this._rimuoviButton.TabIndex = 4;
            this._rimuoviButton.Text = "Rimuovi selezionati";
            this._rimuoviButton.UseVisualStyleBackColor = true;
            // 
            // _mainTableLayoutPanel
            // 
            this._mainTableLayoutPanel.ColumnCount = 1;
            this._mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._mainTableLayoutPanel.Controls.Add(this._quantitaPanel, 0, 3);
            this._mainTableLayoutPanel.Controls.Add(this._prodottiLabel, 0, 0);
            this._mainTableLayoutPanel.Controls.Add(this._prodottiPanel, 0, 2);
            this._mainTableLayoutPanel.Controls.Add(this._contorlPanel, 0, 4);
            this._mainTableLayoutPanel.Controls.Add(this._dataGridView, 0, 1);
            this._mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._mainTableLayoutPanel.Name = "_mainTableLayoutPanel";
            this._mainTableLayoutPanel.RowCount = 5;
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._mainTableLayoutPanel.Size = new System.Drawing.Size(311, 280);
            this._mainTableLayoutPanel.TabIndex = 4;
            // 
            // _quantitaPanel
            // 
            this._quantitaPanel.Controls.Add(this._numericUpDown);
            this._quantitaPanel.Controls.Add(this._quantitaLabel);
            this._quantitaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._quantitaPanel.Location = new System.Drawing.Point(0, 200);
            this._quantitaPanel.Margin = new System.Windows.Forms.Padding(0);
            this._quantitaPanel.Name = "_quantitaPanel";
            this._quantitaPanel.Size = new System.Drawing.Size(311, 40);
            this._quantitaPanel.TabIndex = 5;
            // 
            // _numericUpDown
            // 
            this._numericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._numericUpDown.Location = new System.Drawing.Point(68, 12);
            this._numericUpDown.Name = "_numericUpDown";
            this._numericUpDown.Size = new System.Drawing.Size(222, 20);
            this._numericUpDown.TabIndex = 4;
            // 
            // _quantitaLabel
            // 
            this._quantitaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._quantitaLabel.AutoSize = true;
            this._quantitaLabel.Location = new System.Drawing.Point(12, 14);
            this._quantitaLabel.Name = "_quantitaLabel";
            this._quantitaLabel.Size = new System.Drawing.Size(50, 13);
            this._quantitaLabel.TabIndex = 3;
            this._quantitaLabel.Text = "Quantità:";
            // 
            // _prodottiLabel
            // 
            this._prodottiLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._prodottiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._prodottiLabel.Location = new System.Drawing.Point(3, 0);
            this._prodottiLabel.Name = "_prodottiLabel";
            this._prodottiLabel.Size = new System.Drawing.Size(305, 40);
            this._prodottiLabel.TabIndex = 0;
            this._prodottiLabel.Text = "Prodotti";
            this._prodottiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _contorlPanel
            // 
            this._contorlPanel.Controls.Add(this._rimuoviButton);
            this._contorlPanel.Controls.Add(this._aggiungiButton);
            this._contorlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._contorlPanel.Location = new System.Drawing.Point(3, 243);
            this._contorlPanel.Name = "_contorlPanel";
            this._contorlPanel.Size = new System.Drawing.Size(305, 34);
            this._contorlPanel.TabIndex = 6;
            // 
            // _aggiungiButton
            // 
            this._aggiungiButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._aggiungiButton.Location = new System.Drawing.Point(221, 2);
            this._aggiungiButton.Name = "_aggiungiButton";
            this._aggiungiButton.Size = new System.Drawing.Size(75, 23);
            this._aggiungiButton.TabIndex = 1;
            this._aggiungiButton.Text = "Aggiungi";
            this._aggiungiButton.UseVisualStyleBackColor = true;
            // 
            // _dataGridView
            // 
            this._dataGridView.AutoGenerateColumns = false;
            this._dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.quantitaDataGridViewTextBoxColumn});
            this._dataGridView.DataSource = this.prodottoBindingSource;
            this._dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGridView.Location = new System.Drawing.Point(3, 43);
            this._dataGridView.Name = "_dataGridView";
			this._dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this._dataGridView.MultiSelect = true;
            this._dataGridView.Size = new System.Drawing.Size(305, 114);
            this._dataGridView.TabIndex = 7;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantitaDataGridViewTextBoxColumn
            // 
            this.quantitaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantitaDataGridViewTextBoxColumn.DataPropertyName = "Quantita";
            this.quantitaDataGridViewTextBoxColumn.HeaderText = "Quantità";
            this.quantitaDataGridViewTextBoxColumn.Name = "quantitaDataGridViewTextBoxColumn";
            // 
            // prodottoBindingSource
            // 
            this.prodottoBindingSource.DataSource = typeof(Room8.Prodotto);
            // 
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
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
            this._quantitaPanel.ResumeLayout(false);
            this._quantitaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDown)).EndInit();
            this._contorlPanel.ResumeLayout(false);
            this._contorlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodottoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _prodottiPanel;
        private System.Windows.Forms.TableLayoutPanel _mainTableLayoutPanel;
        private System.Windows.Forms.Label _prodottiLabel;
        private System.Windows.Forms.ErrorProvider _errorProvider;
        private System.Windows.Forms.Button _rimuoviButton;
        private System.Windows.Forms.Label _prodottoLabel;
        private System.Windows.Forms.TextBox _prodottoTextBox;
        private System.Windows.Forms.Panel _quantitaPanel;
        private System.Windows.Forms.NumericUpDown _numericUpDown;
        private System.Windows.Forms.Label _quantitaLabel;
        private System.Windows.Forms.Panel _contorlPanel;
        private System.Windows.Forms.Button _aggiungiButton;
        private System.Windows.Forms.DataGridView _dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource prodottoBindingSource;
    }
}