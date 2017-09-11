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
            this._mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._titoloLabel = new System.Windows.Forms.Label();
            this._confirmPanel = new System.Windows.Forms.Panel();
            this._commentaButton = new System.Windows.Forms.Button();
            this._commentoTextBox = new System.Windows.Forms.TextBox();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this._commentiListBox = new System.Windows.Forms.ListBox();
            this._mainTableLayoutPanel.SuspendLayout();
            this._confirmPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // _mainTableLayoutPanel
            // 
            this._mainTableLayoutPanel.ColumnCount = 1;
            this._mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._mainTableLayoutPanel.Controls.Add(this._commentiListBox, 0, 1);
            this._mainTableLayoutPanel.Controls.Add(this._titoloLabel, 0, 0);
            this._mainTableLayoutPanel.Controls.Add(this._confirmPanel, 0, 2);
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
            // _titoloLabel
            // 
            this._titoloLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._titoloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._titoloLabel.Location = new System.Drawing.Point(3, 0);
            this._titoloLabel.Name = "_titoloLabel";
            this._titoloLabel.Size = new System.Drawing.Size(358, 40);
            this._titoloLabel.TabIndex = 0;
            this._titoloLabel.Text = "Commenti:";
            this._titoloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // _commentoTextBox
            // 
            this._commentoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._errorProvider.SetIconAlignment(this._commentoTextBox, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this._commentoTextBox.Location = new System.Drawing.Point(8, 7);
            this._commentoTextBox.Name = "_commentoTextBox";
            this._commentoTextBox.Size = new System.Drawing.Size(261, 20);
            this._commentoTextBox.TabIndex = 6;
            // 
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
            // 
            // _commentiListBox
            // 
            this._commentiListBox.BackColor = System.Drawing.SystemColors.Control;
            this._commentiListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._commentiListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._commentiListBox.FormattingEnabled = true;
            this._commentiListBox.HorizontalScrollbar = true;
            this._commentiListBox.ItemHeight = 20;
            this._commentiListBox.Location = new System.Drawing.Point(10, 50);
            this._commentiListBox.Margin = new System.Windows.Forms.Padding(10);
            this._commentiListBox.Name = "_commentiListBox";
            this._commentiListBox.ScrollAlwaysVisible = true;
            this._commentiListBox.Size = new System.Drawing.Size(344, 202);
            this._commentiListBox.TabIndex = 8;
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
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _mainTableLayoutPanel;
        private System.Windows.Forms.Label _titoloLabel;
        private System.Windows.Forms.Panel _confirmPanel;
        private System.Windows.Forms.Button _commentaButton;
        private System.Windows.Forms.TextBox _commentoTextBox;
        private System.Windows.Forms.ErrorProvider _errorProvider;
        private System.Windows.Forms.ListBox _commentiListBox;
    }
}