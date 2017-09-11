using System.Globalization;

namespace Room8.View
{
    partial class BilancioGruppoForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this._pictureBox = new System.Windows.Forms.PictureBox();
            this._modificaButton = new System.Windows.Forms.Button();
            this._registratiLabel = new System.Windows.Forms.Label();
            this._mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._bottomPanel = new System.Windows.Forms.Panel();
            this._prodottiButton = new System.Windows.Forms.Button();
            this._titleTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._centerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._speseTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._speseLabel = new System.Windows.Forms.Label();
            this._dataGridView = new System.Windows.Forms.DataGridView();
            this._descrizioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._importoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._nomePaganteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._spesaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._membriTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._bilancioLabel = new System.Windows.Forms.Label();
            this._importoLabel = new System.Windows.Forms.Label();
            this._membriListBox = new System.Windows.Forms.ListBox();
            this._membriLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).BeginInit();
            this._mainTableLayoutPanel.SuspendLayout();
            this._bottomPanel.SuspendLayout();
            this._titleTableLayoutPanel.SuspendLayout();
            this._centerTableLayoutPanel.SuspendLayout();
            this._speseTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._spesaBindingSource)).BeginInit();
            this._membriTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _pictureBox
            // 
            this._pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pictureBox.Image = global::Room8.Properties.Resources.defaultgroup;
            this._pictureBox.Location = new System.Drawing.Point(0, 0);
            this._pictureBox.Margin = new System.Windows.Forms.Padding(0);
            this._pictureBox.Name = "_pictureBox";
            this._pictureBox.Size = new System.Drawing.Size(137, 51);
            this._pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._pictureBox.TabIndex = 0;
            this._pictureBox.TabStop = false;
            // 
            // _modificaButton
            // 
            this._modificaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._modificaButton.AutoSize = true;
            this._modificaButton.Location = new System.Drawing.Point(405, 11);
            this._modificaButton.Name = "_modificaButton";
            this._modificaButton.Size = new System.Drawing.Size(90, 23);
            this._modificaButton.TabIndex = 13;
            this._modificaButton.Text = "Modifica spesa";
            this._modificaButton.UseVisualStyleBackColor = true;
            // 
            // _registratiLabel
            // 
            this._registratiLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._registratiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._registratiLabel.Location = new System.Drawing.Point(140, 0);
            this._registratiLabel.Name = "_registratiLabel";
            this._registratiLabel.Size = new System.Drawing.Size(364, 51);
            this._registratiLabel.TabIndex = 0;
            this._registratiLabel.Text = "Nome Gruppo";
            this._registratiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _mainTableLayoutPanel
            // 
            this._mainTableLayoutPanel.ColumnCount = 1;
            this._mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._mainTableLayoutPanel.Controls.Add(this._bottomPanel, 0, 2);
            this._mainTableLayoutPanel.Controls.Add(this._titleTableLayoutPanel, 0, 0);
            this._mainTableLayoutPanel.Controls.Add(this._centerTableLayoutPanel, 0, 1);
            this._mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._mainTableLayoutPanel.Name = "_mainTableLayoutPanel";
            this._mainTableLayoutPanel.RowCount = 3;
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.93272F));
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.06728F));
            this._mainTableLayoutPanel.Size = new System.Drawing.Size(507, 374);
            this._mainTableLayoutPanel.TabIndex = 3;
            // 
            // _bottomPanel
            // 
            this._bottomPanel.Controls.Add(this._prodottiButton);
            this._bottomPanel.Controls.Add(this._modificaButton);
            this._bottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._bottomPanel.Location = new System.Drawing.Point(0, 328);
            this._bottomPanel.Margin = new System.Windows.Forms.Padding(0);
            this._bottomPanel.Name = "_bottomPanel";
            this._bottomPanel.Size = new System.Drawing.Size(507, 46);
            this._bottomPanel.TabIndex = 14;
            // 
            // _prodottiButton
            // 
            this._prodottiButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._prodottiButton.AutoSize = true;
            this._prodottiButton.Location = new System.Drawing.Point(12, 11);
            this._prodottiButton.Name = "_prodottiButton";
            this._prodottiButton.Size = new System.Drawing.Size(95, 23);
            this._prodottiButton.TabIndex = 14;
            this._prodottiButton.Text = "Lista della spesa";
            this._prodottiButton.UseVisualStyleBackColor = true;
            // 
            // _titleTableLayoutPanel
            // 
            this._titleTableLayoutPanel.ColumnCount = 2;
            this._titleTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.0217F));
            this._titleTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.9783F));
            this._titleTableLayoutPanel.Controls.Add(this._pictureBox, 0, 0);
            this._titleTableLayoutPanel.Controls.Add(this._registratiLabel, 1, 0);
            this._titleTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._titleTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._titleTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this._titleTableLayoutPanel.Name = "_titleTableLayoutPanel";
            this._titleTableLayoutPanel.RowCount = 1;
            this._titleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._titleTableLayoutPanel.Size = new System.Drawing.Size(507, 51);
            this._titleTableLayoutPanel.TabIndex = 16;
            // 
            // _centerTableLayoutPanel
            // 
            this._centerTableLayoutPanel.ColumnCount = 2;
            this._centerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.23577F));
            this._centerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.76423F));
            this._centerTableLayoutPanel.Controls.Add(this._speseTableLayoutPanel, 1, 0);
            this._centerTableLayoutPanel.Controls.Add(this._membriTableLayoutPanel, 0, 0);
            this._centerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._centerTableLayoutPanel.Location = new System.Drawing.Point(2, 53);
            this._centerTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this._centerTableLayoutPanel.Name = "_centerTableLayoutPanel";
            this._centerTableLayoutPanel.RowCount = 1;
            this._centerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._centerTableLayoutPanel.Size = new System.Drawing.Size(503, 273);
            this._centerTableLayoutPanel.TabIndex = 17;
            // 
            // _speseTableLayoutPanel
            // 
            this._speseTableLayoutPanel.ColumnCount = 1;
            this._speseTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._speseTableLayoutPanel.Controls.Add(this._speseLabel, 0, 0);
            this._speseTableLayoutPanel.Controls.Add(this._dataGridView, 0, 1);
            this._speseTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._speseTableLayoutPanel.Location = new System.Drawing.Point(136, 0);
            this._speseTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this._speseTableLayoutPanel.Name = "_speseTableLayoutPanel";
            this._speseTableLayoutPanel.RowCount = 2;
            this._speseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.15242F));
            this._speseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.84758F));
            this._speseTableLayoutPanel.Size = new System.Drawing.Size(367, 273);
            this._speseTableLayoutPanel.TabIndex = 1;
            // 
            // _speseLabel
            // 
            this._speseLabel.AutoSize = true;
            this._speseLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._speseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._speseLabel.Location = new System.Drawing.Point(3, 3);
            this._speseLabel.Margin = new System.Windows.Forms.Padding(3);
            this._speseLabel.Name = "_speseLabel";
            this._speseLabel.Size = new System.Drawing.Size(361, 24);
            this._speseLabel.TabIndex = 3;
            this._speseLabel.Text = "Lista spese:";
            this._speseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _dataGridView
            // 
            this._dataGridView.AllowUserToAddRows = false;
            this._dataGridView.AllowUserToDeleteRows = false;
            this._dataGridView.AutoGenerateColumns = false;
            this._dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._descrizioneDataGridViewTextBoxColumn,
            this._importoDataGridViewTextBoxColumn,
            this._nomePaganteDataGridViewTextBoxColumn,
            this._dataDataGridViewTextBoxColumn});
            this._dataGridView.DataSource = this._spesaBindingSource;
            this._dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGridView.Location = new System.Drawing.Point(5, 30);
            this._dataGridView.Margin = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this._dataGridView.Name = "_dataGridView";
            this._dataGridView.ReadOnly = true;
            this._dataGridView.Size = new System.Drawing.Size(352, 243);
            this._dataGridView.TabIndex = 4;
            // 
            // _descrizioneDataGridViewTextBoxColumn
            // 
            this._descrizioneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._descrizioneDataGridViewTextBoxColumn.DataPropertyName = "Descrizione";
            this._descrizioneDataGridViewTextBoxColumn.HeaderText = "Descrizione";
            this._descrizioneDataGridViewTextBoxColumn.Name = "_descrizioneDataGridViewTextBoxColumn";
            this._descrizioneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // _importoDataGridViewTextBoxColumn
            // 
            this._importoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._importoDataGridViewTextBoxColumn.DataPropertyName = "Importo";
            dataGridViewCellStyle1.Format = "c2";
            dataGridViewCellStyle1.FormatProvider = new System.Globalization.CultureInfo("it-IT");
            this._importoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this._importoDataGridViewTextBoxColumn.HeaderText = "Importo";
            this._importoDataGridViewTextBoxColumn.Name = "_importoDataGridViewTextBoxColumn";
            this._importoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // _nomePaganteDataGridViewTextBoxColumn
            // 
            this._nomePaganteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._nomePaganteDataGridViewTextBoxColumn.DataPropertyName = "NomePagante";
            this._nomePaganteDataGridViewTextBoxColumn.HeaderText = "Pagante";
            this._nomePaganteDataGridViewTextBoxColumn.Name = "_nomePaganteDataGridViewTextBoxColumn";
            this._nomePaganteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // _dataDataGridViewTextBoxColumn
            // 
            this._dataDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this._dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this._dataDataGridViewTextBoxColumn.Name = "_dataDataGridViewTextBoxColumn";
            this._dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // _spesaBindingSource
            // 
            this._spesaBindingSource.DataSource = typeof(Room8.Spesa);
            // 
            // _membriTableLayoutPanel
            // 
            this._membriTableLayoutPanel.ColumnCount = 1;
            this._membriTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._membriTableLayoutPanel.Controls.Add(this._bilancioLabel, 0, 0);
            this._membriTableLayoutPanel.Controls.Add(this._importoLabel, 0, 1);
            this._membriTableLayoutPanel.Controls.Add(this._membriListBox, 0, 3);
            this._membriTableLayoutPanel.Controls.Add(this._membriLabel, 0, 2);
            this._membriTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._membriTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._membriTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this._membriTableLayoutPanel.Name = "_membriTableLayoutPanel";
            this._membriTableLayoutPanel.RowCount = 4;
            this._membriTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this._membriTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this._membriTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this._membriTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._membriTableLayoutPanel.Size = new System.Drawing.Size(136, 273);
            this._membriTableLayoutPanel.TabIndex = 2;
            // 
            // _bilancioLabel
            // 
            this._bilancioLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._bilancioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bilancioLabel.Location = new System.Drawing.Point(3, 0);
            this._bilancioLabel.MinimumSize = new System.Drawing.Size(126, 23);
            this._bilancioLabel.Name = "_bilancioLabel";
            this._bilancioLabel.Size = new System.Drawing.Size(130, 30);
            this._bilancioLabel.TabIndex = 2;
            this._bilancioLabel.Text = "Bilancio totale:";
            this._bilancioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _importoLabel
            // 
            this._importoLabel.AutoSize = true;
            this._importoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._importoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._importoLabel.Location = new System.Drawing.Point(3, 30);
            this._importoLabel.Name = "_importoLabel";
            this._importoLabel.Size = new System.Drawing.Size(130, 30);
            this._importoLabel.TabIndex = 3;
            this._importoLabel.Text = "Soldi";
            this._importoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _membriListBox
            // 
            this._membriListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._membriListBox.FormattingEnabled = true;
            this._membriListBox.Location = new System.Drawing.Point(10, 85);
            this._membriListBox.Margin = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this._membriListBox.Name = "_membriListBox";
            this._membriListBox.ScrollAlwaysVisible = true;
            this._membriListBox.Size = new System.Drawing.Size(121, 188);
            this._membriListBox.TabIndex = 1;
            // 
            // _membriLabel
            // 
            this._membriLabel.AutoSize = true;
            this._membriLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._membriLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._membriLabel.Location = new System.Drawing.Point(3, 60);
            this._membriLabel.Name = "_membriLabel";
            this._membriLabel.Size = new System.Drawing.Size(130, 25);
            this._membriLabel.TabIndex = 2;
            this._membriLabel.Text = "Membri del Gruppo:";
            this._membriLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BilancioGruppoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 374);
            this.Controls.Add(this._mainTableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(523, 412);
            this.Name = "BilancioGruppoForm";
            this.Text = "Room8 - Gruppo";
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).EndInit();
            this._mainTableLayoutPanel.ResumeLayout(false);
            this._bottomPanel.ResumeLayout(false);
            this._bottomPanel.PerformLayout();
            this._titleTableLayoutPanel.ResumeLayout(false);
            this._centerTableLayoutPanel.ResumeLayout(false);
            this._speseTableLayoutPanel.ResumeLayout(false);
            this._speseTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._spesaBindingSource)).EndInit();
            this._membriTableLayoutPanel.ResumeLayout(false);
            this._membriTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox _pictureBox;
        private System.Windows.Forms.TableLayoutPanel _mainTableLayoutPanel;
        private System.Windows.Forms.Panel _bottomPanel;
        private System.Windows.Forms.Button _modificaButton;
        private System.Windows.Forms.TableLayoutPanel _titleTableLayoutPanel;
        private System.Windows.Forms.Label _registratiLabel;
        private System.Windows.Forms.TableLayoutPanel _centerTableLayoutPanel;
        private System.Windows.Forms.Label _membriLabel;
        private System.Windows.Forms.Label _speseLabel;
        private System.Windows.Forms.TableLayoutPanel _speseTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel _membriTableLayoutPanel;
        private System.Windows.Forms.Label _bilancioLabel;
        private System.Windows.Forms.Label _importoLabel;
        private System.Windows.Forms.Button _prodottiButton;
        private System.Windows.Forms.DataGridView _dataGridView;
        private System.Windows.Forms.BindingSource _spesaBindingSource;
        private System.Windows.Forms.ListBox _membriListBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _descrizioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _importoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _nomePaganteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataDataGridViewTextBoxColumn;
    }
}