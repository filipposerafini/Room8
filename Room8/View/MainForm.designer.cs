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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this._amiciListBox = new System.Windows.Forms.ListBox();
            this._amiciMenuLabel = new System.Windows.Forms.Label();
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
            this._descrizioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._importoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._pagante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._spesaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._saldiLabel = new System.Windows.Forms.Label();
            this._saldiDataGridView = new System.Windows.Forms.DataGridView();
            this._sorgente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._destinazione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._importoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dataDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._saldoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._menuTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._spesaButton = new System.Windows.Forms.Button();
            this._saldaButton = new System.Windows.Forms.Button();
            this._visualizzaAmico = new System.Windows.Forms.Button();
            this._formTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._amiciTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._gruppiTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._modificaPanel = new System.Windows.Forms.Panel();
            this._visualizzaGruppoButton = new System.Windows.Forms.Button();
            this._modificaGruppoButton = new System.Windows.Forms.Button();
            this._gruppiPanel = new System.Windows.Forms.Panel();
            this._creaGruppoLinkLabel = new System.Windows.Forms.LinkLabel();
            this._gruppiMenuLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this._modificaSpesaButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this._modificaSaldoButton = new System.Windows.Forms.Button();
            this._riepilogoTableLayoutPanel.SuspendLayout();
            this._riepilogoInfoTableLayoutPanel.SuspendLayout();
            this._bilancioTableLayoutPanel.SuspendLayout();
            this._deviTableLayoutPanel.SuspendLayout();
            this._dovutoTableLayoutPanel.SuspendLayout();
            this._topTableLayoutPanel.SuspendLayout();
            this._toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._speseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._spesaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._saldiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._saldoBindingSource)).BeginInit();
            this._menuTableLayoutPanel.SuspendLayout();
            this._formTableLayoutPanel.SuspendLayout();
            this._amiciTableLayoutPanel.SuspendLayout();
            this._gruppiTableLayoutPanel.SuspendLayout();
            this._modificaPanel.SuspendLayout();
            this._gruppiPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _amiciListBox
            // 
            this._amiciListBox.BackColor = System.Drawing.Color.White;
            this._amiciListBox.DisplayMember = "Mail";
            this._amiciListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._amiciListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._amiciListBox.FormattingEnabled = true;
            this._amiciListBox.ItemHeight = 15;
            this._amiciListBox.Location = new System.Drawing.Point(3, 3);
            this._amiciListBox.Name = "_amiciListBox";
            this._amiciListBox.ScrollAlwaysVisible = true;
            this._amiciListBox.Size = new System.Drawing.Size(182, 112);
            this._amiciListBox.TabIndex = 9;
            // 
            // _amiciMenuLabel
            // 
            this._amiciMenuLabel.AutoSize = true;
            this._amiciMenuLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._amiciMenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._amiciMenuLabel.Location = new System.Drawing.Point(3, 282);
            this._amiciMenuLabel.Name = "_amiciMenuLabel";
            this._amiciMenuLabel.Size = new System.Drawing.Size(188, 27);
            this._amiciMenuLabel.TabIndex = 8;
            this._amiciMenuLabel.Text = "Amici:";
            this._amiciMenuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _gruppiListBox
            // 
            this._gruppiListBox.BackColor = System.Drawing.Color.White;
            this._gruppiListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gruppiListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._gruppiListBox.FormattingEnabled = true;
            this._gruppiListBox.ItemHeight = 15;
            this._gruppiListBox.Location = new System.Drawing.Point(3, 3);
            this._gruppiListBox.Name = "_gruppiListBox";
            this._gruppiListBox.ScrollAlwaysVisible = true;
            this._gruppiListBox.Size = new System.Drawing.Size(182, 111);
            this._gruppiListBox.TabIndex = 6;
            // 
            // _riepilogoTableLayoutPanel
            // 
            this._riepilogoTableLayoutPanel.ColumnCount = 1;
            this._riepilogoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._riepilogoTableLayoutPanel.Controls.Add(this._riepilogoInfoTableLayoutPanel, 0, 1);
            this._riepilogoTableLayoutPanel.Controls.Add(this._topTableLayoutPanel, 0, 0);
            this._riepilogoTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._riepilogoTableLayoutPanel.Location = new System.Drawing.Point(197, 3);
            this._riepilogoTableLayoutPanel.Name = "_riepilogoTableLayoutPanel";
            this._riepilogoTableLayoutPanel.RowCount = 2;
            this._riepilogoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._riepilogoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this._riepilogoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._riepilogoTableLayoutPanel.Size = new System.Drawing.Size(448, 96);
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
            this._riepilogoInfoTableLayoutPanel.Size = new System.Drawing.Size(448, 56);
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
            this._bilancioTableLayoutPanel.Size = new System.Drawing.Size(148, 54);
            this._bilancioTableLayoutPanel.TabIndex = 0;
            // 
            // _riepilogoBilancioLabel
            // 
            this._riepilogoBilancioLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._riepilogoBilancioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._riepilogoBilancioLabel.Location = new System.Drawing.Point(3, 0);
            this._riepilogoBilancioLabel.Name = "_riepilogoBilancioLabel";
            this._riepilogoBilancioLabel.Size = new System.Drawing.Size(142, 27);
            this._riepilogoBilancioLabel.TabIndex = 0;
            this._riepilogoBilancioLabel.Text = "Bilancio totale";
            this._riepilogoBilancioLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _bilancioImportoLabel
            // 
            this._bilancioImportoLabel.AutoSize = true;
            this._bilancioImportoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._bilancioImportoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bilancioImportoLabel.Location = new System.Drawing.Point(3, 27);
            this._bilancioImportoLabel.Name = "_bilancioImportoLabel";
            this._bilancioImportoLabel.Size = new System.Drawing.Size(142, 27);
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
            this._deviTableLayoutPanel.Location = new System.Drawing.Point(150, 1);
            this._deviTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this._deviTableLayoutPanel.Name = "_deviTableLayoutPanel";
            this._deviTableLayoutPanel.RowCount = 2;
            this._deviTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._deviTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._deviTableLayoutPanel.Size = new System.Drawing.Size(148, 54);
            this._deviTableLayoutPanel.TabIndex = 1;
            // 
            // _riepilogoDeviLabel
            // 
            this._riepilogoDeviLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._riepilogoDeviLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._riepilogoDeviLabel.Location = new System.Drawing.Point(3, 0);
            this._riepilogoDeviLabel.Name = "_riepilogoDeviLabel";
            this._riepilogoDeviLabel.Size = new System.Drawing.Size(142, 27);
            this._riepilogoDeviLabel.TabIndex = 1;
            this._riepilogoDeviLabel.Text = "Devi dare";
            this._riepilogoDeviLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _deviImportoLabel
            // 
            this._deviImportoLabel.AutoSize = true;
            this._deviImportoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._deviImportoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._deviImportoLabel.ForeColor = System.Drawing.Color.Red;
            this._deviImportoLabel.Location = new System.Drawing.Point(3, 27);
            this._deviImportoLabel.Name = "_deviImportoLabel";
            this._deviImportoLabel.Size = new System.Drawing.Size(142, 27);
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
            this._dovutoTableLayoutPanel.Location = new System.Drawing.Point(299, 1);
            this._dovutoTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this._dovutoTableLayoutPanel.Name = "_dovutoTableLayoutPanel";
            this._dovutoTableLayoutPanel.RowCount = 2;
            this._dovutoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._dovutoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._dovutoTableLayoutPanel.Size = new System.Drawing.Size(148, 54);
            this._dovutoTableLayoutPanel.TabIndex = 2;
            // 
            // _riepilogoDovutoLabel
            // 
            this._riepilogoDovutoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._riepilogoDovutoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._riepilogoDovutoLabel.Location = new System.Drawing.Point(3, 0);
            this._riepilogoDovutoLabel.Name = "_riepilogoDovutoLabel";
            this._riepilogoDovutoLabel.Size = new System.Drawing.Size(142, 27);
            this._riepilogoDovutoLabel.TabIndex = 2;
            this._riepilogoDovutoLabel.Text = "Ti è dovuto";
            this._riepilogoDovutoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _dovutoImportoLabel
            // 
            this._dovutoImportoLabel.AutoSize = true;
            this._dovutoImportoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dovutoImportoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dovutoImportoLabel.ForeColor = System.Drawing.Color.Green;
            this._dovutoImportoLabel.Location = new System.Drawing.Point(3, 27);
            this._dovutoImportoLabel.Name = "_dovutoImportoLabel";
            this._dovutoImportoLabel.Size = new System.Drawing.Size(142, 27);
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
            this._topTableLayoutPanel.Size = new System.Drawing.Size(448, 40);
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
            this._toolStrip.Size = new System.Drawing.Size(408, 40);
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
            this._pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pictureBox.Image = global::Room8.Properties.Resources._default;
            this._pictureBox.Location = new System.Drawing.Point(408, 0);
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
            this._speseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._speseLabel.Location = new System.Drawing.Point(6, 5);
            this._speseLabel.Name = "_speseLabel";
            this._speseLabel.Size = new System.Drawing.Size(59, 20);
            this._speseLabel.TabIndex = 7;
            this._speseLabel.Text = "Spese:";
            this._speseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _speseDataGridView
            // 
            this._speseDataGridView.AllowUserToAddRows = false;
            this._speseDataGridView.AllowUserToDeleteRows = false;
            this._speseDataGridView.AutoGenerateColumns = false;
            this._speseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._speseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._descrizioneDataGridViewTextBoxColumn,
            this._importoDataGridViewTextBoxColumn,
            this._pagante,
            this._dataDataGridViewTextBoxColumn});
            this._speseDataGridView.DataSource = this._spesaBindingSource;
            this._speseDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._speseDataGridView.Location = new System.Drawing.Point(197, 132);
            this._speseDataGridView.Name = "_speseDataGridView";
            this._speseDataGridView.ReadOnly = true;
            this._speseDataGridView.Size = new System.Drawing.Size(448, 147);
            this._speseDataGridView.TabIndex = 8;
            // 
            // _descrizioneDataGridViewTextBoxColumn
            // 
            this._descrizioneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._descrizioneDataGridViewTextBoxColumn.DataPropertyName = "Descrizione";
            this._descrizioneDataGridViewTextBoxColumn.HeaderText = "Descrizione";
            this._descrizioneDataGridViewTextBoxColumn.Name = "_descrizioneDataGridViewTextBoxColumn";
            this._descrizioneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // _importoDataGridViewTextBoxColumn
            // 
            this._importoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._importoDataGridViewTextBoxColumn.DataPropertyName = "Importo";
            dataGridViewCellStyle1.Format = "c2";
            dataGridViewCellStyle1.FormatProvider = new System.Globalization.CultureInfo("it-IT");
            this._importoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this._importoDataGridViewTextBoxColumn.HeaderText = "Importo";
            this._importoDataGridViewTextBoxColumn.Name = "_importoDataGridViewTextBoxColumn";
            this._importoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // _pagante
            // 
            this._pagante.DataPropertyName = "NomePagante";
            this._pagante.HeaderText = "Pagante";
            this._pagante.Name = "_pagante";
            this._pagante.ReadOnly = true;
            // 
            // _dataDataGridViewTextBoxColumn
            // 
            this._dataDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this._dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this._dataDataGridViewTextBoxColumn.Name = "_dataDataGridViewTextBoxColumn";
            this._dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // _spesaBindingSource
            // 
            this._spesaBindingSource.DataSource = typeof(Room8.Spesa);
            // 
            // _saldiLabel
            // 
            this._saldiLabel.AutoSize = true;
            this._saldiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._saldiLabel.Location = new System.Drawing.Point(6, 4);
            this._saldiLabel.Name = "_saldiLabel";
            this._saldiLabel.Size = new System.Drawing.Size(48, 20);
            this._saldiLabel.TabIndex = 9;
            this._saldiLabel.Text = "Saldi:";
            this._saldiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _saldiDataGridView
            // 
            this._saldiDataGridView.AllowUserToAddRows = false;
            this._saldiDataGridView.AllowUserToDeleteRows = false;
            this._saldiDataGridView.AutoGenerateColumns = false;
            this._saldiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._saldiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._sorgente,
            this._destinazione,
            this._importoDataGridViewTextBoxColumn1,
            this._dataDataGridViewTextBoxColumn1});
            this._saldiDataGridView.DataSource = this._saldoBindingSource;
            this._saldiDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._saldiDataGridView.Location = new System.Drawing.Point(197, 312);
            this._saldiDataGridView.Name = "_saldiDataGridView";
            this._saldiDataGridView.ReadOnly = true;
            this._saldiDataGridView.Size = new System.Drawing.Size(448, 147);
            this._saldiDataGridView.TabIndex = 10;
            // 
            // _sorgente
            // 
            this._sorgente.DataPropertyName = "NomeSorgente";
            this._sorgente.HeaderText = "Sorgente";
            this._sorgente.Name = "_sorgente";
            this._sorgente.ReadOnly = true;
            // 
            // _destinazione
            // 
            this._destinazione.DataPropertyName = "NomeDestinazione";
            this._destinazione.HeaderText = "Destinazione";
            this._destinazione.Name = "_destinazione";
            this._destinazione.ReadOnly = true;
            // 
            // _importoDataGridViewTextBoxColumn1
            // 
            this._importoDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._importoDataGridViewTextBoxColumn1.DataPropertyName = "Importo";
            dataGridViewCellStyle2.Format = "c2";
            dataGridViewCellStyle2.FormatProvider = new System.Globalization.CultureInfo("it-IT");
            this._importoDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this._importoDataGridViewTextBoxColumn1.HeaderText = "Importo";
            this._importoDataGridViewTextBoxColumn1.Name = "_importoDataGridViewTextBoxColumn1";
            this._importoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // _dataDataGridViewTextBoxColumn1
            // 
            this._dataDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._dataDataGridViewTextBoxColumn1.DataPropertyName = "Data";
            this._dataDataGridViewTextBoxColumn1.HeaderText = "Data";
            this._dataDataGridViewTextBoxColumn1.Name = "_dataDataGridViewTextBoxColumn1";
            this._dataDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // _saldoBindingSource
            // 
            this._saldoBindingSource.DataSource = typeof(Room8.Saldo);
            // 
            // _menuTableLayoutPanel
            // 
            this._menuTableLayoutPanel.ColumnCount = 1;
            this._menuTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._menuTableLayoutPanel.Controls.Add(this._spesaButton, 0, 0);
            this._menuTableLayoutPanel.Controls.Add(this._saldaButton, 0, 1);
            this._menuTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._menuTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this._menuTableLayoutPanel.Name = "_menuTableLayoutPanel";
            this._menuTableLayoutPanel.RowCount = 2;
            this._menuTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._menuTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._menuTableLayoutPanel.Size = new System.Drawing.Size(188, 96);
            this._menuTableLayoutPanel.TabIndex = 3;
            // 
            // _spesaButton
            // 
            this._spesaButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._spesaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this._spesaButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._spesaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._spesaButton.Location = new System.Drawing.Point(32, 8);
            this._spesaButton.Name = "_spesaButton";
            this._spesaButton.Size = new System.Drawing.Size(123, 31);
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
            this._saldaButton.Location = new System.Drawing.Point(32, 56);
            this._saldaButton.Name = "_saldaButton";
            this._saldaButton.Size = new System.Drawing.Size(123, 31);
            this._saldaButton.TabIndex = 10;
            this._saldaButton.Text = "Salda";
            this._saldaButton.UseVisualStyleBackColor = false;
            // 
            // _visualizzaAmico
            // 
            this._visualizzaAmico.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._visualizzaAmico.AutoSize = true;
            this._visualizzaAmico.Location = new System.Drawing.Point(3, 121);
            this._visualizzaAmico.Name = "_visualizzaAmico";
            this._visualizzaAmico.Size = new System.Drawing.Size(99, 23);
            this._visualizzaAmico.TabIndex = 12;
            this._visualizzaAmico.Text = "Mostra amico";
            this._visualizzaAmico.UseVisualStyleBackColor = true;
            // 
            // _formTableLayoutPanel
            // 
            this._formTableLayoutPanel.ColumnCount = 2;
            this._formTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._formTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this._formTableLayoutPanel.Controls.Add(this._riepilogoTableLayoutPanel, 1, 0);
            this._formTableLayoutPanel.Controls.Add(this._menuTableLayoutPanel, 0, 0);
            this._formTableLayoutPanel.Controls.Add(this._saldiDataGridView, 1, 4);
            this._formTableLayoutPanel.Controls.Add(this._amiciMenuLabel, 0, 3);
            this._formTableLayoutPanel.Controls.Add(this._speseDataGridView, 1, 2);
            this._formTableLayoutPanel.Controls.Add(this._amiciTableLayoutPanel, 0, 4);
            this._formTableLayoutPanel.Controls.Add(this._gruppiTableLayoutPanel, 0, 2);
            this._formTableLayoutPanel.Controls.Add(this._gruppiPanel, 0, 1);
            this._formTableLayoutPanel.Controls.Add(this.panel1, 1, 1);
            this._formTableLayoutPanel.Controls.Add(this.panel2, 1, 3);
            this._formTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._formTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._formTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this._formTableLayoutPanel.Name = "_formTableLayoutPanel";
            this._formTableLayoutPanel.RowCount = 5;
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._formTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this._formTableLayoutPanel.Size = new System.Drawing.Size(648, 462);
            this._formTableLayoutPanel.TabIndex = 4;
            // 
            // _amiciTableLayoutPanel
            // 
            this._amiciTableLayoutPanel.ColumnCount = 1;
            this._amiciTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._amiciTableLayoutPanel.Controls.Add(this._visualizzaAmico, 0, 1);
            this._amiciTableLayoutPanel.Controls.Add(this._amiciListBox, 0, 0);
            this._amiciTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._amiciTableLayoutPanel.Location = new System.Drawing.Point(3, 312);
            this._amiciTableLayoutPanel.Name = "_amiciTableLayoutPanel";
            this._amiciTableLayoutPanel.RowCount = 2;
            this._amiciTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._amiciTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._amiciTableLayoutPanel.Size = new System.Drawing.Size(188, 147);
            this._amiciTableLayoutPanel.TabIndex = 11;
            // 
            // _gruppiTableLayoutPanel
            // 
            this._gruppiTableLayoutPanel.ColumnCount = 1;
            this._gruppiTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._gruppiTableLayoutPanel.Controls.Add(this._gruppiListBox, 0, 0);
            this._gruppiTableLayoutPanel.Controls.Add(this._modificaPanel, 0, 1);
            this._gruppiTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gruppiTableLayoutPanel.Location = new System.Drawing.Point(3, 132);
            this._gruppiTableLayoutPanel.Name = "_gruppiTableLayoutPanel";
            this._gruppiTableLayoutPanel.RowCount = 2;
            this._gruppiTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._gruppiTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._gruppiTableLayoutPanel.Size = new System.Drawing.Size(188, 147);
            this._gruppiTableLayoutPanel.TabIndex = 12;
            // 
            // _modificaPanel
            // 
            this._modificaPanel.Controls.Add(this._visualizzaGruppoButton);
            this._modificaPanel.Controls.Add(this._modificaGruppoButton);
            this._modificaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._modificaPanel.Location = new System.Drawing.Point(3, 120);
            this._modificaPanel.Name = "_modificaPanel";
            this._modificaPanel.Size = new System.Drawing.Size(182, 24);
            this._modificaPanel.TabIndex = 11;
            // 
            // _visualizzaGruppoButton
            // 
            this._visualizzaGruppoButton.AutoSize = true;
            this._visualizzaGruppoButton.Location = new System.Drawing.Point(1, 0);
            this._visualizzaGruppoButton.Name = "_visualizzaGruppoButton";
            this._visualizzaGruppoButton.Size = new System.Drawing.Size(85, 23);
            this._visualizzaGruppoButton.TabIndex = 1;
            this._visualizzaGruppoButton.Text = "Mostra gruppo";
            this._visualizzaGruppoButton.UseVisualStyleBackColor = true;
            // 
            // _modificaGruppoButton
            // 
            this._modificaGruppoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._modificaGruppoButton.AutoSize = true;
            this._modificaGruppoButton.Location = new System.Drawing.Point(89, 0);
            this._modificaGruppoButton.Name = "_modificaGruppoButton";
            this._modificaGruppoButton.Size = new System.Drawing.Size(93, 23);
            this._modificaGruppoButton.TabIndex = 0;
            this._modificaGruppoButton.Text = "Modifica gruppo";
            this._modificaGruppoButton.UseVisualStyleBackColor = true;
            // 
            // _gruppiPanel
            // 
            this._gruppiPanel.Controls.Add(this._creaGruppoLinkLabel);
            this._gruppiPanel.Controls.Add(this._gruppiMenuLabel);
            this._gruppiPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gruppiPanel.Location = new System.Drawing.Point(0, 102);
            this._gruppiPanel.Margin = new System.Windows.Forms.Padding(0);
            this._gruppiPanel.Name = "_gruppiPanel";
            this._gruppiPanel.Size = new System.Drawing.Size(194, 27);
            this._gruppiPanel.TabIndex = 13;
            // 
            // _creaGruppoLinkLabel
            // 
            this._creaGruppoLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._creaGruppoLinkLabel.AutoSize = true;
            this._creaGruppoLinkLabel.Location = new System.Drawing.Point(130, 5);
            this._creaGruppoLinkLabel.Name = "_creaGruppoLinkLabel";
            this._creaGruppoLinkLabel.Size = new System.Drawing.Size(64, 13);
            this._creaGruppoLinkLabel.TabIndex = 9;
            this._creaGruppoLinkLabel.TabStop = true;
            this._creaGruppoLinkLabel.Text = "crea gruppo";
            this._creaGruppoLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._creaGruppoLinkLabel.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // _gruppiMenuLabel
            // 
            this._gruppiMenuLabel.AutoSize = true;
            this._gruppiMenuLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this._gruppiMenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._gruppiMenuLabel.Location = new System.Drawing.Point(0, 0);
            this._gruppiMenuLabel.Name = "_gruppiMenuLabel";
            this._gruppiMenuLabel.Size = new System.Drawing.Size(61, 20);
            this._gruppiMenuLabel.TabIndex = 8;
            this._gruppiMenuLabel.Text = "Gruppi:";
            this._gruppiMenuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._modificaSpesaButton);
            this.panel1.Controls.Add(this._speseLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(194, 102);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 27);
            this.panel1.TabIndex = 14;
            // 
            // _modificaSpesaButton
            // 
            this._modificaSpesaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._modificaSpesaButton.Location = new System.Drawing.Point(356, 2);
            this._modificaSpesaButton.Name = "_modificaSpesaButton";
            this._modificaSpesaButton.Size = new System.Drawing.Size(86, 23);
            this._modificaSpesaButton.TabIndex = 8;
            this._modificaSpesaButton.Text = "Modifica spesa";
            this._modificaSpesaButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._modificaSaldoButton);
            this.panel2.Controls.Add(this._saldiLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(194, 282);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 27);
            this.panel2.TabIndex = 15;
            // 
            // _modificaSaldoButton
            // 
            this._modificaSaldoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._modificaSaldoButton.Location = new System.Drawing.Point(356, 1);
            this._modificaSaldoButton.Name = "_modificaSaldoButton";
            this._modificaSaldoButton.Size = new System.Drawing.Size(86, 23);
            this._modificaSaldoButton.TabIndex = 10;
            this._modificaSaldoButton.Text = "Modifica saldo";
            this._modificaSaldoButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 462);
            this.Controls.Add(this._formTableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(664, 500);
            this.Name = "MainForm";
            this.Text = "Room8 - Riepilogo";
            this._riepilogoTableLayoutPanel.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this._spesaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._saldiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._saldoBindingSource)).EndInit();
            this._menuTableLayoutPanel.ResumeLayout(false);
            this._formTableLayoutPanel.ResumeLayout(false);
            this._formTableLayoutPanel.PerformLayout();
            this._amiciTableLayoutPanel.ResumeLayout(false);
            this._amiciTableLayoutPanel.PerformLayout();
            this._gruppiTableLayoutPanel.ResumeLayout(false);
            this._modificaPanel.ResumeLayout(false);
            this._modificaPanel.PerformLayout();
            this._gruppiPanel.ResumeLayout(false);
            this._gruppiPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox _gruppiListBox;
        private System.Windows.Forms.ListBox _amiciListBox;
        private System.Windows.Forms.Label _amiciMenuLabel;
        private System.Windows.Forms.TableLayoutPanel _riepilogoTableLayoutPanel;
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
        private System.Windows.Forms.BindingSource _spesaBindingSource;
        private System.Windows.Forms.Label _saldiLabel;
        private System.Windows.Forms.DataGridView _saldiDataGridView;
        private System.Windows.Forms.BindingSource _saldoBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn _descrizioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _importoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _pagante;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _sorgente;
        private System.Windows.Forms.DataGridViewTextBoxColumn _destinazione;
        private System.Windows.Forms.DataGridViewTextBoxColumn _importoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button _visualizzaAmico;
        private System.Windows.Forms.TableLayoutPanel _riepilogoInfoTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel _bilancioTableLayoutPanel;
        private System.Windows.Forms.Label _riepilogoBilancioLabel;
        private System.Windows.Forms.Label _bilancioImportoLabel;
        private System.Windows.Forms.TableLayoutPanel _deviTableLayoutPanel;
        private System.Windows.Forms.Label _riepilogoDeviLabel;
        private System.Windows.Forms.Label _deviImportoLabel;
        private System.Windows.Forms.TableLayoutPanel _dovutoTableLayoutPanel;
        private System.Windows.Forms.Label _riepilogoDovutoLabel;
        private System.Windows.Forms.Label _dovutoImportoLabel;
        private System.Windows.Forms.TableLayoutPanel _amiciTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel _gruppiTableLayoutPanel;
        private System.Windows.Forms.Panel _modificaPanel;
        private System.Windows.Forms.Button _visualizzaGruppoButton;
        private System.Windows.Forms.Button _modificaGruppoButton;
        private System.Windows.Forms.Panel _gruppiPanel;
        private System.Windows.Forms.LinkLabel _creaGruppoLinkLabel;
        private System.Windows.Forms.Label _gruppiMenuLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button _modificaSpesaButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button _modificaSaldoButton;
    }
}

