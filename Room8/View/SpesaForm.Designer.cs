﻿namespace Room8.View
{
    partial class SpesaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpesaForm));
            this._mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._confirmPanel = new System.Windows.Forms.Panel();
            this._eliminaButton = new System.Windows.Forms.Button();
            this._commentoButton = new System.Windows.Forms.Button();
            this._confermaButton = new System.Windows.Forms.Button();
            this._annullaButton = new System.Windows.Forms.Button();
            this._formTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._gruppoLabel = new System.Windows.Forms.Label();
            this._descrizioneLabel = new System.Windows.Forms.Label();
            this._importoLabel = new System.Windows.Forms.Label();
            this._paganteLabel = new System.Windows.Forms.Label();
            this._gruppoComboBox = new System.Windows.Forms.ComboBox();
            this._descrizioneTextBox = new System.Windows.Forms.TextBox();
            this._radioPanel = new System.Windows.Forms.Panel();
            this._importiPrecisiRadioButton = new System.Windows.Forms.RadioButton();
            this._quoteRadioButton = new System.Windows.Forms.RadioButton();
            this._percentualeRadioButton = new System.Windows.Forms.RadioButton();
            this._equoRadioButton = new System.Windows.Forms.RadioButton();
            this._paganteComboBox = new System.Windows.Forms.ComboBox();
            this._divisioneLabel = new System.Windows.Forms.Label();
            this._dataLabel = new System.Windows.Forms.Label();
            this._dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this._numericUpDown = new System.Windows.Forms.NumericUpDown();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._spesaLabel = new System.Windows.Forms.Label();
            this._mainTableLayoutPanel.SuspendLayout();
            this._confirmPanel.SuspendLayout();
            this._formTableLayoutPanel.SuspendLayout();
            this._radioPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _mainTableLayoutPanel
            // 
            this._mainTableLayoutPanel.ColumnCount = 1;
            this._mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._mainTableLayoutPanel.Controls.Add(this._confirmPanel, 0, 2);
            this._mainTableLayoutPanel.Controls.Add(this._formTableLayoutPanel, 0, 1);
            this._mainTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this._mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._mainTableLayoutPanel.Name = "_mainTableLayoutPanel";
            this._mainTableLayoutPanel.RowCount = 3;
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._mainTableLayoutPanel.Size = new System.Drawing.Size(398, 388);
            this._mainTableLayoutPanel.TabIndex = 0;
            // 
            // _confirmPanel
            // 
            this._confirmPanel.Controls.Add(this._eliminaButton);
            this._confirmPanel.Controls.Add(this._commentoButton);
            this._confirmPanel.Controls.Add(this._confermaButton);
            this._confirmPanel.Controls.Add(this._annullaButton);
            this._confirmPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._confirmPanel.Location = new System.Drawing.Point(0, 338);
            this._confirmPanel.Margin = new System.Windows.Forms.Padding(0);
            this._confirmPanel.Name = "_confirmPanel";
            this._confirmPanel.Size = new System.Drawing.Size(398, 50);
            this._confirmPanel.TabIndex = 1;
            // 
            // _eliminaButton
            // 
            this._eliminaButton.Location = new System.Drawing.Point(93, 15);
            this._eliminaButton.Name = "_eliminaButton";
            this._eliminaButton.Size = new System.Drawing.Size(75, 23);
            this._eliminaButton.TabIndex = 5;
            this._eliminaButton.Text = "Elimina";
            this._eliminaButton.UseVisualStyleBackColor = true;
            // 
            // _commentoButton
            // 
            this._commentoButton.Location = new System.Drawing.Point(12, 15);
            this._commentoButton.Name = "_commentoButton";
            this._commentoButton.Size = new System.Drawing.Size(75, 23);
            this._commentoButton.TabIndex = 6;
            this._commentoButton.Text = "Commenta";
            this._commentoButton.UseVisualStyleBackColor = true;
            // 
            // _confermaButton
            // 
            this._confermaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._errorProvider.SetIconAlignment(this._confermaButton, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this._confermaButton.Location = new System.Drawing.Point(229, 15);
            this._confermaButton.Name = "_confermaButton";
            this._confermaButton.Size = new System.Drawing.Size(75, 23);
            this._confermaButton.TabIndex = 7;
            this._confermaButton.Text = "Conferma";
            this._confermaButton.UseVisualStyleBackColor = true;
            // 
            // _annullaButton
            // 
            this._annullaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._annullaButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._annullaButton.Location = new System.Drawing.Point(310, 15);
            this._annullaButton.Name = "_annullaButton";
            this._annullaButton.Size = new System.Drawing.Size(75, 23);
            this._annullaButton.TabIndex = 8;
            this._annullaButton.Text = "Annulla";
            this._annullaButton.UseVisualStyleBackColor = true;
            // 
            // _formTableLayoutPanel
            // 
            this._formTableLayoutPanel.ColumnCount = 2;
            this._formTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this._formTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._formTableLayoutPanel.Controls.Add(this._gruppoLabel, 0, 0);
            this._formTableLayoutPanel.Controls.Add(this._descrizioneLabel, 0, 1);
            this._formTableLayoutPanel.Controls.Add(this._importoLabel, 0, 2);
            this._formTableLayoutPanel.Controls.Add(this._paganteLabel, 0, 3);
            this._formTableLayoutPanel.Controls.Add(this._gruppoComboBox, 1, 0);
            this._formTableLayoutPanel.Controls.Add(this._descrizioneTextBox, 1, 1);
            this._formTableLayoutPanel.Controls.Add(this._radioPanel, 1, 4);
            this._formTableLayoutPanel.Controls.Add(this._paganteComboBox, 1, 3);
            this._formTableLayoutPanel.Controls.Add(this._divisioneLabel, 0, 4);
            this._formTableLayoutPanel.Controls.Add(this._dataLabel, 0, 5);
            this._formTableLayoutPanel.Controls.Add(this._dateTimePicker, 1, 5);
            this._formTableLayoutPanel.Controls.Add(this._numericUpDown, 1, 2);
            this._formTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._formTableLayoutPanel.Location = new System.Drawing.Point(3, 43);
            this._formTableLayoutPanel.Name = "_formTableLayoutPanel";
            this._formTableLayoutPanel.RowCount = 6;
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._formTableLayoutPanel.Size = new System.Drawing.Size(392, 292);
            this._formTableLayoutPanel.TabIndex = 2;
            // 
            // _gruppoLabel
            // 
            this._gruppoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gruppoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._gruppoLabel.Location = new System.Drawing.Point(3, 0);
            this._gruppoLabel.Name = "_gruppoLabel";
            this._gruppoLabel.Size = new System.Drawing.Size(144, 48);
            this._gruppoLabel.TabIndex = 0;
            this._gruppoLabel.Text = "Gruppo:";
            this._gruppoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _descrizioneLabel
            // 
            this._descrizioneLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._descrizioneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._descrizioneLabel.Location = new System.Drawing.Point(3, 48);
            this._descrizioneLabel.Name = "_descrizioneLabel";
            this._descrizioneLabel.Size = new System.Drawing.Size(144, 48);
            this._descrizioneLabel.TabIndex = 1;
            this._descrizioneLabel.Text = "Descrizione:";
            this._descrizioneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _importoLabel
            // 
            this._importoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._importoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._importoLabel.Location = new System.Drawing.Point(3, 96);
            this._importoLabel.Name = "_importoLabel";
            this._importoLabel.Size = new System.Drawing.Size(144, 48);
            this._importoLabel.TabIndex = 2;
            this._importoLabel.Text = "Importo:";
            this._importoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _paganteLabel
            // 
            this._paganteLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._paganteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._paganteLabel.Location = new System.Drawing.Point(3, 144);
            this._paganteLabel.Name = "_paganteLabel";
            this._paganteLabel.Size = new System.Drawing.Size(144, 48);
            this._paganteLabel.TabIndex = 3;
            this._paganteLabel.Text = "Pagante:";
            this._paganteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _gruppoComboBox
            // 
            this._gruppoComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._gruppoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._gruppoComboBox.FormattingEnabled = true;
            this._gruppoComboBox.Location = new System.Drawing.Point(153, 13);
            this._gruppoComboBox.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this._gruppoComboBox.Name = "_gruppoComboBox";
            this._gruppoComboBox.Size = new System.Drawing.Size(219, 21);
            this._gruppoComboBox.TabIndex = 0;
            // 
            // _descrizioneTextBox
            // 
            this._descrizioneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._descrizioneTextBox.Location = new System.Drawing.Point(153, 62);
            this._descrizioneTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this._descrizioneTextBox.Name = "_descrizioneTextBox";
            this._descrizioneTextBox.Size = new System.Drawing.Size(219, 20);
            this._descrizioneTextBox.TabIndex = 1;
            // 
            // _radioPanel
            // 
            this._radioPanel.Controls.Add(this._importiPrecisiRadioButton);
            this._radioPanel.Controls.Add(this._quoteRadioButton);
            this._radioPanel.Controls.Add(this._percentualeRadioButton);
            this._radioPanel.Controls.Add(this._equoRadioButton);
            this._radioPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._radioPanel.Location = new System.Drawing.Point(150, 192);
            this._radioPanel.Margin = new System.Windows.Forms.Padding(0);
            this._radioPanel.Name = "_radioPanel";
            this._radioPanel.Size = new System.Drawing.Size(242, 48);
            this._radioPanel.TabIndex = 4;
            // 
            // _importiPrecisiRadioButton
            // 
            this._importiPrecisiRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._importiPrecisiRadioButton.AutoSize = true;
            this._importiPrecisiRadioButton.Location = new System.Drawing.Point(105, 22);
            this._importiPrecisiRadioButton.Name = "_importiPrecisiRadioButton";
            this._importiPrecisiRadioButton.Size = new System.Drawing.Size(89, 17);
            this._importiPrecisiRadioButton.TabIndex = 3;
            this._importiPrecisiRadioButton.TabStop = true;
            this._importiPrecisiRadioButton.Tag = "per importi precisi";
            this._importiPrecisiRadioButton.Text = "Importi precisi";
            this._importiPrecisiRadioButton.UseVisualStyleBackColor = true;
            // 
            // _quoteRadioButton
            // 
            this._quoteRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._quoteRadioButton.AutoSize = true;
            this._quoteRadioButton.Location = new System.Drawing.Point(17, 22);
            this._quoteRadioButton.Name = "_quoteRadioButton";
            this._quoteRadioButton.Size = new System.Drawing.Size(71, 17);
            this._quoteRadioButton.TabIndex = 2;
            this._quoteRadioButton.Tag = "per quote";
            this._quoteRadioButton.Text = "Per quote";
            this._quoteRadioButton.UseVisualStyleBackColor = true;
            // 
            // _percentualeRadioButton
            // 
            this._percentualeRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._percentualeRadioButton.AutoSize = true;
            this._percentualeRadioButton.Location = new System.Drawing.Point(105, 6);
            this._percentualeRadioButton.Name = "_percentualeRadioButton";
            this._percentualeRadioButton.Size = new System.Drawing.Size(82, 17);
            this._percentualeRadioButton.TabIndex = 1;
            this._percentualeRadioButton.Tag = "percentuale";
            this._percentualeRadioButton.Text = "Percentuale";
            this._percentualeRadioButton.UseVisualStyleBackColor = true;
            // 
            // _equoRadioButton
            // 
            this._equoRadioButton.AutoSize = true;
            this._equoRadioButton.Checked = true;
            this._equoRadioButton.Location = new System.Drawing.Point(17, 6);
            this._equoRadioButton.Name = "_equoRadioButton";
            this._equoRadioButton.Size = new System.Drawing.Size(50, 17);
            this._equoRadioButton.TabIndex = 0;
            this._equoRadioButton.TabStop = true;
            this._equoRadioButton.Tag = "equa";
            this._equoRadioButton.Text = "Equo";
            this._equoRadioButton.UseVisualStyleBackColor = true;
            // 
            // _paganteComboBox
            // 
            this._paganteComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._paganteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._paganteComboBox.FormattingEnabled = true;
            this._paganteComboBox.Location = new System.Drawing.Point(153, 157);
            this._paganteComboBox.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this._paganteComboBox.Name = "_paganteComboBox";
            this._paganteComboBox.Size = new System.Drawing.Size(219, 21);
            this._paganteComboBox.TabIndex = 3;
            // 
            // _divisioneLabel
            // 
            this._divisioneLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._divisioneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._divisioneLabel.Location = new System.Drawing.Point(3, 192);
            this._divisioneLabel.Name = "_divisioneLabel";
            this._divisioneLabel.Size = new System.Drawing.Size(144, 48);
            this._divisioneLabel.TabIndex = 10;
            this._divisioneLabel.Text = "Metodo di divisione:";
            this._divisioneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _dataLabel
            // 
            this._dataLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dataLabel.Location = new System.Drawing.Point(3, 240);
            this._dataLabel.Name = "_dataLabel";
            this._dataLabel.Size = new System.Drawing.Size(144, 52);
            this._dataLabel.TabIndex = 11;
            this._dataLabel.Text = "Data:";
            this._dataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _dateTimePicker
            // 
            this._dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._dateTimePicker.Location = new System.Drawing.Point(153, 256);
            this._dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this._dateTimePicker.Name = "_dateTimePicker";
            this._dateTimePicker.Size = new System.Drawing.Size(219, 20);
            this._dateTimePicker.TabIndex = 5;
            // 
            // _numericUpDown
            // 
            this._numericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._numericUpDown.DecimalPlaces = 2;
            this._numericUpDown.Location = new System.Drawing.Point(153, 110);
            this._numericUpDown.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this._numericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this._numericUpDown.Name = "_numericUpDown";
            this._numericUpDown.Size = new System.Drawing.Size(219, 20);
            this._numericUpDown.TabIndex = 2;
            this._numericUpDown.ThousandsSeparator = true;
            // 
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.45918F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.54082F));
            this.tableLayoutPanel1.Controls.Add(this._spesaLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(392, 34);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // _spesaLabel
            // 
            this._spesaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._spesaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._spesaLabel.Location = new System.Drawing.Point(44, 0);
            this._spesaLabel.Name = "_spesaLabel";
            this._spesaLabel.Size = new System.Drawing.Size(345, 34);
            this._spesaLabel.TabIndex = 1;
            this._spesaLabel.Text = "Spesa";
            this._spesaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpesaForm
            // 
            this.AcceptButton = this._confermaButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 388);
            this.Controls.Add(this._mainTableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(414, 426);
            this.Name = "SpesaForm";
            this.Text = "Room8 - Spesa";
            this._mainTableLayoutPanel.ResumeLayout(false);
            this._confirmPanel.ResumeLayout(false);
            this._formTableLayoutPanel.ResumeLayout(false);
            this._formTableLayoutPanel.PerformLayout();
            this._radioPanel.ResumeLayout(false);
            this._radioPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _mainTableLayoutPanel;
        private System.Windows.Forms.Panel _confirmPanel;
        private System.Windows.Forms.Button _confermaButton;
        private System.Windows.Forms.Button _annullaButton;
        private System.Windows.Forms.TableLayoutPanel _formTableLayoutPanel;
        private System.Windows.Forms.Label _gruppoLabel;
        private System.Windows.Forms.Label _descrizioneLabel;
        private System.Windows.Forms.Label _importoLabel;
        private System.Windows.Forms.Label _paganteLabel;
        private System.Windows.Forms.ComboBox _gruppoComboBox;
        private System.Windows.Forms.TextBox _descrizioneTextBox;
        private System.Windows.Forms.Panel _radioPanel;
        private System.Windows.Forms.RadioButton _equoRadioButton;
        private System.Windows.Forms.ComboBox _paganteComboBox;
        private System.Windows.Forms.Label _divisioneLabel;
        private System.Windows.Forms.Label _dataLabel;
        private System.Windows.Forms.DateTimePicker _dateTimePicker;
        private System.Windows.Forms.NumericUpDown _numericUpDown;
        private System.Windows.Forms.RadioButton _quoteRadioButton;
        private System.Windows.Forms.RadioButton _percentualeRadioButton;
        private System.Windows.Forms.ErrorProvider _errorProvider;
        private System.Windows.Forms.Button _commentoButton;
        private System.Windows.Forms.RadioButton _importiPrecisiRadioButton;
        private System.Windows.Forms.Button _eliminaButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label _spesaLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}