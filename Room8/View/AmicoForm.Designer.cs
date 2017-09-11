using System.Globalization;

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
            this.components = new System.ComponentModel.Container();
            this._mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._nomeTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._nomeAmicoLabel = new System.Windows.Forms.Label();
            this._pictureBox = new System.Windows.Forms.PictureBox();
            this._centralTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._bilancioTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._bilancioLabel = new System.Windows.Forms.Label();
            this._importoLabel = new System.Windows.Forms.Label();
            this._modificaButton = new System.Windows.Forms.Button();
            this._dataGridView = new System.Windows.Forms.DataGridView();
            this.nomeSorgenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDestinazioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movimentoDiDenaroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._mainTableLayoutPanel.SuspendLayout();
            this._nomeTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).BeginInit();
            this._centralTableLayoutPanel.SuspendLayout();
            this._bilancioTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimentoDiDenaroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _mainTableLayoutPanel
            // 
            this._mainTableLayoutPanel.ColumnCount = 1;
            this._mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._mainTableLayoutPanel.Controls.Add(this._nomeTableLayoutPanel, 0, 0);
            this._mainTableLayoutPanel.Controls.Add(this._centralTableLayoutPanel, 0, 1);
            this._mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._mainTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this._mainTableLayoutPanel.Name = "_mainTableLayoutPanel";
            this._mainTableLayoutPanel.RowCount = 2;
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.42896F));
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.57104F));
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._mainTableLayoutPanel.Size = new System.Drawing.Size(562, 277);
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
            this._nomeTableLayoutPanel.Size = new System.Drawing.Size(562, 70);
            this._nomeTableLayoutPanel.TabIndex = 0;
            // 
            // _nomeAmicoLabel
            // 
            this._nomeAmicoLabel.AutoSize = true;
            this._nomeAmicoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._nomeAmicoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._nomeAmicoLabel.Location = new System.Drawing.Point(116, 1);
            this._nomeAmicoLabel.Name = "_nomeAmicoLabel";
            this._nomeAmicoLabel.Size = new System.Drawing.Size(442, 68);
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
            this._pictureBox.Size = new System.Drawing.Size(111, 68);
            this._pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._pictureBox.TabIndex = 1;
            this._pictureBox.TabStop = false;
            // 
            // _centralTableLayoutPanel
            // 
            this._centralTableLayoutPanel.ColumnCount = 2;
            this._centralTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._centralTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this._centralTableLayoutPanel.Controls.Add(this._bilancioTableLayoutPanel, 1, 0);
            this._centralTableLayoutPanel.Controls.Add(this._dataGridView, 0, 0);
            this._centralTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._centralTableLayoutPanel.Location = new System.Drawing.Point(0, 70);
            this._centralTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this._centralTableLayoutPanel.Name = "_centralTableLayoutPanel";
            this._centralTableLayoutPanel.RowCount = 1;
            this._centralTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._centralTableLayoutPanel.Size = new System.Drawing.Size(562, 207);
            this._centralTableLayoutPanel.TabIndex = 16;
            // 
            // _bilancioTableLayoutPanel
            // 
            this._bilancioTableLayoutPanel.ColumnCount = 1;
            this._bilancioTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._bilancioTableLayoutPanel.Controls.Add(this._bilancioLabel, 0, 0);
            this._bilancioTableLayoutPanel.Controls.Add(this._importoLabel, 0, 1);
            this._bilancioTableLayoutPanel.Controls.Add(this._modificaButton, 0, 2);
            this._bilancioTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._bilancioTableLayoutPanel.Location = new System.Drawing.Point(447, 0);
            this._bilancioTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this._bilancioTableLayoutPanel.Name = "_bilancioTableLayoutPanel";
            this._bilancioTableLayoutPanel.RowCount = 3;
            this._bilancioTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this._bilancioTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this._bilancioTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._bilancioTableLayoutPanel.Size = new System.Drawing.Size(115, 207);
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
            this._bilancioLabel.Size = new System.Drawing.Size(109, 50);
            this._bilancioLabel.TabIndex = 0;
            this._bilancioLabel.Text = "Bilancio:";
            this._bilancioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _importoLabel
            // 
            this._importoLabel.AutoSize = true;
            this._importoLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this._importoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._importoLabel.Location = new System.Drawing.Point(3, 50);
            this._importoLabel.Name = "_importoLabel";
            this._importoLabel.Size = new System.Drawing.Size(109, 20);
            this._importoLabel.TabIndex = 1;
            this._importoLabel.Text = "Soldi";
            this._importoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _modificaButton
            // 
            this._modificaButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._modificaButton.AutoSize = true;
            this._modificaButton.Location = new System.Drawing.Point(3, 180);
            this._modificaButton.Name = "_modificaButton";
            this._modificaButton.Size = new System.Drawing.Size(109, 23);
            this._modificaButton.TabIndex = 15;
            this._modificaButton.Text = "Modifica movimento";
            this._modificaButton.UseVisualStyleBackColor = true;
            // 
            // _dataGridView
            // 
            this._dataGridView.AllowUserToAddRows = false;
            this._dataGridView.AllowUserToDeleteRows = false;
            this._dataGridView.AutoGenerateColumns = false;
            this._dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeSorgenteDataGridViewTextBoxColumn,
            this.nomeDestinazioneDataGridViewTextBoxColumn,
            this.importoDataGridViewTextBoxColumn});
            this._dataGridView.DataSource = this.movimentoDiDenaroBindingSource;
            this._dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGridView.Location = new System.Drawing.Point(5, 5);
            this._dataGridView.Margin = new System.Windows.Forms.Padding(5);
            this._dataGridView.Name = "_dataGridView";
            this._dataGridView.ReadOnly = true;
            this._dataGridView.Size = new System.Drawing.Size(437, 197);
            this._dataGridView.TabIndex = 1;
            // 
            // nomeSorgenteDataGridViewTextBoxColumn
            // 
            this.nomeSorgenteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeSorgenteDataGridViewTextBoxColumn.DataPropertyName = "NomeSorgente";
            this.nomeSorgenteDataGridViewTextBoxColumn.HeaderText = "Sorgente";
            this.nomeSorgenteDataGridViewTextBoxColumn.Name = "nomeSorgenteDataGridViewTextBoxColumn";
            this.nomeSorgenteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDestinazioneDataGridViewTextBoxColumn
            // 
            this.nomeDestinazioneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDestinazioneDataGridViewTextBoxColumn.DataPropertyName = "NomeDestinazione";
            this.nomeDestinazioneDataGridViewTextBoxColumn.HeaderText = "Destinazione";
            this.nomeDestinazioneDataGridViewTextBoxColumn.Name = "nomeDestinazioneDataGridViewTextBoxColumn";
            this.nomeDestinazioneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // importoDataGridViewTextBoxColumn
            // 
            this.importoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.importoDataGridViewTextBoxColumn.DataPropertyName = "Importo";
            this.importoDataGridViewTextBoxColumn.HeaderText = "Importo";
            this.importoDataGridViewTextBoxColumn.Name = "importoDataGridViewTextBoxColumn";
            this.importoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // movimentoDiDenaroBindingSource
            // 
            this.movimentoDiDenaroBindingSource.DataSource = typeof(Room8.MovimentoDiDenaro);
            // 
            // AmicoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 277);
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
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimentoDiDenaroBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _mainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel _nomeTableLayoutPanel;
        private System.Windows.Forms.Label _nomeAmicoLabel;
        private System.Windows.Forms.PictureBox _pictureBox;
        private System.Windows.Forms.BindingSource movimentoDiDenaroBindingSource;
        private System.Windows.Forms.TableLayoutPanel _centralTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel _bilancioTableLayoutPanel;
        private System.Windows.Forms.Label _bilancioLabel;
        private System.Windows.Forms.Label _importoLabel;
        private System.Windows.Forms.Button _modificaButton;
        private System.Windows.Forms.DataGridView _dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeSorgenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDestinazioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importoDataGridViewTextBoxColumn;
    }
}