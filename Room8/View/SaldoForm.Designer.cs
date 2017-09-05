﻿namespace Room8.View
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
            this._mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._saldaLabel = new System.Windows.Forms.Label();
            this._confirmPanel = new System.Windows.Forms.Panel();
            this._confermaButton = new System.Windows.Forms.Button();
            this._annullaButton = new System.Windows.Forms.Button();
            this._formTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._pagatoLabel = new System.Windows.Forms.Label();
            this._importoLabel = new System.Windows.Forms.Label();
            this._dataLabel = new System.Windows.Forms.Label();
            this._daComboBox = new System.Windows.Forms.ComboBox();
            this._numericUpDown = new System.Windows.Forms.NumericUpDown();
            this._aComboBox = new System.Windows.Forms.ComboBox();
            this._dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this._mainTableLayoutPanel.SuspendLayout();
            this._confirmPanel.SuspendLayout();
            this._formTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDown)).BeginInit();
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
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.45026F));
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.54974F));
            this._mainTableLayoutPanel.Size = new System.Drawing.Size(428, 213);
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
            this._saldaLabel.Size = new System.Drawing.Size(422, 34);
            this._saldaLabel.TabIndex = 0;
            this._saldaLabel.Text = "Salda";
            this._saldaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _confirmPanel
            // 
            this._confirmPanel.Controls.Add(this._confermaButton);
            this._confirmPanel.Controls.Add(this._annullaButton);
            this._confirmPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._confirmPanel.Location = new System.Drawing.Point(0, 170);
            this._confirmPanel.Margin = new System.Windows.Forms.Padding(0);
            this._confirmPanel.Name = "_confirmPanel";
            this._confirmPanel.Size = new System.Drawing.Size(428, 43);
            this._confirmPanel.TabIndex = 1;
            // 
            // _confermaButton
            // 
            this._confermaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._confermaButton.Location = new System.Drawing.Point(260, 8);
            this._confermaButton.Name = "_confermaButton";
            this._confermaButton.Size = new System.Drawing.Size(75, 23);
            this._confermaButton.TabIndex = 1;
            this._confermaButton.Text = "Conferma";
            this._confermaButton.UseVisualStyleBackColor = true;
            // 
            // _annullaButton
            // 
            this._annullaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._annullaButton.Location = new System.Drawing.Point(341, 8);
            this._annullaButton.Name = "_annullaButton";
            this._annullaButton.Size = new System.Drawing.Size(75, 23);
            this._annullaButton.TabIndex = 0;
            this._annullaButton.Text = "Annulla";
            this._annullaButton.UseVisualStyleBackColor = true;
            // 
            // _formTableLayoutPanel
            // 
            this._formTableLayoutPanel.ColumnCount = 3;
            this._formTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.9F));
            this._formTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.1F));
            this._formTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this._formTableLayoutPanel.Controls.Add(this._importoLabel, 0, 1);
            this._formTableLayoutPanel.Controls.Add(this._dataLabel, 0, 2);
            this._formTableLayoutPanel.Controls.Add(this._aComboBox, 2, 0);
            this._formTableLayoutPanel.Controls.Add(this._pagatoLabel, 1, 0);
            this._formTableLayoutPanel.Controls.Add(this._daComboBox, 0, 0);
            this._formTableLayoutPanel.Controls.Add(this._numericUpDown, 1, 1);
            this._formTableLayoutPanel.Controls.Add(this._dateTimePicker, 1, 2);
            this._formTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._formTableLayoutPanel.Location = new System.Drawing.Point(3, 37);
            this._formTableLayoutPanel.Name = "_formTableLayoutPanel";
            this._formTableLayoutPanel.RowCount = 3;
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._formTableLayoutPanel.Size = new System.Drawing.Size(422, 130);
            this._formTableLayoutPanel.TabIndex = 2;
            // 
            // _pagatoLabel
            // 
            this._pagatoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pagatoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._pagatoLabel.Location = new System.Drawing.Point(146, 0);
            this._pagatoLabel.Name = "_pagatoLabel";
            this._pagatoLabel.Size = new System.Drawing.Size(133, 43);
            this._pagatoLabel.TabIndex = 0;
            this._pagatoLabel.Text = "ha pagato a ";
            this._pagatoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _importoLabel
            // 
            this._importoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._importoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._importoLabel.Location = new System.Drawing.Point(3, 43);
            this._importoLabel.Name = "_importoLabel";
            this._importoLabel.Size = new System.Drawing.Size(137, 43);
            this._importoLabel.TabIndex = 1;
            this._importoLabel.Text = "Descrizione:";
            this._importoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _dataLabel
            // 
            this._dataLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dataLabel.Location = new System.Drawing.Point(3, 86);
            this._dataLabel.Name = "_dataLabel";
            this._dataLabel.Size = new System.Drawing.Size(137, 44);
            this._dataLabel.TabIndex = 2;
            this._dataLabel.Text = "Data:";
            this._dataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _daComboBox
            // 
            this._daComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._daComboBox.FormattingEnabled = true;
            this._daComboBox.Location = new System.Drawing.Point(3, 11);
            this._daComboBox.Name = "_daComboBox";
            this._daComboBox.Size = new System.Drawing.Size(137, 21);
            this._daComboBox.TabIndex = 4;
            // 
            // _numericUpDown
            // 
            this._numericUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._numericUpDown.DecimalPlaces = 2;
            this._numericUpDown.Location = new System.Drawing.Point(146, 54);
            this._numericUpDown.Name = "_numericUpDown";
            this._numericUpDown.Size = new System.Drawing.Size(133, 20);
            this._numericUpDown.TabIndex = 15;
            // 
            // _aComboBox
            // 
            this._aComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._aComboBox.FormattingEnabled = true;
            this._aComboBox.Location = new System.Drawing.Point(285, 11);
            this._aComboBox.Name = "_aComboBox";
            this._aComboBox.Size = new System.Drawing.Size(134, 21);
            this._aComboBox.TabIndex = 16;
            // 
            // _dateTimePicker
            // 
            this._dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._dateTimePicker.Location = new System.Drawing.Point(146, 98);
            this._dateTimePicker.Name = "_dateTimePicker";
            this._dateTimePicker.Size = new System.Drawing.Size(133, 20);
            this._dateTimePicker.TabIndex = 17;
            // 
            // SaldoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 213);
            this.Controls.Add(this._mainTableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(444, 251);
            this.Name = "SaldoForm";
            this.Text = "Room8 - Salda";
            this._mainTableLayoutPanel.ResumeLayout(false);
            this._confirmPanel.ResumeLayout(false);
            this._formTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDown)).EndInit();
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
        private System.Windows.Forms.Label _dataLabel;
        private System.Windows.Forms.NumericUpDown _numericUpDown;
        private System.Windows.Forms.ComboBox _aComboBox;
        private System.Windows.Forms.Label _pagatoLabel;
        private System.Windows.Forms.ComboBox _daComboBox;
        private System.Windows.Forms.DateTimePicker _dateTimePicker;
    }
}