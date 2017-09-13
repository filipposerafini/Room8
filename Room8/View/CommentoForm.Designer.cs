namespace Room8.View
{
    partial class CommentoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommentoForm));
            this._mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._confirmPanel = new System.Windows.Forms.Panel();
            this._commentoTextBox = new System.Windows.Forms.TextBox();
            this._commentaButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._titoloLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._commentiDataGridView = new System.Windows.Forms.DataGridView();
            this.commentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.autoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._mainTableLayoutPanel.SuspendLayout();
            this._confirmPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._commentiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // _mainTableLayoutPanel
            // 
            this._mainTableLayoutPanel.ColumnCount = 1;
            this._mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._mainTableLayoutPanel.Controls.Add(this._confirmPanel, 0, 2);
            this._mainTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this._mainTableLayoutPanel.Controls.Add(this._commentiDataGridView, 0, 1);
            this._mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._mainTableLayoutPanel.Name = "_mainTableLayoutPanel";
            this._mainTableLayoutPanel.RowCount = 3;
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._mainTableLayoutPanel.Size = new System.Drawing.Size(364, 302);
            this._mainTableLayoutPanel.TabIndex = 1;
            // 
            // _confirmPanel
            // 
            this._confirmPanel.Controls.Add(this._commentoTextBox);
            this._confirmPanel.Controls.Add(this._commentaButton);
            this._confirmPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._confirmPanel.Location = new System.Drawing.Point(0, 262);
            this._confirmPanel.Margin = new System.Windows.Forms.Padding(0);
            this._confirmPanel.Name = "_confirmPanel";
            this._confirmPanel.Size = new System.Drawing.Size(364, 40);
            this._confirmPanel.TabIndex = 1;
            // 
            // _commentoTextBox
            // 
            this._commentoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._errorProvider.SetIconAlignment(this._commentoTextBox, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this._commentoTextBox.Location = new System.Drawing.Point(8, 7);
            this._commentoTextBox.Name = "_commentoTextBox";
            this._commentoTextBox.Size = new System.Drawing.Size(250, 20);
            this._commentoTextBox.TabIndex = 6;
            // 
            // _commentaButton
            // 
            this._commentaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._commentaButton.AutoSize = true;
            this._errorProvider.SetIconAlignment(this._commentaButton, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this._commentaButton.Location = new System.Drawing.Point(275, 5);
            this._commentaButton.Name = "_commentaButton";
            this._commentaButton.Size = new System.Drawing.Size(79, 23);
            this._commentaButton.TabIndex = 1;
            this._commentaButton.Text = "Commenta";
            this._commentaButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.73184F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.26816F));
            this.tableLayoutPanel1.Controls.Add(this._titoloLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(358, 34);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // _titoloLabel
            // 
            this._titoloLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._titoloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._titoloLabel.Location = new System.Drawing.Point(44, 0);
            this._titoloLabel.Name = "_titoloLabel";
            this._titoloLabel.Size = new System.Drawing.Size(311, 34);
            this._titoloLabel.TabIndex = 1;
            this._titoloLabel.Text = "Commenti";
            this._titoloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // _commentiDataGridView
            // 
            this._commentiDataGridView.AllowUserToAddRows = false;
            this._commentiDataGridView.AllowUserToDeleteRows = false;
            this._commentiDataGridView.AutoGenerateColumns = false;
            this._commentiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._commentiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.autoreDataGridViewTextBoxColumn,
            this.testoDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn});
            this._commentiDataGridView.DataSource = this.commentoBindingSource;
            this._commentiDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._commentiDataGridView.Location = new System.Drawing.Point(3, 43);
            this._commentiDataGridView.Name = "_commentiDataGridView";
            this._commentiDataGridView.ReadOnly = true;
            this._commentiDataGridView.Size = new System.Drawing.Size(358, 216);
            this._commentiDataGridView.TabIndex = 10;
            // 
            // commentoBindingSource
            // 
            this.commentoBindingSource.DataSource = typeof(Room8.Commento);
            // 
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
            // 
            // autoreDataGridViewTextBoxColumn
            // 
            this.autoreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.autoreDataGridViewTextBoxColumn.DataPropertyName = "NomeAutore";
            this.autoreDataGridViewTextBoxColumn.HeaderText = "Autore";
            this.autoreDataGridViewTextBoxColumn.Name = "autoreDataGridViewTextBoxColumn";
            this.autoreDataGridViewTextBoxColumn.ReadOnly = true;
            this.autoreDataGridViewTextBoxColumn.Width = 63;
            // 
            // testoDataGridViewTextBoxColumn
            // 
            this.testoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.testoDataGridViewTextBoxColumn.DataPropertyName = "Testo";
            this.testoDataGridViewTextBoxColumn.HeaderText = "Testo";
            this.testoDataGridViewTextBoxColumn.Name = "testoDataGridViewTextBoxColumn";
            this.testoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataDataGridViewTextBoxColumn.Width = 55;
            // 
            // CommentoForm
            // 
            this.AcceptButton = this._commentaButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 302);
            this.Controls.Add(this._mainTableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(380, 340);
            this.Name = "CommentoForm";
            this.Text = "Room8 - Commenti";
            this._mainTableLayoutPanel.ResumeLayout(false);
            this._confirmPanel.ResumeLayout(false);
            this._confirmPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._commentiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _mainTableLayoutPanel;
        private System.Windows.Forms.Panel _confirmPanel;
        private System.Windows.Forms.Button _commentaButton;
        private System.Windows.Forms.TextBox _commentoTextBox;
        private System.Windows.Forms.ErrorProvider _errorProvider;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label _titoloLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView _commentiDataGridView;
        private System.Windows.Forms.BindingSource commentoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
    }
}