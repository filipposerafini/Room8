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
            this._mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this._mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this._utenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._creaGruppoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._saldaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._aggiungiSpesaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._creaGruppoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this._linkLabelCrea = new System.Windows.Forms.LinkLabel();
            this._amiciListBox = new System.Windows.Forms.ListBox();
            this._amiciMenuLabel = new System.Windows.Forms.Label();
            this._gruppiMenuLabel = new System.Windows.Forms.Label();
            this._gruppiListBox = new System.Windows.Forms.ListBox();
            this._speseButton = new System.Windows.Forms.Button();
            this._attivitaButton = new System.Windows.Forms.Button();
            this._riepilogoButton = new System.Windows.Forms.Button();
            this._mainTabControl = new System.Windows.Forms.TabControl();
            this._riepilogoTabPage = new System.Windows.Forms.TabPage();
            this._riepilogoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._riepilogoBilancioLabel = new System.Windows.Forms.Label();
            this._riepilogoDeviLabel = new System.Windows.Forms.Label();
            this._riepilogoDovutoLabel = new System.Windows.Forms.Label();
            this._riepilogoTabControl = new System.Windows.Forms.TabControl();
            this._riepilogoListaTabPage = new System.Windows.Forms.TabPage();
            this._riepilogoGraficoTabPage = new System.Windows.Forms.TabPage();
            this._riepilogoTitoloLabel = new System.Windows.Forms.Label();
            this._attivitaTabPage = new System.Windows.Forms.TabPage();
            this._attivitaTitoloLabel = new System.Windows.Forms.Label();
            this._speseTabPage = new System.Windows.Forms.TabPage();
            this._speseSplitContainer = new System.Windows.Forms.SplitContainer();
            this._speseTabControl = new System.Windows.Forms.TabControl();
            this._speseBilancioTabPage = new System.Windows.Forms.TabPage();
            this._speseBilancioLabel = new System.Windows.Forms.Label();
            this._speseStatisticheTabPage = new System.Windows.Forms.TabPage();
            this._labelSpeseStatistiche = new System.Windows.Forms.Label();
            this._speseTitoloLabel = new System.Windows.Forms.Label();
            this._gruppoTabPage = new System.Windows.Forms.TabPage();
            this._gruppoTitoloLabel = new System.Windows.Forms.Label();
            this._amicoTabPage = new System.Windows.Forms.TabPage();
            this._amicoTitoloLabel = new System.Windows.Forms.Label();
            this._mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._mainSplitContainer)).BeginInit();
            this._mainSplitContainer.Panel1.SuspendLayout();
            this._mainSplitContainer.Panel2.SuspendLayout();
            this._mainSplitContainer.SuspendLayout();
            this._mainTabControl.SuspendLayout();
            this._riepilogoTabPage.SuspendLayout();
            this._riepilogoTableLayoutPanel.SuspendLayout();
            this._riepilogoTabControl.SuspendLayout();
            this._attivitaTabPage.SuspendLayout();
            this._speseTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._speseSplitContainer)).BeginInit();
            this._speseSplitContainer.Panel2.SuspendLayout();
            this._speseSplitContainer.SuspendLayout();
            this._speseTabControl.SuspendLayout();
            this._speseBilancioTabPage.SuspendLayout();
            this._speseStatisticheTabPage.SuspendLayout();
            this._gruppoTabPage.SuspendLayout();
            this._amicoTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mainStatusStrip
            // 
            this._mainStatusStrip.Location = new System.Drawing.Point(0, 474);
            this._mainStatusStrip.Name = "_mainStatusStrip";
            this._mainStatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this._mainStatusStrip.Size = new System.Drawing.Size(770, 22);
            this._mainStatusStrip.TabIndex = 0;
            this._mainStatusStrip.Text = "statusStrip1";
            // 
            // _mainMenuStrip
            // 
            this._mainMenuStrip.AutoSize = false;
            this._mainMenuStrip.GripMargin = new System.Windows.Forms.Padding(2);
            this._mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._utenteToolStripMenuItem,
            this._saldaToolStripButton,
            this._aggiungiSpesaToolStripButton,
            this._creaGruppoToolStripButton});
            this._mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this._mainMenuStrip.Name = "_mainMenuStrip";
            this._mainMenuStrip.Size = new System.Drawing.Size(770, 40);
            this._mainMenuStrip.TabIndex = 1;
            this._mainMenuStrip.Text = "menuStrip1";
            // 
            // _utenteToolStripMenuItem
            // 
            this._utenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._accountToolStripMenuItem,
            this._creaGruppoToolStripMenuItem,
            this._esciToolStripMenuItem});
            this._utenteToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._utenteToolStripMenuItem.Name = "_utenteToolStripMenuItem";
            this._utenteToolStripMenuItem.Size = new System.Drawing.Size(59, 36);
            this._utenteToolStripMenuItem.Text = "Utente";
            // 
            // _accountToolStripMenuItem
            // 
            this._accountToolStripMenuItem.Name = "_accountToolStripMenuItem";
            this._accountToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this._accountToolStripMenuItem.Text = "Il tuo account";
            // 
            // _creaGruppoToolStripMenuItem
            // 
            this._creaGruppoToolStripMenuItem.Name = "_creaGruppoToolStripMenuItem";
            this._creaGruppoToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this._creaGruppoToolStripMenuItem.Text = "Crea gruppo";
            // 
            // _esciToolStripMenuItem
            // 
            this._esciToolStripMenuItem.Name = "_esciToolStripMenuItem";
            this._esciToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this._esciToolStripMenuItem.Text = "Esci";
            // 
            // _saldaToolStripButton
            // 
            this._saldaToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this._saldaToolStripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._saldaToolStripButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._saldaToolStripButton.Margin = new System.Windows.Forms.Padding(2, 2, 4, 2);
            this._saldaToolStripButton.Name = "_saldaToolStripButton";
            this._saldaToolStripButton.Size = new System.Drawing.Size(48, 32);
            this._saldaToolStripButton.Text = "Salda";
            this._saldaToolStripButton.Click += new System.EventHandler(this._saldaToolStripButton_Click);
            // 
            // _aggiungiSpesaToolStripButton
            // 
            this._aggiungiSpesaToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this._aggiungiSpesaToolStripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this._aggiungiSpesaToolStripButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._aggiungiSpesaToolStripButton.Margin = new System.Windows.Forms.Padding(4, 2, 2, 2);
            this._aggiungiSpesaToolStripButton.Name = "_aggiungiSpesaToolStripButton";
            this._aggiungiSpesaToolStripButton.Size = new System.Drawing.Size(108, 32);
            this._aggiungiSpesaToolStripButton.Text = "Aggiungi Spesa";
            this._aggiungiSpesaToolStripButton.Click += new System.EventHandler(this._aggiungiSpesaToolStripButton_Click);
            // 
            // _creaGruppoToolStripButton
            // 
            this._creaGruppoToolStripButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._creaGruppoToolStripButton.Name = "_creaGruppoToolStripButton";
            this._creaGruppoToolStripButton.Size = new System.Drawing.Size(87, 33);
            this._creaGruppoToolStripButton.Text = "Crea gruppo";
            this._creaGruppoToolStripButton.Click += new System.EventHandler(this._creaGruppoToolStripButton_Click);
            // 
            // _mainSplitContainer
            // 
            this._mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainSplitContainer.Location = new System.Drawing.Point(0, 40);
            this._mainSplitContainer.Name = "_mainSplitContainer";
            // 
            // _mainSplitContainer.Panel1
            // 
            this._mainSplitContainer.Panel1.Controls.Add(this._linkLabelCrea);
            this._mainSplitContainer.Panel1.Controls.Add(this._amiciListBox);
            this._mainSplitContainer.Panel1.Controls.Add(this._amiciMenuLabel);
            this._mainSplitContainer.Panel1.Controls.Add(this._gruppiMenuLabel);
            this._mainSplitContainer.Panel1.Controls.Add(this._gruppiListBox);
            this._mainSplitContainer.Panel1.Controls.Add(this._speseButton);
            this._mainSplitContainer.Panel1.Controls.Add(this._attivitaButton);
            this._mainSplitContainer.Panel1.Controls.Add(this._riepilogoButton);
            // 
            // _mainSplitContainer.Panel2
            // 
            this._mainSplitContainer.Panel2.Controls.Add(this._mainTabControl);
            this._mainSplitContainer.Size = new System.Drawing.Size(770, 434);
            this._mainSplitContainer.SplitterDistance = 179;
            this._mainSplitContainer.TabIndex = 2;
            // 
            // _linkLabelCrea
            // 
            this._linkLabelCrea.AutoSize = true;
            this._linkLabelCrea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._linkLabelCrea.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this._linkLabelCrea.LinkColor = System.Drawing.Color.Blue;
            this._linkLabelCrea.Location = new System.Drawing.Point(94, 162);
            this._linkLabelCrea.Name = "_linkLabelCrea";
            this._linkLabelCrea.Size = new System.Drawing.Size(33, 15);
            this._linkLabelCrea.TabIndex = 11;
            this._linkLabelCrea.TabStop = true;
            this._linkLabelCrea.Text = "Crea";
            this._linkLabelCrea.VisitedLinkColor = System.Drawing.Color.Blue;
            this._linkLabelCrea.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._linkLabelCrea_LinkClicked);
            // 
            // _amiciListBox
            // 
            this._amiciListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._amiciListBox.BackColor = System.Drawing.SystemColors.Control;
            this._amiciListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._amiciListBox.FormattingEnabled = true;
            this._amiciListBox.ItemHeight = 15;
            this._amiciListBox.Items.AddRange(new object[] {
            "Amico1",
            "Amico2",
            "Amico3"});
            this._amiciListBox.Location = new System.Drawing.Point(35, 322);
            this._amiciListBox.Name = "_amiciListBox";
            this._amiciListBox.ScrollAlwaysVisible = true;
            this._amiciListBox.Size = new System.Drawing.Size(112, 94);
            this._amiciListBox.TabIndex = 9;
            this._amiciListBox.SelectedIndexChanged += new System.EventHandler(this.listBoxAmici_SelectedIndexChanged);
            // 
            // _amiciMenuLabel
            // 
            this._amiciMenuLabel.AutoSize = true;
            this._amiciMenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._amiciMenuLabel.Location = new System.Drawing.Point(32, 297);
            this._amiciMenuLabel.Name = "_amiciMenuLabel";
            this._amiciMenuLabel.Size = new System.Drawing.Size(48, 18);
            this._amiciMenuLabel.TabIndex = 8;
            this._amiciMenuLabel.Text = "Amici:";
            // 
            // _gruppiMenuLabel
            // 
            this._gruppiMenuLabel.AutoSize = true;
            this._gruppiMenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._gruppiMenuLabel.Location = new System.Drawing.Point(32, 160);
            this._gruppiMenuLabel.Name = "_gruppiMenuLabel";
            this._gruppiMenuLabel.Size = new System.Drawing.Size(56, 18);
            this._gruppiMenuLabel.TabIndex = 7;
            this._gruppiMenuLabel.Text = "Gruppi:";
            // 
            // _gruppiListBox
            // 
            this._gruppiListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._gruppiListBox.BackColor = System.Drawing.SystemColors.Control;
            this._gruppiListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._gruppiListBox.FormattingEnabled = true;
            this._gruppiListBox.ItemHeight = 15;
            this._gruppiListBox.Items.AddRange(new object[] {
            "Gruppo1",
            "Gruppo2",
            "Gruppo3"});
            this._gruppiListBox.Location = new System.Drawing.Point(35, 186);
            this._gruppiListBox.Name = "_gruppiListBox";
            this._gruppiListBox.ScrollAlwaysVisible = true;
            this._gruppiListBox.Size = new System.Drawing.Size(112, 94);
            this._gruppiListBox.TabIndex = 6;
            this._gruppiListBox.SelectedIndexChanged += new System.EventHandler(this.listBoxGruppi_SelectedIndexChanged);
            // 
            // _speseButton
            // 
            this._speseButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._speseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._speseButton.Location = new System.Drawing.Point(35, 103);
            this._speseButton.Name = "_speseButton";
            this._speseButton.Size = new System.Drawing.Size(112, 40);
            this._speseButton.TabIndex = 5;
            this._speseButton.Text = "Tutte le spese";
            this._speseButton.UseVisualStyleBackColor = true;
            this._speseButton.Click += new System.EventHandler(this.buttonSpese_Click);
            // 
            // _attivitaButton
            // 
            this._attivitaButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._attivitaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._attivitaButton.Location = new System.Drawing.Point(35, 54);
            this._attivitaButton.Name = "_attivitaButton";
            this._attivitaButton.Size = new System.Drawing.Size(112, 40);
            this._attivitaButton.TabIndex = 4;
            this._attivitaButton.Text = "Attività recenti";
            this._attivitaButton.UseVisualStyleBackColor = true;
            this._attivitaButton.Click += new System.EventHandler(this.buttonAttivita_Click);
            // 
            // _riepilogoButton
            // 
            this._riepilogoButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._riepilogoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._riepilogoButton.Location = new System.Drawing.Point(35, 8);
            this._riepilogoButton.Name = "_riepilogoButton";
            this._riepilogoButton.Size = new System.Drawing.Size(112, 40);
            this._riepilogoButton.TabIndex = 3;
            this._riepilogoButton.Text = "Riepilogo";
            this._riepilogoButton.UseVisualStyleBackColor = true;
            this._riepilogoButton.Click += new System.EventHandler(this.buttonRiepilogo_Click);
            // 
            // _mainTabControl
            // 
            this._mainTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this._mainTabControl.Controls.Add(this._riepilogoTabPage);
            this._mainTabControl.Controls.Add(this._attivitaTabPage);
            this._mainTabControl.Controls.Add(this._speseTabPage);
            this._mainTabControl.Controls.Add(this._gruppoTabPage);
            this._mainTabControl.Controls.Add(this._amicoTabPage);
            this._mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainTabControl.ItemSize = new System.Drawing.Size(0, 1);
            this._mainTabControl.Location = new System.Drawing.Point(0, 0);
            this._mainTabControl.Multiline = true;
            this._mainTabControl.Name = "_mainTabControl";
            this._mainTabControl.Padding = new System.Drawing.Point(6, 6);
            this._mainTabControl.SelectedIndex = 0;
            this._mainTabControl.Size = new System.Drawing.Size(587, 434);
            this._mainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this._mainTabControl.TabIndex = 0;
            // 
            // _riepilogoTabPage
            // 
            this._riepilogoTabPage.Controls.Add(this._riepilogoTableLayoutPanel);
            this._riepilogoTabPage.Controls.Add(this._riepilogoTabControl);
            this._riepilogoTabPage.Controls.Add(this._riepilogoTitoloLabel);
            this._riepilogoTabPage.Location = new System.Drawing.Point(4, 5);
            this._riepilogoTabPage.Name = "_riepilogoTabPage";
            this._riepilogoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._riepilogoTabPage.Size = new System.Drawing.Size(579, 425);
            this._riepilogoTabPage.TabIndex = 0;
            this._riepilogoTabPage.Text = "tabPage1";
            this._riepilogoTabPage.UseVisualStyleBackColor = true;
            // 
            // _riepilogoTableLayoutPanel
            // 
            this._riepilogoTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._riepilogoTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this._riepilogoTableLayoutPanel.ColumnCount = 3;
            this._riepilogoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._riepilogoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._riepilogoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._riepilogoTableLayoutPanel.Controls.Add(this._riepilogoBilancioLabel, 0, 0);
            this._riepilogoTableLayoutPanel.Controls.Add(this._riepilogoDeviLabel, 1, 0);
            this._riepilogoTableLayoutPanel.Controls.Add(this._riepilogoDovutoLabel, 2, 0);
            this._riepilogoTableLayoutPanel.Location = new System.Drawing.Point(6, 37);
            this._riepilogoTableLayoutPanel.Name = "_riepilogoTableLayoutPanel";
            this._riepilogoTableLayoutPanel.RowCount = 1;
            this._riepilogoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._riepilogoTableLayoutPanel.Size = new System.Drawing.Size(567, 73);
            this._riepilogoTableLayoutPanel.TabIndex = 4;
            // 
            // _riepilogoBilancioLabel
            // 
            this._riepilogoBilancioLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this._riepilogoBilancioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._riepilogoBilancioLabel.Location = new System.Drawing.Point(4, 1);
            this._riepilogoBilancioLabel.Name = "_riepilogoBilancioLabel";
            this._riepilogoBilancioLabel.Size = new System.Drawing.Size(181, 23);
            this._riepilogoBilancioLabel.TabIndex = 0;
            this._riepilogoBilancioLabel.Text = "Bilancio totale";
            this._riepilogoBilancioLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _riepilogoDeviLabel
            // 
            this._riepilogoDeviLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this._riepilogoDeviLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._riepilogoDeviLabel.Location = new System.Drawing.Point(192, 1);
            this._riepilogoDeviLabel.Name = "_riepilogoDeviLabel";
            this._riepilogoDeviLabel.Size = new System.Drawing.Size(181, 23);
            this._riepilogoDeviLabel.TabIndex = 1;
            this._riepilogoDeviLabel.Text = "Devi dare";
            this._riepilogoDeviLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _riepilogoDovutoLabel
            // 
            this._riepilogoDovutoLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this._riepilogoDovutoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._riepilogoDovutoLabel.Location = new System.Drawing.Point(380, 1);
            this._riepilogoDovutoLabel.Name = "_riepilogoDovutoLabel";
            this._riepilogoDovutoLabel.Size = new System.Drawing.Size(183, 23);
            this._riepilogoDovutoLabel.TabIndex = 2;
            this._riepilogoDovutoLabel.Text = "Ti è dovuto";
            this._riepilogoDovutoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _riepilogoTabControl
            // 
            this._riepilogoTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._riepilogoTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this._riepilogoTabControl.Controls.Add(this._riepilogoListaTabPage);
            this._riepilogoTabControl.Controls.Add(this._riepilogoGraficoTabPage);
            this._riepilogoTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._riepilogoTabControl.Location = new System.Drawing.Point(3, 116);
            this._riepilogoTabControl.Name = "_riepilogoTabControl";
            this._riepilogoTabControl.SelectedIndex = 0;
            this._riepilogoTabControl.Size = new System.Drawing.Size(573, 303);
            this._riepilogoTabControl.TabIndex = 1;
            // 
            // _riepilogoListaTabPage
            // 
            this._riepilogoListaTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._riepilogoListaTabPage.Location = new System.Drawing.Point(4, 28);
            this._riepilogoListaTabPage.Name = "_riepilogoListaTabPage";
            this._riepilogoListaTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._riepilogoListaTabPage.Size = new System.Drawing.Size(565, 271);
            this._riepilogoListaTabPage.TabIndex = 0;
            this._riepilogoListaTabPage.Text = "Lista";
            this._riepilogoListaTabPage.UseVisualStyleBackColor = true;
            // 
            // _riepilogoGraficoTabPage
            // 
            this._riepilogoGraficoTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._riepilogoGraficoTabPage.Location = new System.Drawing.Point(4, 28);
            this._riepilogoGraficoTabPage.Name = "_riepilogoGraficoTabPage";
            this._riepilogoGraficoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._riepilogoGraficoTabPage.Size = new System.Drawing.Size(565, 271);
            this._riepilogoGraficoTabPage.TabIndex = 1;
            this._riepilogoGraficoTabPage.Text = "Grafico";
            this._riepilogoGraficoTabPage.UseVisualStyleBackColor = true;
            // 
            // _riepilogoTitoloLabel
            // 
            this._riepilogoTitoloLabel.AutoSize = true;
            this._riepilogoTitoloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._riepilogoTitoloLabel.Location = new System.Drawing.Point(6, 3);
            this._riepilogoTitoloLabel.Name = "_riepilogoTitoloLabel";
            this._riepilogoTitoloLabel.Size = new System.Drawing.Size(102, 25);
            this._riepilogoTitoloLabel.TabIndex = 0;
            this._riepilogoTitoloLabel.Text = "Riepilogo";
            // 
            // _attivitaTabPage
            // 
            this._attivitaTabPage.Controls.Add(this._attivitaTitoloLabel);
            this._attivitaTabPage.Location = new System.Drawing.Point(4, 5);
            this._attivitaTabPage.Name = "_attivitaTabPage";
            this._attivitaTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._attivitaTabPage.Size = new System.Drawing.Size(579, 425);
            this._attivitaTabPage.TabIndex = 1;
            this._attivitaTabPage.Text = "tabPage2";
            this._attivitaTabPage.UseVisualStyleBackColor = true;
            // 
            // _attivitaTitoloLabel
            // 
            this._attivitaTitoloLabel.AutoSize = true;
            this._attivitaTitoloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._attivitaTitoloLabel.Location = new System.Drawing.Point(6, 3);
            this._attivitaTitoloLabel.Name = "_attivitaTitoloLabel";
            this._attivitaTitoloLabel.Size = new System.Drawing.Size(148, 25);
            this._attivitaTitoloLabel.TabIndex = 0;
            this._attivitaTitoloLabel.Text = "Attività recenti";
            // 
            // _speseTabPage
            // 
            this._speseTabPage.Controls.Add(this._speseSplitContainer);
            this._speseTabPage.Controls.Add(this._speseTitoloLabel);
            this._speseTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._speseTabPage.Location = new System.Drawing.Point(4, 5);
            this._speseTabPage.Name = "_speseTabPage";
            this._speseTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._speseTabPage.Size = new System.Drawing.Size(579, 425);
            this._speseTabPage.TabIndex = 2;
            this._speseTabPage.Text = "tabPage3";
            this._speseTabPage.UseVisualStyleBackColor = true;
            // 
            // _speseSplitContainer
            // 
            this._speseSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._speseSplitContainer.IsSplitterFixed = true;
            this._speseSplitContainer.Location = new System.Drawing.Point(0, 36);
            this._speseSplitContainer.Name = "_speseSplitContainer";
            // 
            // _speseSplitContainer.Panel2
            // 
            this._speseSplitContainer.Panel2.Controls.Add(this._speseTabControl);
            this._speseSplitContainer.Size = new System.Drawing.Size(576, 383);
            this._speseSplitContainer.SplitterDistance = 361;
            this._speseSplitContainer.TabIndex = 2;
            // 
            // _speseTabControl
            // 
            this._speseTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this._speseTabControl.Controls.Add(this._speseBilancioTabPage);
            this._speseTabControl.Controls.Add(this._speseStatisticheTabPage);
            this._speseTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._speseTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._speseTabControl.Location = new System.Drawing.Point(0, 0);
            this._speseTabControl.Name = "_speseTabControl";
            this._speseTabControl.SelectedIndex = 0;
            this._speseTabControl.Size = new System.Drawing.Size(211, 383);
            this._speseTabControl.TabIndex = 1;
            // 
            // _speseBilancioTabPage
            // 
            this._speseBilancioTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._speseBilancioTabPage.Controls.Add(this._speseBilancioLabel);
            this._speseBilancioTabPage.Location = new System.Drawing.Point(4, 28);
            this._speseBilancioTabPage.Name = "_speseBilancioTabPage";
            this._speseBilancioTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._speseBilancioTabPage.Size = new System.Drawing.Size(203, 351);
            this._speseBilancioTabPage.TabIndex = 0;
            this._speseBilancioTabPage.Text = "Bilancio";
            this._speseBilancioTabPage.UseVisualStyleBackColor = true;
            // 
            // _speseBilancioLabel
            // 
            this._speseBilancioLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this._speseBilancioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._speseBilancioLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this._speseBilancioLabel.Location = new System.Drawing.Point(3, 3);
            this._speseBilancioLabel.Name = "_speseBilancioLabel";
            this._speseBilancioLabel.Size = new System.Drawing.Size(195, 24);
            this._speseBilancioLabel.TabIndex = 0;
            this._speseBilancioLabel.Text = "Il tuo bilancio totale";
            this._speseBilancioLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _speseStatisticheTabPage
            // 
            this._speseStatisticheTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._speseStatisticheTabPage.Controls.Add(this._labelSpeseStatistiche);
            this._speseStatisticheTabPage.Location = new System.Drawing.Point(4, 28);
            this._speseStatisticheTabPage.Name = "_speseStatisticheTabPage";
            this._speseStatisticheTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._speseStatisticheTabPage.Size = new System.Drawing.Size(203, 351);
            this._speseStatisticheTabPage.TabIndex = 1;
            this._speseStatisticheTabPage.Text = "Statistiche";
            this._speseStatisticheTabPage.UseVisualStyleBackColor = true;
            // 
            // _labelSpeseStatistiche
            // 
            this._labelSpeseStatistiche.Dock = System.Windows.Forms.DockStyle.Top;
            this._labelSpeseStatistiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelSpeseStatistiche.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this._labelSpeseStatistiche.Location = new System.Drawing.Point(3, 3);
            this._labelSpeseStatistiche.Name = "_labelSpeseStatistiche";
            this._labelSpeseStatistiche.Size = new System.Drawing.Size(195, 24);
            this._labelSpeseStatistiche.TabIndex = 1;
            this._labelSpeseStatistiche.Text = "Statistiche";
            this._labelSpeseStatistiche.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _speseTitoloLabel
            // 
            this._speseTitoloLabel.AutoSize = true;
            this._speseTitoloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._speseTitoloLabel.Location = new System.Drawing.Point(6, 3);
            this._speseTitoloLabel.Name = "_speseTitoloLabel";
            this._speseTitoloLabel.Size = new System.Drawing.Size(148, 25);
            this._speseTitoloLabel.TabIndex = 0;
            this._speseTitoloLabel.Text = "Tutte le spese";
            // 
            // _gruppoTabPage
            // 
            this._gruppoTabPage.Controls.Add(this._gruppoTitoloLabel);
            this._gruppoTabPage.Location = new System.Drawing.Point(4, 5);
            this._gruppoTabPage.Name = "_gruppoTabPage";
            this._gruppoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._gruppoTabPage.Size = new System.Drawing.Size(579, 425);
            this._gruppoTabPage.TabIndex = 3;
            this._gruppoTabPage.Text = "tabPage3";
            this._gruppoTabPage.UseVisualStyleBackColor = true;
            // 
            // _gruppoTitoloLabel
            // 
            this._gruppoTitoloLabel.AutoSize = true;
            this._gruppoTitoloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._gruppoTitoloLabel.Location = new System.Drawing.Point(6, 3);
            this._gruppoTitoloLabel.Name = "_gruppoTitoloLabel";
            this._gruppoTitoloLabel.Size = new System.Drawing.Size(83, 25);
            this._gruppoTitoloLabel.TabIndex = 1;
            this._gruppoTitoloLabel.Text = "Gruppo";
            // 
            // _amicoTabPage
            // 
            this._amicoTabPage.Controls.Add(this._amicoTitoloLabel);
            this._amicoTabPage.Location = new System.Drawing.Point(4, 5);
            this._amicoTabPage.Name = "_amicoTabPage";
            this._amicoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._amicoTabPage.Size = new System.Drawing.Size(579, 425);
            this._amicoTabPage.TabIndex = 4;
            this._amicoTabPage.Text = "tabPage4";
            this._amicoTabPage.UseVisualStyleBackColor = true;
            // 
            // _amicoTitoloLabel
            // 
            this._amicoTitoloLabel.AutoSize = true;
            this._amicoTitoloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._amicoTitoloLabel.Location = new System.Drawing.Point(6, 3);
            this._amicoTitoloLabel.Name = "_amicoTitoloLabel";
            this._amicoTitoloLabel.Size = new System.Drawing.Size(71, 25);
            this._amicoTitoloLabel.TabIndex = 1;
            this._amicoTitoloLabel.Text = "Amico";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 496);
            this.Controls.Add(this._mainSplitContainer);
            this.Controls.Add(this._mainStatusStrip);
            this.Controls.Add(this._mainMenuStrip);
            this.MainMenuStrip = this._mainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(786, 534);
            this.Name = "MainForm";
            this.Text = "Room8";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this._mainMenuStrip.ResumeLayout(false);
            this._mainMenuStrip.PerformLayout();
            this._mainSplitContainer.Panel1.ResumeLayout(false);
            this._mainSplitContainer.Panel1.PerformLayout();
            this._mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._mainSplitContainer)).EndInit();
            this._mainSplitContainer.ResumeLayout(false);
            this._mainTabControl.ResumeLayout(false);
            this._riepilogoTabPage.ResumeLayout(false);
            this._riepilogoTabPage.PerformLayout();
            this._riepilogoTableLayoutPanel.ResumeLayout(false);
            this._riepilogoTabControl.ResumeLayout(false);
            this._attivitaTabPage.ResumeLayout(false);
            this._attivitaTabPage.PerformLayout();
            this._speseTabPage.ResumeLayout(false);
            this._speseTabPage.PerformLayout();
            this._speseSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._speseSplitContainer)).EndInit();
            this._speseSplitContainer.ResumeLayout(false);
            this._speseTabControl.ResumeLayout(false);
            this._speseBilancioTabPage.ResumeLayout(false);
            this._speseStatisticheTabPage.ResumeLayout(false);
            this._gruppoTabPage.ResumeLayout(false);
            this._gruppoTabPage.PerformLayout();
            this._amicoTabPage.ResumeLayout(false);
            this._amicoTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip _mainStatusStrip;
        private System.Windows.Forms.MenuStrip _mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem _utenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _creaGruppoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _esciToolStripMenuItem;
        private System.Windows.Forms.SplitContainer _mainSplitContainer;
        private System.Windows.Forms.Button _riepilogoButton;
        private System.Windows.Forms.Button _speseButton;
        private System.Windows.Forms.Button _attivitaButton;
        private System.Windows.Forms.TabControl _mainTabControl;
        private System.Windows.Forms.TabPage _riepilogoTabPage;
        private System.Windows.Forms.TabPage _attivitaTabPage;
        private System.Windows.Forms.TabPage _speseTabPage;
        private System.Windows.Forms.Label _speseTitoloLabel;
        private System.Windows.Forms.Label _riepilogoTitoloLabel;
        private System.Windows.Forms.Label _attivitaTitoloLabel;
        private System.Windows.Forms.ListBox _gruppiListBox;
        private System.Windows.Forms.ListBox _amiciListBox;
        private System.Windows.Forms.Label _amiciMenuLabel;
        private System.Windows.Forms.Label _gruppiMenuLabel;
        private System.Windows.Forms.TabControl _riepilogoTabControl;
        private System.Windows.Forms.TabPage _riepilogoListaTabPage;
        private System.Windows.Forms.TabPage _riepilogoGraficoTabPage;
        private System.Windows.Forms.TabControl _speseTabControl;
        private System.Windows.Forms.TabPage _speseBilancioTabPage;
        private System.Windows.Forms.TabPage _speseStatisticheTabPage;
        private System.Windows.Forms.TabPage _gruppoTabPage;
        private System.Windows.Forms.TabPage _amicoTabPage;
        private System.Windows.Forms.Label _gruppoTitoloLabel;
        private System.Windows.Forms.Label _amicoTitoloLabel;
        private System.Windows.Forms.TableLayoutPanel _riepilogoTableLayoutPanel;
        private System.Windows.Forms.SplitContainer _speseSplitContainer;
        private System.Windows.Forms.Label _riepilogoBilancioLabel;
        private System.Windows.Forms.Label _riepilogoDeviLabel;
        private System.Windows.Forms.Label _riepilogoDovutoLabel;
        private System.Windows.Forms.Label _speseBilancioLabel;
        private System.Windows.Forms.Label _labelSpeseStatistiche;
        private System.Windows.Forms.LinkLabel _linkLabelCrea;
        private System.Windows.Forms.ToolStripButton _aggiungiSpesaToolStripButton;
        private System.Windows.Forms.ToolStripButton _saldaToolStripButton;
        private System.Windows.Forms.ToolStripButton _creaGruppoToolStripButton;
    }
}

