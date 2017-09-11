using System.Globalization;

namespace Room8
{
    partial class MainForm
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
            this._mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this._amiciListBox = new System.Windows.Forms.ListBox();
            this._amiciMenuLabel = new System.Windows.Forms.Label();
            this._gruppiMenuLabel = new System.Windows.Forms.Label();
            this._gruppiListBox = new System.Windows.Forms.ListBox();
            this._riepilogoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._riepilogoInfoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._bilancioTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._riepilogoBilancioLabel = new System.Windows.Forms.Label();
            this._bilancioImportoLabel = new System.Windows.Forms.Label();
            this._deviTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._riepilogoDeviLabel = new System.Windows.Forms.Label();
            this._deviImportoLabel = new System.Windows.Forms.Label();
            this._dovutoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._riepilogoDovutoLabel = new System.Windows.Forms.Label();
            this._dovutoImportoLabel = new System.Windows.Forms.Label();
            this._topTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._toolStrip = new System.Windows.Forms.ToolStrip();
            this._utenteToolStrip = new System.Windows.Forms.ToolStripDropDownButton();
            this._accountToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this._creaGruppoToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this._toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this._esciToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this._riepilogoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this._pictureBox = new System.Windows.Forms.PictureBox();
            this._speseLabel = new System.Windows.Forms.Label();
            this._speseDataGridView = new System.Windows.Forms.DataGridView();
            this.spesaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._saldiLabel = new System.Windows.Forms.Label();
            this._saldiDataGridView = new System.Windows.Forms.DataGridView();
            this.saldoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._menuTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._spesaButton = new System.Windows.Forms.Button();
            this._saldaButton = new System.Windows.Forms.Button();
            this._formTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.descrizioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sorgente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destinazione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._riepilogoTableLayoutPanel.SuspendLayout();
            this._riepilogoInfoTableLayoutPanel.SuspendLayout();
            this._bilancioTableLayoutPanel.SuspendLayout();
            this._deviTableLayoutPanel.SuspendLayout();
            this._dovutoTableLayoutPanel.SuspendLayout();
            this._topTableLayoutPanel.SuspendLayout();
            this._toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._speseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spesaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._saldiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saldoBindingSource)).BeginInit();
            this._menuTableLayoutPanel.SuspendLayout();
            this._formTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mainStatusStrip
            // 
            this._mainStatusStrip.Location = new System.Drawing.Point(0, 440);
            this._mainStatusStrip.Name = "_mainStatusStrip";
            this._mainStatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this._mainStatusStrip.Size = new System.Drawing.Size(648, 22);
            this._mainStatusStrip.TabIndex = 0;
            this._mainStatusStrip.Text = "statusStrip1";
            // 
            // _amiciListBox
            // 
            this._amiciListBox.BackColor = System.Drawing.Color.White;
            this._amiciListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._amiciListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._amiciListBox.FormattingEnabled = true;
            this._amiciListBox.ItemHeight = 15;
            this._amiciListBox.Location = new System.Drawing.Point(3, 288);
            this._amiciListBox.Name = "_amiciListBox";
            this._amiciListBox.ScrollAlwaysVisible = true;
            this._amiciListBox.Size = new System.Drawing.Size(155, 143);
            this._amiciListBox.TabIndex = 9;
            // 
            // _amiciMenuLabel
            // 
            this._amiciMenuLabel.AutoSize = true;
            this._amiciMenuLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._amiciMenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._amiciMenuLabel.Location = new System.Drawing.Point(3, 260);
            this._amiciMenuLabel.Name = "_amiciMenuLabel";
            this._amiciMenuLabel.Size = new System.Drawing.Size(155, 25);
            this._amiciMenuLabel.TabIndex = 8;
            this._amiciMenuLabel.Text = "Amici:";
            this._amiciMenuLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // _gruppiMenuLabel
            // 
            this._gruppiMenuLabel.AutoSize = true;
            this._gruppiMenuLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gruppiMenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._gruppiMenuLabel.Location = new System.Drawing.Point(3, 88);
            this._gruppiMenuLabel.Name = "_gruppiMenuLabel";
            this._gruppiMenuLabel.Size = new System.Drawing.Size(155, 25);
            this._gruppiMenuLabel.TabIndex = 7;
            this._gruppiMenuLabel.Text = "Gruppi:";
            this._gruppiMenuLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // _gruppiListBox
            // 
            this._gruppiListBox.BackColor = System.Drawing.Color.White;
            this._gruppiListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gruppiListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._gruppiListBox.FormattingEnabled = true;
            this._gruppiListBox.ItemHeight = 15;
            this._gruppiListBox.Location = new System.Drawing.Point(3, 116);
            this._gruppiListBox.Name = "_gruppiListBox";
            this._gruppiListBox.ScrollAlwaysVisible = true;
            this._gruppiListBox.Size = new System.Drawing.Size(155, 141);
            this._gruppiListBox.TabIndex = 6;
            // 
            // _riepilogoTableLayoutPanel
            // 
            this._riepilogoTableLayoutPanel.ColumnCount = 1;
            this._riepilogoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._riepilogoTableLayoutPanel.Controls.Add(this._riepilogoInfoTableLayoutPanel, 0, 1);
            this._riepilogoTableLayoutPanel.Controls.Add(this._topTableLayoutPanel, 0, 0);
            this._riepilogoTableLayoutPanel.Controls.Add(this._speseLabel, 0, 2);
            this._riepilogoTableLayoutPanel.Controls.Add(this._speseDataGridView, 0, 3);
            this._riepilogoTableLayoutPanel.Controls.Add(this._saldiLabel, 0, 4);
            this._riepilogoTableLayoutPanel.Controls.Add(this._saldiDataGridView, 0, 5);
            this._riepilogoTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._riepilogoTableLayoutPanel.Location = new System.Drawing.Point(170, 3);
            this._riepilogoTableLayoutPanel.Name = "_riepilogoTableLayoutPanel";
            this._riepilogoTableLayoutPanel.RowCount = 6;
            this._riepilogoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._riepilogoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this._riepilogoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._riepilogoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._riepilogoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._riepilogoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._riepilogoTableLayoutPanel.Size = new System.Drawing.Size(475, 434);
            this._riepilogoTableLayoutPanel.TabIndex = 5;
            // 
            // _riepilogoInfoTableLayoutPanel
            // 
            this._riepilogoInfoTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this._riepilogoInfoTableLayoutPanel.ColumnCount = 3;
            this._riepilogoInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._riepilogoInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._riepilogoInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._riepilogoInfoTableLayoutPanel.Controls.Add(this._bilancioTableLayoutPanel, 0, 0);
            this._riepilogoInfoTableLayoutPanel.Controls.Add(this._deviTableLayoutPanel, 1, 0);
            this._riepilogoInfoTableLayoutPanel.Controls.Add(this._dovutoTableLayoutPanel, 2, 0);
            this._riepilogoInfoTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._riepilogoInfoTableLayoutPanel.Location = new System.Drawing.Point(0, 40);
            this._riepilogoInfoTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this._riepilogoInfoTableLayoutPanel.Name = "_riepilogoInfoTableLayoutPanel";
            this._riepilogoInfoTableLayoutPanel.RowCount = 1;
            this._riepilogoInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._riepilogoInfoTableLayoutPanel.Size = new System.Drawing.Size(475, 50);
            this._riepilogoInfoTableLayoutPanel.TabIndex = 4;
            // 
            // _bilancioTableLayoutPanel
            // 
            this._bilancioTableLayoutPanel.ColumnCount = 1;
            this._bilancioTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._bilancioTableLayoutPanel.Controls.Add(this._riepilogoBilancioLabel, 0, 0);
            this._bilancioTableLayoutPanel.Controls.Add(this._bilancioImportoLabel, 0, 1);
            this._bilancioTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._bilancioTableLayoutPanel.Location = new System.Drawing.Point(1, 1);
            this._bilancioTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this._bilancioTableLayoutPanel.Name = "_bilancioTableLayoutPanel";
            this._bilancioTableLayoutPanel.RowCount = 2;
            this._bilancioTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._bilancioTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._bilancioTableLayoutPanel.Size = new System.Drawing.Size(157, 48);
            this._bilancioTableLayoutPanel.TabIndex = 0;
            // 
            // _riepilogoBilancioLabel
            // 
            this._riepilogoBilancioLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._riepilogoBilancioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._riepilogoBilancioLabel.Location = new System.Drawing.Point(3, 0);
            this._riepilogoBilancioLabel.Name = "_riepilogoBilancioLabel";
            this._riepilogoBilancioLabel.Size = new System.Drawing.Size(151, 24);
            this._riepilogoBilancioLabel.TabIndex = 0;
            this._riepilogoBilancioLabel.Text = "Bilancio totale";
            this._riepilogoBilancioLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _bilancioImportoLabel
            // 
            this._bilancioImportoLabel.AutoSize = true;
            this._bilancioImportoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._bilancioImportoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bilancioImportoLabel.Location = new System.Drawing.Point(3, 24);
            this._bilancioImportoLabel.Name = "_bilancioImportoLabel";
            this._bilancioImportoLabel.Size = new System.Drawing.Size(151, 24);
            this._bilancioImportoLabel.TabIndex = 1;
            this._bilancioImportoLabel.Text = "Soldi";
            this._bilancioImportoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _deviTableLayoutPanel
            // 
            this._deviTableLayoutPanel.ColumnCount = 1;
            this._deviTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._deviTableLayoutPanel.Controls.Add(this._riepilogoDeviLabel, 0, 0);
            this._deviTableLayoutPanel.Controls.Add(this._deviImportoLabel, 0, 1);
            this._deviTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._deviTableLayoutPanel.Location = new System.Drawing.Point(159, 1);
            this._deviTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this._deviTableLayoutPanel.Name = "_deviTableLayoutPanel";
            this._deviTableLayoutPanel.RowCount = 2;
            this._deviTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._deviTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._deviTableLayoutPanel.Size = new System.Drawing.Size(157, 48);
            this._deviTableLayoutPanel.TabIndex = 1;
            // 
            // _riepilogoDeviLabel
            // 
            this._riepilogoDeviLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._riepilogoDeviLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._riepilogoDeviLabel.Location = new System.Drawing.Point(3, 0);
            this._riepilogoDeviLabel.Name = "_riepilogoDeviLabel";
            this._riepilogoDeviLabel.Size = new System.Drawing.Size(151, 24);
            this._riepilogoDeviLabel.TabIndex = 1;
            this._riepilogoDeviLabel.Text = "Devi dare";
            this._riepilogoDeviLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _deviImportoLabel
            // 
            this._deviImportoLabel.AutoSize = true;
            this._deviImportoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._deviImportoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._deviImportoLabel.Location = new System.Drawing.Point(3, 24);
            this._deviImportoLabel.Name = "_deviImportoLabel";
            this._deviImportoLabel.Size = new System.Drawing.Size(151, 24);
            this._deviImportoLabel.TabIndex = 2;
            this._deviImportoLabel.Text = "Soldi";
            this._deviImportoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _dovutoTableLayoutPanel
            // 
            this._dovutoTableLayoutPanel.ColumnCount = 1;
            this._dovutoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._dovutoTableLayoutPanel.Controls.Add(this._riepilogoDovutoLabel, 0, 0);
            this._dovutoTableLayoutPanel.Controls.Add(this._dovutoImportoLabel, 0, 1);
            this._dovutoTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dovutoTableLayoutPanel.Location = new System.Drawing.Point(317, 1);
            this._dovutoTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this._dovutoTableLayoutPanel.Name = "_dovutoTableLayoutPanel";
            this._dovutoTableLayoutPanel.RowCount = 2;
            this._dovutoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._dovutoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._dovutoTableLayoutPanel.Size = new System.Drawing.Size(157, 48);
            this._dovutoTableLayoutPanel.TabIndex = 2;
            // 
            // _riepilogoDovutoLabel
            // 
            this._riepilogoDovutoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._riepilogoDovutoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._riepilogoDovutoLabel.Location = new System.Drawing.Point(3, 0);
            this._riepilogoDovutoLabel.Name = "_riepilogoDovutoLabel";
            this._riepilogoDovutoLabel.Size = new System.Drawing.Size(151, 24);
            this._riepilogoDovutoLabel.TabIndex = 2;
            this._riepilogoDovutoLabel.Text = "Ti è dovuto";
            this._riepilogoDovutoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _dovutoImportoLabel
            // 
            this._dovutoImportoLabel.AutoSize = true;
            this._dovutoImportoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dovutoImportoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dovutoImportoLabel.Location = new System.Drawing.Point(3, 24);
            this._dovutoImportoLabel.Name = "_dovutoImportoLabel";
            this._dovutoImportoLabel.Size = new System.Drawing.Size(151, 24);
            this._dovutoImportoLabel.TabIndex = 3;
            this._dovutoImportoLabel.Text = "Soldi";
            this._dovutoImportoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _topTableLayoutPanel
            // 
            this._topTableLayoutPanel.ColumnCount = 2;
            this._topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._topTableLayoutPanel.Controls.Add(this._toolStrip, 0, 0);
            this._topTableLayoutPanel.Controls.Add(this._pictureBox, 1, 0);
            this._topTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._topTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._topTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this._topTableLayoutPanel.Name = "_topTableLayoutPanel";
            this._topTableLayoutPanel.RowCount = 1;
            this._topTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._topTableLayoutPanel.Size = new System.Drawing.Size(475, 40);
            this._topTableLayoutPanel.TabIndex = 5;
            // 
            // _toolStrip
            // 
            this._toolStrip.AutoSize = false;
            this._toolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this._toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this._toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._utenteToolStrip,
            this._riepilogoToolStripLabel});
            this._toolStrip.Location = new System.Drawing.Point(0, 0);
            this._toolStrip.Name = "_toolStrip";
            this._toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this._toolStrip.Size = new System.Drawing.Size(435, 40);
            this._toolStrip.TabIndex = 6;
            this._toolStrip.Text = "toolStrip1";
            // 
            // _utenteToolStrip
            // 
            this._utenteToolStrip.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this._utenteToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._utenteToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._accountToolStrip,
            this._creaGruppoToolStrip,
            this._toolStripSeparator,
            this._esciToolStrip});
            this._utenteToolStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._utenteToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._utenteToolStrip.Name = "_utenteToolStrip";
            this._utenteToolStrip.Size = new System.Drawing.Size(71, 37);
            this._utenteToolStrip.Text = "Utente";
            // 
            // _accountToolStrip
            // 
            this._accountToolStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._accountToolStrip.Name = "_accountToolStrip";
            this._accountToolStrip.Size = new System.Drawing.Size(154, 22);
            this._accountToolStrip.Text = "Il tuo account";
            // 
            // _creaGruppoToolStrip
            // 
            this._creaGruppoToolStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._creaGruppoToolStrip.Name = "_creaGruppoToolStrip";
            this._creaGruppoToolStrip.Size = new System.Drawing.Size(154, 22);
            this._creaGruppoToolStrip.Text = "Crea gruppo";
            // 
            // _toolStripSeparator
            // 
            this._toolStripSeparator.Name = "_toolStripSeparator";
            this._toolStripSeparator.Size = new System.Drawing.Size(151, 6);
            // 
            // _esciToolStrip
            // 
            this._esciToolStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._esciToolStrip.Name = "_esciToolStrip";
            this._esciToolStrip.Size = new System.Drawing.Size(154, 22);
            this._esciToolStrip.Text = "Esci";
            // 
            // _riepilogoToolStripLabel
            // 
            this._riepilogoToolStripLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._riepilogoToolStripLabel.Name = "_riepilogoToolStripLabel";
            this._riepilogoToolStripLabel.Size = new System.Drawing.Size(90, 37);
            this._riepilogoToolStripLabel.Text = "Riepilogo";
            // 
            // _pictureBox
            // 
            this._pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pictureBox.Image = global::Room8.Properties.Resources._default;
            this._pictureBox.Location = new System.Drawing.Point(435, 0);
            this._pictureBox.Margin = new System.Windows.Forms.Padding(0);
            this._pictureBox.Name = "_pictureBox";
            this._pictureBox.Size = new System.Drawing.Size(40, 40);
            this._pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._pictureBox.TabIndex = 5;
            this._pictureBox.TabStop = false;
            // 
            // _speseLabel
            // 
            this._speseLabel.AutoSize = true;
            this._speseLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._speseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._speseLabel.Location = new System.Drawing.Point(3, 90);
            this._speseLabel.Name = "_speseLabel";
            this._speseLabel.Size = new System.Drawing.Size(469, 20);
            this._speseLabel.TabIndex = 7;
            this._speseLabel.Text = "Spese:";
            this._speseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _speseDataGridView
            // 
            this._speseDataGridView.AllowUserToAddRows = false;
            this._speseDataGridView.AllowUserToDeleteRows = false;
            this._speseDataGridView.AutoGenerateColumns = false;
            this._speseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._speseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descrizioneDataGridViewTextBoxColumn,
            this.importoDataGridViewTextBoxColumn,
            this.Pagante,
            this.dataDataGridViewTextBoxColumn});
            this._speseDataGridView.DataSource = this.spesaBindingSource;
            this._speseDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._speseDataGridView.Location = new System.Drawing.Point(3, 113);
            this._speseDataGridView.Name = "_speseDataGridView";
            this._speseDataGridView.ReadOnly = true;
            this._speseDataGridView.Size = new System.Drawing.Size(469, 146);
            this._speseDataGridView.TabIndex = 8;
            // 
            // spesaBindingSource
            // 
            this.spesaBindingSource.DataSource = typeof(Room8.Spesa);
            // 
            // _saldiLabel
            // 
            this._saldiLabel.AutoSize = true;
            this._saldiLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._saldiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._saldiLabel.Location = new System.Drawing.Point(3, 262);
            this._saldiLabel.Name = "_saldiLabel";
            this._saldiLabel.Size = new System.Drawing.Size(469, 20);
            this._saldiLabel.TabIndex = 9;
            this._saldiLabel.Text = "Saldi:";
            this._saldiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _saldiDataGridView
            // 
            this._saldiDataGridView.AllowUserToAddRows = false;
            this._saldiDataGridView.AllowUserToDeleteRows = false;
            this._saldiDataGridView.AutoGenerateColumns = false;
            this._saldiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._saldiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sorgente,
            this.Destinazione,
            this.importoDataGridViewTextBoxColumn1,
            this.dataDataGridViewTextBoxColumn1});
            this._saldiDataGridView.DataSource = this.saldoBindingSource;
            this._saldiDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._saldiDataGridView.Location = new System.Drawing.Point(3, 285);
            this._saldiDataGridView.Name = "_saldiDataGridView";
            this._saldiDataGridView.ReadOnly = true;
            this._saldiDataGridView.Size = new System.Drawing.Size(469, 146);
            this._saldiDataGridView.TabIndex = 10;
            // 
            // saldoBindingSource
            // 
            this.saldoBindingSource.DataSource = typeof(Room8.Saldo);
            // 
            // _menuTableLayoutPanel
            // 
            this._menuTableLayoutPanel.ColumnCount = 1;
            this._menuTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._menuTableLayoutPanel.Controls.Add(this._amiciListBox, 0, 5);
            this._menuTableLayoutPanel.Controls.Add(this._amiciMenuLabel, 0, 4);
            this._menuTableLayoutPanel.Controls.Add(this._gruppiListBox, 0, 3);
            this._menuTableLayoutPanel.Controls.Add(this._gruppiMenuLabel, 0, 2);
            this._menuTableLayoutPanel.Controls.Add(this._spesaButton, 0, 0);
            this._menuTableLayoutPanel.Controls.Add(this._saldaButton, 0, 1);
            this._menuTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._menuTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this._menuTableLayoutPanel.Name = "_menuTableLayoutPanel";
            this._menuTableLayoutPanel.RowCount = 6;
            this._menuTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.53846F));
            this._menuTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.53846F));
            this._menuTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this._menuTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.46154F));
            this._menuTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this._menuTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.46154F));
            this._menuTableLayoutPanel.Size = new System.Drawing.Size(161, 434);
            this._menuTableLayoutPanel.TabIndex = 3;
            // 
            // _spesaButton
            // 
            this._spesaButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._spesaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this._spesaButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._spesaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._spesaButton.Location = new System.Drawing.Point(19, 5);
            this._spesaButton.Name = "_spesaButton";
            this._spesaButton.Size = new System.Drawing.Size(123, 33);
            this._spesaButton.TabIndex = 5;
            this._spesaButton.Text = "Aggiungi spesa";
            this._spesaButton.UseVisualStyleBackColor = false;
            // 
            // _saldaButton
            // 
            this._saldaButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._saldaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._saldaButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._saldaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._saldaButton.Location = new System.Drawing.Point(19, 49);
            this._saldaButton.Name = "_saldaButton";
            this._saldaButton.Size = new System.Drawing.Size(123, 33);
            this._saldaButton.TabIndex = 10;
            this._saldaButton.Text = "Salda";
            this._saldaButton.UseVisualStyleBackColor = false;
            // 
            // _formTableLayoutPanel
            // 
            this._formTableLayoutPanel.ColumnCount = 2;
            this._formTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.87904F));
            this._formTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.12096F));
            this._formTableLayoutPanel.Controls.Add(this._riepilogoTableLayoutPanel, 1, 0);
            this._formTableLayoutPanel.Controls.Add(this._menuTableLayoutPanel, 0, 0);
            this._formTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._formTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._formTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this._formTableLayoutPanel.Name = "_formTableLayoutPanel";
            this._formTableLayoutPanel.RowCount = 1;
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._formTableLayoutPanel.Size = new System.Drawing.Size(648, 440);
            this._formTableLayoutPanel.TabIndex = 4;
            // 
            // descrizioneDataGridViewTextBoxColumn
            // 
            this.descrizioneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descrizioneDataGridViewTextBoxColumn.DataPropertyName = "Descrizione";
            this.descrizioneDataGridViewTextBoxColumn.HeaderText = "Descrizione";
            this.descrizioneDataGridViewTextBoxColumn.Name = "descrizioneDataGridViewTextBoxColumn";
            this.descrizioneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // importoDataGridViewTextBoxColumn
            // 
            this.importoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.importoDataGridViewTextBoxColumn.DataPropertyName = "Importo";
            this.importoDataGridViewTextBoxColumn.HeaderText = "Importo";
			this.importoDataGridViewTextBoxColumn.DefaultCellStyle.Format = "c2";
			this.importoDataGridViewTextBoxColumn.DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("it-IT");
            this.importoDataGridViewTextBoxColumn.Name = "importoDataGridViewTextBoxColumn";
            this.importoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Pagante
            // 
            this.Pagante.DataPropertyName = "NomePagante";
            this.Pagante.HeaderText = "Pagante";
            this.Pagante.Name = "Pagante";
            this.Pagante.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Sorgente
            // 
            this.Sorgente.DataPropertyName = "NomeSorgente";
            this.Sorgente.HeaderText = "Sorgente";
            this.Sorgente.Name = "Sorgente";
            this.Sorgente.ReadOnly = true;
            // 
            // Destinazione
            // 
            this.Destinazione.DataPropertyName = "NomeDestinazione";
            this.Destinazione.HeaderText = "Destinazione";
            this.Destinazione.Name = "Destinazione";
            this.Destinazione.ReadOnly = true;
            // 
            // importoDataGridViewTextBoxColumn1
            // 
            this.importoDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.importoDataGridViewTextBoxColumn1.DataPropertyName = "Importo";
            this.importoDataGridViewTextBoxColumn1.HeaderText = "Importo";
            this.importoDataGridViewTextBoxColumn1.Name = "importoDataGridViewTextBoxColumn1";
			this.importoDataGridViewTextBoxColumn1.DefaultCellStyle.Format = "c2";
			this.importoDataGridViewTextBoxColumn1.DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("it-IT");
            this.importoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn1
            // 
            this.dataDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataDataGridViewTextBoxColumn1.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn1.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn1.Name = "dataDataGridViewTextBoxColumn1";
            this.dataDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 462);
            this.Controls.Add(this._formTableLayoutPanel);
            this.Controls.Add(this._mainStatusStrip);
            this.MinimumSize = new System.Drawing.Size(664, 500);
            this.Name = "MainForm";
            this.Text = "Room8 - Riepilogo";
            this._riepilogoTableLayoutPanel.ResumeLayout(false);
            this._riepilogoTableLayoutPanel.PerformLayout();
            this._riepilogoInfoTableLayoutPanel.ResumeLayout(false);
            this._bilancioTableLayoutPanel.ResumeLayout(false);
            this._bilancioTableLayoutPanel.PerformLayout();
            this._deviTableLayoutPanel.ResumeLayout(false);
            this._deviTableLayoutPanel.PerformLayout();
            this._dovutoTableLayoutPanel.ResumeLayout(false);
            this._dovutoTableLayoutPanel.PerformLayout();
            this._topTableLayoutPanel.ResumeLayout(false);
            this._toolStrip.ResumeLayout(false);
            this._toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._speseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spesaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._saldiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saldoBindingSource)).EndInit();
            this._menuTableLayoutPanel.ResumeLayout(false);
            this._menuTableLayoutPanel.PerformLayout();
            this._formTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip _mainStatusStrip;
        private System.Windows.Forms.ListBox _gruppiListBox;
        private System.Windows.Forms.ListBox _amiciListBox;
        private System.Windows.Forms.Label _amiciMenuLabel;
        private System.Windows.Forms.Label _gruppiMenuLabel;
        private System.Windows.Forms.TableLayoutPanel _riepilogoInfoTableLayoutPanel;
        private System.Windows.Forms.Label _riepilogoBilancioLabel;
        private System.Windows.Forms.Label _riepilogoDeviLabel;
        private System.Windows.Forms.Label _riepilogoDovutoLabel;
        private System.Windows.Forms.TableLayoutPanel _riepilogoTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel _bilancioTableLayoutPanel;
        private System.Windows.Forms.Label _bilancioImportoLabel;
        private System.Windows.Forms.TableLayoutPanel _deviTableLayoutPanel;
        private System.Windows.Forms.Label _deviImportoLabel;
        private System.Windows.Forms.TableLayoutPanel _dovutoTableLayoutPanel;
        private System.Windows.Forms.Label _dovutoImportoLabel;
        private System.Windows.Forms.TableLayoutPanel _menuTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel _formTableLayoutPanel;
		private System.Windows.Forms.Button _spesaButton;
        private System.Windows.Forms.Button _saldaButton;
        private System.Windows.Forms.PictureBox _pictureBox;
        private System.Windows.Forms.TableLayoutPanel _topTableLayoutPanel;
        private System.Windows.Forms.ToolStrip _toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton _utenteToolStrip;
        private System.Windows.Forms.ToolStripMenuItem _accountToolStrip;
        private System.Windows.Forms.ToolStripMenuItem _creaGruppoToolStrip;
        private System.Windows.Forms.ToolStripMenuItem _esciToolStrip;
		private System.Windows.Forms.ToolStripLabel _riepilogoToolStripLabel;
        private System.Windows.Forms.ToolStripSeparator _toolStripSeparator;
        private System.Windows.Forms.Label _speseLabel;
        private System.Windows.Forms.DataGridView _speseDataGridView;
        private System.Windows.Forms.BindingSource spesaBindingSource;
        private System.Windows.Forms.Label _saldiLabel;
        private System.Windows.Forms.DataGridView _saldiDataGridView;
        private System.Windows.Forms.BindingSource saldoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn paganteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sorgenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinazioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrizioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagante;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sorgente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destinazione;
        private System.Windows.Forms.DataGridViewTextBoxColumn importoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn1;
    }
}

