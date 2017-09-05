namespace Room8.View
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
            this._mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._spesaLabel = new System.Windows.Forms.Label();
            this._confirmPanel = new System.Windows.Forms.Panel();
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
            this._quoteRadioButton = new System.Windows.Forms.RadioButton();
            this._percentualiRadioButton = new System.Windows.Forms.RadioButton();
            this._equoRadioButton = new System.Windows.Forms.RadioButton();
            this._paganteComboBox = new System.Windows.Forms.ComboBox();
            this._divisioneLabel = new System.Windows.Forms.Label();
            this._dataLabel = new System.Windows.Forms.Label();
            this._noteLabel = new System.Windows.Forms.Label();
            this._dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this._noteTextBox = new System.Windows.Forms.TextBox();
            this._numericUpDown = new System.Windows.Forms.NumericUpDown();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this._mainTableLayoutPanel.SuspendLayout();
            this._confirmPanel.SuspendLayout();
            this._formTableLayoutPanel.SuspendLayout();
            this._radioPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // _mainTableLayoutPanel
            // 
            this._mainTableLayoutPanel.ColumnCount = 1;
            this._mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._mainTableLayoutPanel.Controls.Add(this._spesaLabel, 0, 0);
            this._mainTableLayoutPanel.Controls.Add(this._confirmPanel, 0, 2);
            this._mainTableLayoutPanel.Controls.Add(this._formTableLayoutPanel, 0, 1);
            this._mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._mainTableLayoutPanel.Name = "_mainTableLayoutPanel";
            this._mainTableLayoutPanel.RowCount = 3;
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.94727F));
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.05274F));
            this._mainTableLayoutPanel.Size = new System.Drawing.Size(472, 388);
            this._mainTableLayoutPanel.TabIndex = 0;
            // 
            // _spesaLabel
            // 
            this._spesaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._spesaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._spesaLabel.Location = new System.Drawing.Point(3, 0);
            this._spesaLabel.Name = "_spesaLabel";
            this._spesaLabel.Size = new System.Drawing.Size(466, 34);
            this._spesaLabel.TabIndex = 0;
            this._spesaLabel.Text = "Spesa";
            this._spesaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _confirmPanel
            // 
            this._confirmPanel.Controls.Add(this._confermaButton);
            this._confirmPanel.Controls.Add(this._annullaButton);
            this._confirmPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._confirmPanel.Location = new System.Drawing.Point(0, 338);
            this._confirmPanel.Margin = new System.Windows.Forms.Padding(0);
            this._confirmPanel.Name = "_confirmPanel";
            this._confirmPanel.Size = new System.Drawing.Size(472, 50);
            this._confirmPanel.TabIndex = 1;
            // 
            // _confermaButton
            // 
            this._confermaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._confermaButton.Location = new System.Drawing.Point(303, 15);
            this._confermaButton.Name = "_confermaButton";
            this._confermaButton.Size = new System.Drawing.Size(75, 23);
            this._confermaButton.TabIndex = 1;
            this._confermaButton.Text = "Conferma";
            this._confermaButton.UseVisualStyleBackColor = true;
            // 
            // _annullaButton
            // 
            this._annullaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._annullaButton.Location = new System.Drawing.Point(384, 15);
            this._annullaButton.Name = "_annullaButton";
            this._annullaButton.Size = new System.Drawing.Size(75, 23);
            this._annullaButton.TabIndex = 0;
            this._annullaButton.Text = "Annulla";
            this._annullaButton.UseVisualStyleBackColor = true;
            // 
            // _formTableLayoutPanel
            // 
            this._formTableLayoutPanel.ColumnCount = 2;
            this._formTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.59406F));
            this._formTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.40594F));
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
            this._formTableLayoutPanel.Controls.Add(this._noteLabel, 0, 6);
            this._formTableLayoutPanel.Controls.Add(this._dateTimePicker, 1, 5);
            this._formTableLayoutPanel.Controls.Add(this._noteTextBox, 1, 6);
            this._formTableLayoutPanel.Controls.Add(this._numericUpDown, 1, 2);
            this._formTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._formTableLayoutPanel.Location = new System.Drawing.Point(3, 37);
            this._formTableLayoutPanel.Name = "_formTableLayoutPanel";
            this._formTableLayoutPanel.RowCount = 7;
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._formTableLayoutPanel.Size = new System.Drawing.Size(466, 298);
            this._formTableLayoutPanel.TabIndex = 2;
            // 
            // _gruppoLabel
            // 
            this._gruppoLabel.AutoSize = true;
            this._gruppoLabel.Location = new System.Drawing.Point(3, 0);
            this._gruppoLabel.Name = "_gruppoLabel";
            this._gruppoLabel.Size = new System.Drawing.Size(42, 13);
            this._gruppoLabel.TabIndex = 0;
            this._gruppoLabel.Text = "Gruppo";
            // 
            // _descrizioneLabel
            // 
            this._descrizioneLabel.AutoSize = true;
            this._descrizioneLabel.Location = new System.Drawing.Point(3, 27);
            this._descrizioneLabel.Name = "_descrizioneLabel";
            this._descrizioneLabel.Size = new System.Drawing.Size(62, 13);
            this._descrizioneLabel.TabIndex = 1;
            this._descrizioneLabel.Text = "Descrizione";
            // 
            // _importoLabel
            // 
            this._importoLabel.AutoSize = true;
            this._importoLabel.Location = new System.Drawing.Point(3, 53);
            this._importoLabel.Name = "_importoLabel";
            this._importoLabel.Size = new System.Drawing.Size(42, 13);
            this._importoLabel.TabIndex = 2;
            this._importoLabel.Text = "Importo";
            // 
            // _paganteLabel
            // 
            this._paganteLabel.AutoSize = true;
            this._paganteLabel.Location = new System.Drawing.Point(3, 79);
            this._paganteLabel.Name = "_paganteLabel";
            this._paganteLabel.Size = new System.Drawing.Size(47, 13);
            this._paganteLabel.TabIndex = 3;
            this._paganteLabel.Text = "Pagante";
            // 
            // _gruppoComboBox
            // 
            this._gruppoComboBox.FormattingEnabled = true;
            this._gruppoComboBox.Location = new System.Drawing.Point(145, 3);
            this._gruppoComboBox.Name = "_gruppoComboBox";
            this._gruppoComboBox.Size = new System.Drawing.Size(200, 21);
            this._gruppoComboBox.TabIndex = 4;
            // 
            // _descrizioneTextBox
            // 
            this._descrizioneTextBox.Location = new System.Drawing.Point(145, 30);
            this._descrizioneTextBox.Name = "_descrizioneTextBox";
            this._descrizioneTextBox.Size = new System.Drawing.Size(200, 20);
            this._descrizioneTextBox.TabIndex = 6;
            // 
            // _radioPanel
            // 
            this._radioPanel.Controls.Add(this._quoteRadioButton);
            this._radioPanel.Controls.Add(this._percentualiRadioButton);
            this._radioPanel.Controls.Add(this._equoRadioButton);
            this._radioPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._radioPanel.Location = new System.Drawing.Point(142, 106);
            this._radioPanel.Margin = new System.Windows.Forms.Padding(0);
            this._radioPanel.Name = "_radioPanel";
            this._radioPanel.Size = new System.Drawing.Size(324, 100);
            this._radioPanel.TabIndex = 8;
            // 
            // _quoteRadioButton
            // 
            this._quoteRadioButton.AutoSize = true;
            this._quoteRadioButton.Location = new System.Drawing.Point(147, 8);
            this._quoteRadioButton.Name = "_quoteRadioButton";
            this._quoteRadioButton.Size = new System.Drawing.Size(71, 17);
            this._quoteRadioButton.TabIndex = 2;
            this._quoteRadioButton.Tag = "Per quote";
            this._quoteRadioButton.Text = "Per quote";
            this._quoteRadioButton.UseVisualStyleBackColor = true;
            // 
            // _percentualiRadioButton
            // 
            this._percentualiRadioButton.AutoSize = true;
            this._percentualiRadioButton.Location = new System.Drawing.Point(59, 8);
            this._percentualiRadioButton.Name = "_percentualiRadioButton";
            this._percentualiRadioButton.Size = new System.Drawing.Size(82, 17);
            this._percentualiRadioButton.TabIndex = 1;
            this._percentualiRadioButton.Tag = "Percentuale";
            this._percentualiRadioButton.Text = "Percentuale";
            this._percentualiRadioButton.UseVisualStyleBackColor = true;
            // 
            // _equoRadioButton
            // 
            this._equoRadioButton.AutoSize = true;
            this._equoRadioButton.Checked = true;
            this._equoRadioButton.Location = new System.Drawing.Point(3, 8);
            this._equoRadioButton.Name = "_equoRadioButton";
            this._equoRadioButton.Size = new System.Drawing.Size(50, 17);
            this._equoRadioButton.TabIndex = 0;
            this._equoRadioButton.TabStop = true;
            this._equoRadioButton.Tag = "Equa";
            this._equoRadioButton.Text = "Equo";
            this._equoRadioButton.UseVisualStyleBackColor = true;
            // 
            // _paganteComboBox
            // 
            this._paganteComboBox.FormattingEnabled = true;
            this._paganteComboBox.Location = new System.Drawing.Point(145, 82);
            this._paganteComboBox.Name = "_paganteComboBox";
            this._paganteComboBox.Size = new System.Drawing.Size(200, 21);
            this._paganteComboBox.TabIndex = 9;
            // 
            // _divisioneLabel
            // 
            this._divisioneLabel.AutoSize = true;
            this._divisioneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._divisioneLabel.Location = new System.Drawing.Point(3, 106);
            this._divisioneLabel.Name = "_divisioneLabel";
            this._divisioneLabel.Size = new System.Drawing.Size(98, 13);
            this._divisioneLabel.TabIndex = 10;
            this._divisioneLabel.Text = "Metodo di divisione";
            // 
            // _dataLabel
            // 
            this._dataLabel.AutoSize = true;
            this._dataLabel.Location = new System.Drawing.Point(3, 206);
            this._dataLabel.Name = "_dataLabel";
            this._dataLabel.Size = new System.Drawing.Size(30, 13);
            this._dataLabel.TabIndex = 11;
            this._dataLabel.Text = "Data";
            // 
            // _noteLabel
            // 
            this._noteLabel.AutoSize = true;
            this._noteLabel.Location = new System.Drawing.Point(3, 232);
            this._noteLabel.Name = "_noteLabel";
            this._noteLabel.Size = new System.Drawing.Size(30, 13);
            this._noteLabel.TabIndex = 12;
            this._noteLabel.Text = "Note";
            // 
            // _dateTimePicker
            // 
            this._dateTimePicker.Location = new System.Drawing.Point(145, 209);
            this._dateTimePicker.Name = "_dateTimePicker";
            this._dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this._dateTimePicker.TabIndex = 13;
            // 
            // _noteTextBox
            // 
            this._noteTextBox.Location = new System.Drawing.Point(145, 235);
            this._noteTextBox.Multiline = true;
            this._noteTextBox.Name = "_noteTextBox";
            this._noteTextBox.Size = new System.Drawing.Size(200, 57);
            this._noteTextBox.TabIndex = 14;
            // 
            // _numericUpDown
            // 
            this._numericUpDown.DecimalPlaces = 2;
            this._numericUpDown.Location = new System.Drawing.Point(145, 56);
            this._numericUpDown.Name = "_numericUpDown";
            this._numericUpDown.Size = new System.Drawing.Size(200, 20);
            this._numericUpDown.TabIndex = 15;
            // 
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
            // 
            // SpesaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 388);
            this.Controls.Add(this._mainTableLayoutPanel);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _mainTableLayoutPanel;
        private System.Windows.Forms.Label _spesaLabel;
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
        private System.Windows.Forms.Label _noteLabel;
        private System.Windows.Forms.DateTimePicker _dateTimePicker;
        private System.Windows.Forms.TextBox _noteTextBox;
        private System.Windows.Forms.NumericUpDown _numericUpDown;
        private System.Windows.Forms.RadioButton _quoteRadioButton;
        private System.Windows.Forms.RadioButton _percentualiRadioButton;
        private System.Windows.Forms.ErrorProvider _errorProvider;
    }
}