namespace Room8.View
{
    partial class SaldoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaldoForm));
            this._mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._saldaLabel = new System.Windows.Forms.Label();
            this._confirmPanel = new System.Windows.Forms.Panel();
            this._eliminaButton = new System.Windows.Forms.Button();
            this._confermaButton = new System.Windows.Forms.Button();
            this._annullaButton = new System.Windows.Forms.Button();
            this._formTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this._numericUpDown = new System.Windows.Forms.NumericUpDown();
            this._aComboBox = new System.Windows.Forms.ComboBox();
            this._pagatoLabel = new System.Windows.Forms.Label();
            this._dataLabel = new System.Windows.Forms.Label();
            this._importoLabel = new System.Windows.Forms.Label();
            this._daComboBox = new System.Windows.Forms.ComboBox();
            this._daPictureBox = new System.Windows.Forms.PictureBox();
            this._aPictureBox = new System.Windows.Forms.PictureBox();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._mainTableLayoutPanel.SuspendLayout();
            this._confirmPanel.SuspendLayout();
            this._formTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._daPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._aPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.20455F));
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.79544F));
            this._mainTableLayoutPanel.Size = new System.Drawing.Size(434, 273);
            this._mainTableLayoutPanel.TabIndex = 1;
            // 
            // _saldaLabel
            // 
            this._saldaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._saldaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._saldaLabel.Location = new System.Drawing.Point(3, 0);
            this._saldaLabel.Name = "_saldaLabel";
            this._saldaLabel.Size = new System.Drawing.Size(428, 34);
            this._saldaLabel.TabIndex = 0;
            this._saldaLabel.Text = "Salda";
            this._saldaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _confirmPanel
            // 
            this._confirmPanel.Controls.Add(this._eliminaButton);
            this._confirmPanel.Controls.Add(this._confermaButton);
            this._confirmPanel.Controls.Add(this._annullaButton);
            this._confirmPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._confirmPanel.Location = new System.Drawing.Point(0, 232);
            this._confirmPanel.Margin = new System.Windows.Forms.Padding(0);
            this._confirmPanel.Name = "_confirmPanel";
            this._confirmPanel.Size = new System.Drawing.Size(434, 41);
            this._confirmPanel.TabIndex = 1;
            // 
            // _eliminaButton
            // 
            this._eliminaButton.Location = new System.Drawing.Point(12, 6);
            this._eliminaButton.Name = "_eliminaButton";
            this._eliminaButton.Size = new System.Drawing.Size(75, 23);
            this._eliminaButton.TabIndex = 2;
            this._eliminaButton.Text = "Elimina";
            this._eliminaButton.UseVisualStyleBackColor = true;
            // 
            // _confermaButton
            // 
            this._confermaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._errorProvider.SetIconAlignment(this._confermaButton, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this._confermaButton.Location = new System.Drawing.Point(266, 6);
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
            this._annullaButton.Location = new System.Drawing.Point(347, 6);
            this._annullaButton.Name = "_annullaButton";
            this._annullaButton.Size = new System.Drawing.Size(75, 23);
            this._annullaButton.TabIndex = 0;
            this._annullaButton.Text = "Annulla";
            this._annullaButton.UseVisualStyleBackColor = true;
            // 
            // _formTableLayoutPanel
            // 
            this._formTableLayoutPanel.ColumnCount = 3;
            this._formTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this._formTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._formTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this._formTableLayoutPanel.Controls.Add(this._dateTimePicker, 1, 3);
            this._formTableLayoutPanel.Controls.Add(this._numericUpDown, 1, 2);
            this._formTableLayoutPanel.Controls.Add(this._aComboBox, 2, 1);
            this._formTableLayoutPanel.Controls.Add(this._pagatoLabel, 1, 1);
            this._formTableLayoutPanel.Controls.Add(this._dataLabel, 0, 3);
            this._formTableLayoutPanel.Controls.Add(this._importoLabel, 0, 2);
            this._formTableLayoutPanel.Controls.Add(this._daComboBox, 0, 1);
            this._formTableLayoutPanel.Controls.Add(this._daPictureBox, 0, 0);
            this._formTableLayoutPanel.Controls.Add(this._aPictureBox, 2, 0);
            this._formTableLayoutPanel.Controls.Add(this.pictureBox1, 1, 0);
            this._formTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._formTableLayoutPanel.Location = new System.Drawing.Point(3, 37);
            this._formTableLayoutPanel.Name = "_formTableLayoutPanel";
            this._formTableLayoutPanel.RowCount = 4;
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this._formTableLayoutPanel.Size = new System.Drawing.Size(428, 192);
            this._formTableLayoutPanel.TabIndex = 2;
            // 
            // _dateTimePicker
            // 
            this._dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._dateTimePicker.Location = new System.Drawing.Point(152, 166);
            this._dateTimePicker.Name = "_dateTimePicker";
            this._dateTimePicker.Size = new System.Drawing.Size(122, 20);
            this._dateTimePicker.TabIndex = 17;
            // 
            // _numericUpDown
            // 
            this._numericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._numericUpDown.DecimalPlaces = 2;
            this._numericUpDown.Location = new System.Drawing.Point(152, 135);
            this._numericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this._numericUpDown.Name = "_numericUpDown";
            this._numericUpDown.Size = new System.Drawing.Size(122, 20);
            this._numericUpDown.TabIndex = 15;
            // 
            // _aComboBox
            // 
            this._aComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._aComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._aComboBox.FormattingEnabled = true;
            this._aComboBox.Location = new System.Drawing.Point(280, 102);
            this._aComboBox.Name = "_aComboBox";
            this._aComboBox.Size = new System.Drawing.Size(145, 21);
            this._aComboBox.TabIndex = 16;
            // 
            // _pagatoLabel
            // 
            this._pagatoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pagatoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._pagatoLabel.Location = new System.Drawing.Point(152, 96);
            this._pagatoLabel.Name = "_pagatoLabel";
            this._pagatoLabel.Size = new System.Drawing.Size(122, 34);
            this._pagatoLabel.TabIndex = 0;
            this._pagatoLabel.Text = "rimborsa a";
            this._pagatoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _dataLabel
            // 
            this._dataLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dataLabel.Location = new System.Drawing.Point(3, 160);
            this._dataLabel.Name = "_dataLabel";
            this._dataLabel.Size = new System.Drawing.Size(143, 32);
            this._dataLabel.TabIndex = 2;
            this._dataLabel.Text = "Data:";
            this._dataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _importoLabel
            // 
            this._importoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._importoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._importoLabel.Location = new System.Drawing.Point(3, 130);
            this._importoLabel.Name = "_importoLabel";
            this._importoLabel.Size = new System.Drawing.Size(143, 30);
            this._importoLabel.TabIndex = 1;
            this._importoLabel.Text = "Importo:";
            this._importoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _daComboBox
            // 
            this._daComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._daComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._daComboBox.FormattingEnabled = true;
            this._daComboBox.Location = new System.Drawing.Point(3, 102);
            this._daComboBox.Name = "_daComboBox";
            this._daComboBox.Size = new System.Drawing.Size(143, 21);
            this._daComboBox.TabIndex = 4;
            // 
            // _daPictureBox
            // 
            this._daPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._daPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._daPictureBox.Image = global::Room8.Properties.Resources._default;
            this._daPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("_daPictureBox.InitialImage")));
            this._daPictureBox.Location = new System.Drawing.Point(3, 3);
            this._daPictureBox.Name = "_daPictureBox";
            this._daPictureBox.Size = new System.Drawing.Size(143, 90);
            this._daPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._daPictureBox.TabIndex = 18;
            this._daPictureBox.TabStop = false;
            // 
            // _aPictureBox
            // 
            this._aPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._aPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._aPictureBox.Image = global::Room8.Properties.Resources._default;
            this._aPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("_aPictureBox.InitialImage")));
            this._aPictureBox.Location = new System.Drawing.Point(280, 3);
            this._aPictureBox.Name = "_aPictureBox";
            this._aPictureBox.Size = new System.Drawing.Size(145, 90);
            this._aPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._aPictureBox.TabIndex = 19;
            this._aPictureBox.TabStop = false;
            // 
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(152, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // SaldoForm
            // 
            this.AcceptButton = this._confermaButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 273);
            this.Controls.Add(this._mainTableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(444, 311);
            this.Name = "SaldoForm";
            this.Text = "Room8 - Salda";
            this._mainTableLayoutPanel.ResumeLayout(false);
            this._confirmPanel.ResumeLayout(false);
            this._formTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._daPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._aPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _mainTableLayoutPanel;
        private System.Windows.Forms.Label _saldaLabel;
        private System.Windows.Forms.Panel _confirmPanel;
        private System.Windows.Forms.Button _confermaButton;
        private System.Windows.Forms.Button _annullaButton;
        private System.Windows.Forms.TableLayoutPanel _formTableLayoutPanel;
        private System.Windows.Forms.Label _importoLabel;
        private System.Windows.Forms.NumericUpDown _numericUpDown;
        private System.Windows.Forms.ComboBox _aComboBox;
        private System.Windows.Forms.Label _pagatoLabel;
        private System.Windows.Forms.ComboBox _daComboBox;
        private System.Windows.Forms.Label _dataLabel;
        private System.Windows.Forms.DateTimePicker _dateTimePicker;
        private System.Windows.Forms.PictureBox _daPictureBox;
        private System.Windows.Forms.PictureBox _aPictureBox;
        private System.Windows.Forms.ErrorProvider _errorProvider;
        private System.Windows.Forms.Button _eliminaButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}