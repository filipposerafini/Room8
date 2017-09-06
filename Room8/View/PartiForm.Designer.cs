namespace Room8.View
{
    partial class PartiForm
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
            this._confirmPanel = new System.Windows.Forms.Panel();
            this._confermaButton = new System.Windows.Forms.Button();
            this._annullaButton = new System.Windows.Forms.Button();
            this._formTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._partiLabel = new System.Windows.Forms.Label();
            this._scrollPanel = new System.Windows.Forms.Panel();
            this._splitContainer = new System.Windows.Forms.SplitContainer();
            this._vScrollBar = new System.Windows.Forms.VScrollBar();
            this._partiTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._mainTableLayoutPanel.SuspendLayout();
            this._confirmPanel.SuspendLayout();
            this._formTableLayoutPanel.SuspendLayout();
            this._scrollPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).BeginInit();
            this._splitContainer.SuspendLayout();
            this._partiTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mainTableLayoutPanel
            // 
            this._mainTableLayoutPanel.ColumnCount = 1;
            this._mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._mainTableLayoutPanel.Controls.Add(this._confirmPanel, 0, 2);
            this._mainTableLayoutPanel.Controls.Add(this._formTableLayoutPanel, 0, 1);
            this._mainTableLayoutPanel.Controls.Add(this._partiLabel, 0, 0);
            this._mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._mainTableLayoutPanel.Name = "_mainTableLayoutPanel";
            this._mainTableLayoutPanel.RowCount = 3;
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._mainTableLayoutPanel.Size = new System.Drawing.Size(369, 268);
            this._mainTableLayoutPanel.TabIndex = 3;
            // 
            // _confirmPanel
            // 
            this._confirmPanel.Controls.Add(this._confermaButton);
            this._confirmPanel.Controls.Add(this._annullaButton);
            this._confirmPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._confirmPanel.Location = new System.Drawing.Point(0, 223);
            this._confirmPanel.Margin = new System.Windows.Forms.Padding(0);
            this._confirmPanel.Name = "_confirmPanel";
            this._confirmPanel.Size = new System.Drawing.Size(369, 45);
            this._confirmPanel.TabIndex = 1;
            // 
            // _confermaButton
            // 
            this._confermaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._confermaButton.Location = new System.Drawing.Point(201, 10);
            this._confermaButton.Name = "_confermaButton";
            this._confermaButton.Size = new System.Drawing.Size(75, 23);
            this._confermaButton.TabIndex = 1;
            this._confermaButton.Text = "Conferma";
            this._confermaButton.UseVisualStyleBackColor = true;
            // 
            // _annullaButton
            // 
            this._annullaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._annullaButton.Location = new System.Drawing.Point(282, 10);
            this._annullaButton.Name = "_annullaButton";
            this._annullaButton.Size = new System.Drawing.Size(75, 23);
            this._annullaButton.TabIndex = 0;
            this._annullaButton.Text = "Annulla";
            this._annullaButton.UseVisualStyleBackColor = true;
            // 
            // _formTableLayoutPanel
            // 
            this._formTableLayoutPanel.ColumnCount = 1;
            this._formTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._formTableLayoutPanel.Controls.Add(this._scrollPanel, 0, 0);
            this._formTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._formTableLayoutPanel.Location = new System.Drawing.Point(3, 37);
            this._formTableLayoutPanel.Name = "_formTableLayoutPanel";
            this._formTableLayoutPanel.RowCount = 1;
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this._formTableLayoutPanel.Size = new System.Drawing.Size(363, 183);
            this._formTableLayoutPanel.TabIndex = 2;
            // 
            // _partiLabel
            // 
            this._partiLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._partiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._partiLabel.Location = new System.Drawing.Point(3, 0);
            this._partiLabel.Name = "_partiLabel";
            this._partiLabel.Size = new System.Drawing.Size(363, 34);
            this._partiLabel.TabIndex = 0;
            this._partiLabel.Text = "Dividi per";
            this._partiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _scrollPanel
            // 
            this._scrollPanel.Controls.Add(this._partiTableLayoutPanel);
            this._scrollPanel.Controls.Add(this._vScrollBar);
            this._scrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._scrollPanel.Location = new System.Drawing.Point(0, 0);
            this._scrollPanel.Margin = new System.Windows.Forms.Padding(0);
            this._scrollPanel.Name = "_scrollPanel";
            this._scrollPanel.Size = new System.Drawing.Size(363, 183);
            this._scrollPanel.TabIndex = 0;
            // 
            // _splitContainer
            // 
            this._splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._splitContainer.Location = new System.Drawing.Point(3, 3);
            this._splitContainer.Name = "_splitContainer";
            this._splitContainer.Size = new System.Drawing.Size(337, 174);
            this._splitContainer.SplitterDistance = 112;
            this._splitContainer.TabIndex = 0;
            // 
            // _vScrollBar
            // 
            this._vScrollBar.Dock = System.Windows.Forms.DockStyle.Right;
            this._vScrollBar.Location = new System.Drawing.Point(346, 0);
            this._vScrollBar.Name = "_vScrollBar";
            this._vScrollBar.Size = new System.Drawing.Size(17, 183);
            this._vScrollBar.TabIndex = 1;
            // 
            // _partiTableLayoutPanel
            // 
            this._partiTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._partiTableLayoutPanel.ColumnCount = 1;
            this._partiTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._partiTableLayoutPanel.Controls.Add(this._splitContainer, 0, 0);
            this._partiTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._partiTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this._partiTableLayoutPanel.Name = "_partiTableLayoutPanel";
            this._partiTableLayoutPanel.RowCount = 1;
            this._partiTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._partiTableLayoutPanel.Size = new System.Drawing.Size(343, 180);
            this._partiTableLayoutPanel.TabIndex = 2;
            // 
            // PartiForm
            // 
            this.AcceptButton = this._confermaButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 268);
            this.Controls.Add(this._mainTableLayoutPanel);
            this.Name = "PartiForm";
            this.Text = "Room8 - Divisione";
            this._mainTableLayoutPanel.ResumeLayout(false);
            this._confirmPanel.ResumeLayout(false);
            this._formTableLayoutPanel.ResumeLayout(false);
            this._scrollPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).EndInit();
            this._splitContainer.ResumeLayout(false);
            this._partiTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _mainTableLayoutPanel;
        private System.Windows.Forms.Label _partiLabel;
        private System.Windows.Forms.Panel _confirmPanel;
        private System.Windows.Forms.Button _confermaButton;
        private System.Windows.Forms.Button _annullaButton;
        private System.Windows.Forms.TableLayoutPanel _formTableLayoutPanel;
        private System.Windows.Forms.Panel _scrollPanel;
        private System.Windows.Forms.VScrollBar _vScrollBar;
        private System.Windows.Forms.SplitContainer _splitContainer;
        private System.Windows.Forms.TableLayoutPanel _partiTableLayoutPanel;
    }
}