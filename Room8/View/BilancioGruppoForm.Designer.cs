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
            this._pictureBox = new System.Windows.Forms.PictureBox();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this._modificaButton = new System.Windows.Forms.Button();
            this._registratiLabel = new System.Windows.Forms.Label();
            this._mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._bottomPanel = new System.Windows.Forms.Panel();
            this._titleTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._centerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._speseTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._speseListBox = new System.Windows.Forms.ListBox();
            this._speseLabel = new System.Windows.Forms.Label();
            this._membriTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._separatorLabel = new System.Windows.Forms.Label();
            this._riepilogoBilancioLabel = new System.Windows.Forms.Label();
            this._bilancioImportoLabel = new System.Windows.Forms.Label();
            this._membriListBox = new System.Windows.Forms.ListBox();
            this._membriLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this._mainTableLayoutPanel.SuspendLayout();
            this._bottomPanel.SuspendLayout();
            this._titleTableLayoutPanel.SuspendLayout();
            this._centerTableLayoutPanel.SuspendLayout();
            this._speseTableLayoutPanel.SuspendLayout();
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
            this._pictureBox.Size = new System.Drawing.Size(118, 51);
            this._pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._pictureBox.TabIndex = 0;
            this._pictureBox.TabStop = false;
            // 
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
            // 
            // _modificaButton
            // 
            this._modificaButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._modificaButton.Location = new System.Drawing.Point(420, 11);
            this._modificaButton.Name = "_modificaButton";
            this._modificaButton.Size = new System.Drawing.Size(75, 23);
            this._modificaButton.TabIndex = 13;
            this._modificaButton.Text = "Modifica";
            this._modificaButton.UseVisualStyleBackColor = true;
            // 
            // _registratiLabel
            // 
            this._registratiLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._registratiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._registratiLabel.Location = new System.Drawing.Point(121, 0);
            this._registratiLabel.Name = "_registratiLabel";
            this._registratiLabel.Size = new System.Drawing.Size(383, 51);
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
            this._bottomPanel.Controls.Add(this._modificaButton);
            this._bottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._bottomPanel.Location = new System.Drawing.Point(0, 328);
            this._bottomPanel.Margin = new System.Windows.Forms.Padding(0);
            this._bottomPanel.Name = "_bottomPanel";
            this._bottomPanel.Size = new System.Drawing.Size(507, 46);
            this._bottomPanel.TabIndex = 14;
            // 
            // _titleTableLayoutPanel
            // 
            this._titleTableLayoutPanel.ColumnCount = 2;
            this._titleTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.44961F));
            this._titleTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.55038F));
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
            this._speseTableLayoutPanel.Controls.Add(this._speseListBox, 0, 1);
            this._speseTableLayoutPanel.Controls.Add(this._speseLabel, 0, 0);
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
            // _speseListBox
            // 
            this._speseListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._speseListBox.FormattingEnabled = true;
            this._speseListBox.Location = new System.Drawing.Point(0, 30);
            this._speseListBox.Margin = new System.Windows.Forms.Padding(0);
            this._speseListBox.Name = "_speseListBox";
            this._speseListBox.ScrollAlwaysVisible = true;
            this._speseListBox.Size = new System.Drawing.Size(367, 243);
            this._speseListBox.TabIndex = 0;
            // 
            // _speseLabel
            // 
            this._speseLabel.AutoSize = true;
            this._speseLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._speseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._speseLabel.Location = new System.Drawing.Point(3, 0);
            this._speseLabel.Name = "_speseLabel";
            this._speseLabel.Size = new System.Drawing.Size(361, 30);
            this._speseLabel.TabIndex = 3;
            this._speseLabel.Text = "Lista spese:";
            this._speseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _membriTableLayoutPanel
            // 
            this._membriTableLayoutPanel.ColumnCount = 1;
            this._membriTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._membriTableLayoutPanel.Controls.Add(this._separatorLabel, 0, 2);
            this._membriTableLayoutPanel.Controls.Add(this._riepilogoBilancioLabel, 0, 0);
            this._membriTableLayoutPanel.Controls.Add(this._bilancioImportoLabel, 0, 1);
            this._membriTableLayoutPanel.Controls.Add(this._membriListBox, 0, 4);
            this._membriTableLayoutPanel.Controls.Add(this._membriLabel, 0, 3);
            this._membriTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._membriTableLayoutPanel.Location = new System.Drawing.Point(2, 2);
            this._membriTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this._membriTableLayoutPanel.Name = "_membriTableLayoutPanel";
            this._membriTableLayoutPanel.RowCount = 5;
            this._membriTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.23729F));
            this._membriTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.76271F));
            this._membriTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._membriTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this._membriTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this._membriTableLayoutPanel.Size = new System.Drawing.Size(132, 269);
            this._membriTableLayoutPanel.TabIndex = 2;
            // 
            // _separatorLabel
            // 
            this._separatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._separatorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._separatorLabel.Location = new System.Drawing.Point(3, 42);
            this._separatorLabel.Name = "_separatorLabel";
            this._separatorLabel.Size = new System.Drawing.Size(126, 2);
            this._separatorLabel.TabIndex = 14;
            this._separatorLabel.Text = "dfgdfgdfgdfgdfgfd";
            // 
            // _riepilogoBilancioLabel
            // 
            this._riepilogoBilancioLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._riepilogoBilancioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._riepilogoBilancioLabel.Location = new System.Drawing.Point(3, 0);
            this._riepilogoBilancioLabel.MinimumSize = new System.Drawing.Size(126, 23);
            this._riepilogoBilancioLabel.Name = "_riepilogoBilancioLabel";
            this._riepilogoBilancioLabel.Size = new System.Drawing.Size(126, 23);
            this._riepilogoBilancioLabel.TabIndex = 2;
            this._riepilogoBilancioLabel.Text = "Bilancio totale:";
            this._riepilogoBilancioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _bilancioImportoLabel
            // 
            this._bilancioImportoLabel.AutoSize = true;
            this._bilancioImportoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._bilancioImportoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bilancioImportoLabel.Location = new System.Drawing.Point(3, 23);
            this._bilancioImportoLabel.Name = "_bilancioImportoLabel";
            this._bilancioImportoLabel.Size = new System.Drawing.Size(126, 19);
            this._bilancioImportoLabel.TabIndex = 3;
            this._bilancioImportoLabel.Text = "Soldi";
            this._bilancioImportoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _membriListBox
            // 
            this._membriListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._membriListBox.FormattingEnabled = true;
            this._membriListBox.Location = new System.Drawing.Point(0, 75);
            this._membriListBox.Margin = new System.Windows.Forms.Padding(0);
            this._membriListBox.Name = "_membriListBox";
            this._membriListBox.ScrollAlwaysVisible = true;
            this._membriListBox.Size = new System.Drawing.Size(132, 194);
            this._membriListBox.TabIndex = 1;
            // 
            // _membriLabel
            // 
            this._membriLabel.AutoSize = true;
            this._membriLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._membriLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._membriLabel.Location = new System.Drawing.Point(3, 44);
            this._membriLabel.Name = "_membriLabel";
            this._membriLabel.Size = new System.Drawing.Size(126, 31);
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
            this.Name = "BilancioGruppoForm";
            this.Text = "Room8 - Gruppo";
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this._mainTableLayoutPanel.ResumeLayout(false);
            this._bottomPanel.ResumeLayout(false);
            this._titleTableLayoutPanel.ResumeLayout(false);
            this._centerTableLayoutPanel.ResumeLayout(false);
            this._speseTableLayoutPanel.ResumeLayout(false);
            this._speseTableLayoutPanel.PerformLayout();
            this._membriTableLayoutPanel.ResumeLayout(false);
            this._membriTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox _pictureBox;
        private System.Windows.Forms.ErrorProvider _errorProvider;
        private System.Windows.Forms.TableLayoutPanel _mainTableLayoutPanel;
        private System.Windows.Forms.Panel _bottomPanel;
        private System.Windows.Forms.Button _modificaButton;
        private System.Windows.Forms.TableLayoutPanel _titleTableLayoutPanel;
        private System.Windows.Forms.Label _registratiLabel;
        private System.Windows.Forms.TableLayoutPanel _centerTableLayoutPanel;
        private System.Windows.Forms.ListBox _speseListBox;
        private System.Windows.Forms.ListBox _membriListBox;
        private System.Windows.Forms.Label _membriLabel;
        private System.Windows.Forms.Label _speseLabel;
        private System.Windows.Forms.TableLayoutPanel _speseTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel _membriTableLayoutPanel;
        private System.Windows.Forms.Label _riepilogoBilancioLabel;
        private System.Windows.Forms.Label _bilancioImportoLabel;
        private System.Windows.Forms.Label _separatorLabel;
    }
}