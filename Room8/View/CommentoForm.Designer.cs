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
            this._mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._titoloLabel = new System.Windows.Forms.Label();
            this._confirmPanel = new System.Windows.Forms.Panel();
            this._commentaButton = new System.Windows.Forms.Button();
            this._chiudiButton = new System.Windows.Forms.Button();
            this._formTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._listaCommentiLabel = new System.Windows.Forms.Label();
            this._commentoLabel = new System.Windows.Forms.Label();
            this._descrizioneTextBox = new System.Windows.Forms.TextBox();
            this._commentiListBox = new System.Windows.Forms.ListBox();
            this._mainTableLayoutPanel.SuspendLayout();
            this._confirmPanel.SuspendLayout();
            this._formTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mainTableLayoutPanel
            // 
            this._mainTableLayoutPanel.ColumnCount = 1;
            this._mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._mainTableLayoutPanel.Controls.Add(this._titoloLabel, 0, 0);
            this._mainTableLayoutPanel.Controls.Add(this._confirmPanel, 0, 2);
            this._mainTableLayoutPanel.Controls.Add(this._formTableLayoutPanel, 0, 1);
            this._mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._mainTableLayoutPanel.Name = "_mainTableLayoutPanel";
            this._mainTableLayoutPanel.RowCount = 3;
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.94727F));
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.05274F));
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
            this._titoloLabel.Size = new System.Drawing.Size(358, 34);
            this._titoloLabel.TabIndex = 0;
            this._titoloLabel.Text = "Commenti";
            this._titoloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _confirmPanel
            // 
            this._confirmPanel.Controls.Add(this._commentaButton);
            this._confirmPanel.Controls.Add(this._chiudiButton);
            this._confirmPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._confirmPanel.Location = new System.Drawing.Point(0, 264);
            this._confirmPanel.Margin = new System.Windows.Forms.Padding(0);
            this._confirmPanel.Name = "_confirmPanel";
            this._confirmPanel.Size = new System.Drawing.Size(364, 38);
            this._confirmPanel.TabIndex = 1;
            // 
            // _commentaButton
            // 
            this._commentaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._commentaButton.Location = new System.Drawing.Point(196, 3);
            this._commentaButton.Name = "_commentaButton";
            this._commentaButton.Size = new System.Drawing.Size(75, 23);
            this._commentaButton.TabIndex = 1;
            this._commentaButton.Text = "Commenta";
            this._commentaButton.UseVisualStyleBackColor = true;
            // 
            // _chiudiButton
            // 
            this._chiudiButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._chiudiButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._chiudiButton.Location = new System.Drawing.Point(277, 3);
            this._chiudiButton.Name = "_chiudiButton";
            this._chiudiButton.Size = new System.Drawing.Size(75, 23);
            this._chiudiButton.TabIndex = 0;
            this._chiudiButton.Text = "Chiudi";
            this._chiudiButton.UseVisualStyleBackColor = true;
            // 
            // _formTableLayoutPanel
            // 
            this._formTableLayoutPanel.ColumnCount = 2;
            this._formTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.90136F));
            this._formTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.09864F));
            this._formTableLayoutPanel.Controls.Add(this._listaCommentiLabel, 0, 0);
            this._formTableLayoutPanel.Controls.Add(this._commentoLabel, 0, 1);
            this._formTableLayoutPanel.Controls.Add(this._descrizioneTextBox, 1, 1);
            this._formTableLayoutPanel.Controls.Add(this._commentiListBox, 1, 0);
            this._formTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._formTableLayoutPanel.Location = new System.Drawing.Point(3, 37);
            this._formTableLayoutPanel.Name = "_formTableLayoutPanel";
            this._formTableLayoutPanel.RowCount = 2;
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.375F));
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.625F));
            this._formTableLayoutPanel.Size = new System.Drawing.Size(358, 224);
            this._formTableLayoutPanel.TabIndex = 2;
            // 
            // _listaCommentiLabel
            // 
            this._listaCommentiLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._listaCommentiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._listaCommentiLabel.Location = new System.Drawing.Point(3, 0);
            this._listaCommentiLabel.Name = "_listaCommentiLabel";
            this._listaCommentiLabel.Size = new System.Drawing.Size(126, 189);
            this._listaCommentiLabel.TabIndex = 0;
            this._listaCommentiLabel.Text = "Lista commenti:";
            this._listaCommentiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _commentoLabel
            // 
            this._commentoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._commentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._commentoLabel.Location = new System.Drawing.Point(3, 189);
            this._commentoLabel.Name = "_commentoLabel";
            this._commentoLabel.Size = new System.Drawing.Size(126, 35);
            this._commentoLabel.TabIndex = 1;
            this._commentoLabel.Text = "Commento:";
            this._commentoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _descrizioneTextBox
            // 
            this._descrizioneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._descrizioneTextBox.Location = new System.Drawing.Point(135, 196);
            this._descrizioneTextBox.Name = "_descrizioneTextBox";
            this._descrizioneTextBox.Size = new System.Drawing.Size(220, 20);
            this._descrizioneTextBox.TabIndex = 6;
            // 
            // _commentiListBox
            // 
            this._commentiListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._commentiListBox.FormattingEnabled = true;
            this._commentiListBox.Location = new System.Drawing.Point(135, 3);
            this._commentiListBox.Name = "_commentiListBox";
            this._commentiListBox.Size = new System.Drawing.Size(220, 183);
            this._commentiListBox.TabIndex = 7;
            // 
            // CommentoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 302);
            this.Controls.Add(this._mainTableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(380, 340);
            this.Name = "CommentoForm";
            this.Text = "Room8 - Commenti";
            this._mainTableLayoutPanel.ResumeLayout(false);
            this._confirmPanel.ResumeLayout(false);
            this._formTableLayoutPanel.ResumeLayout(false);
            this._formTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _mainTableLayoutPanel;
        private System.Windows.Forms.Label _titoloLabel;
        private System.Windows.Forms.Panel _confirmPanel;
        private System.Windows.Forms.Button _commentaButton;
        private System.Windows.Forms.Button _chiudiButton;
        private System.Windows.Forms.TableLayoutPanel _formTableLayoutPanel;
        private System.Windows.Forms.Label _listaCommentiLabel;
        private System.Windows.Forms.Label _commentoLabel;
        private System.Windows.Forms.TextBox _descrizioneTextBox;
        private System.Windows.Forms.ListBox _commentiListBox;
    }
}