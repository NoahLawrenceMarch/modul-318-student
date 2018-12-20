namespace Fahrplan
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LBX_station = new System.Windows.Forms.ListBox();
            this.BTN_suche_3 = new System.Windows.Forms.Button();
            this.TXT_station = new System.Windows.Forms.TextBox();
            this.WEB_google_maps = new System.Windows.Forms.WebBrowser();
            this.GRP_suche_3 = new System.Windows.Forms.GroupBox();
            this.LBL_station = new System.Windows.Forms.Label();
            this.LBX_von_2 = new System.Windows.Forms.ListBox();
            this.BTN_suche_2 = new System.Windows.Forms.Button();
            this.BTN_von_2 = new System.Windows.Forms.TextBox();
            this.LBL_von_2 = new System.Windows.Forms.Label();
            this.GRP_suche_2 = new System.Windows.Forms.GroupBox();
            this.DTG_Verbindungen_2 = new System.Windows.Forms.DataGridView();
            this.GRP_result_2 = new System.Windows.Forms.GroupBox();
            this.PNL_3 = new System.Windows.Forms.Panel();
            this.PNL_1 = new System.Windows.Forms.Panel();
            this.GRP_suche = new System.Windows.Forms.GroupBox();
            this.PB_switch = new System.Windows.Forms.PictureBox();
            this.TXT_nach = new System.Windows.Forms.TextBox();
            this.TXT_von = new System.Windows.Forms.TextBox();
            this.LBL_von = new System.Windows.Forms.Label();
            this.DTP_zeit = new System.Windows.Forms.DateTimePicker();
            this.BTN_google_maps = new System.Windows.Forms.Button();
            this.LBX_von = new System.Windows.Forms.ListBox();
            this.LBL_nach = new System.Windows.Forms.Label();
            this.LBL_zeit = new System.Windows.Forms.Label();
            this.DTP_datum = new System.Windows.Forms.DateTimePicker();
            this.LBX_nach = new System.Windows.Forms.ListBox();
            this.LBL_datum = new System.Windows.Forms.Label();
            this.BTN_suche = new System.Windows.Forms.Button();
            this.BTN_nav2 = new System.Windows.Forms.Button();
            this.GRP_result = new System.Windows.Forms.GroupBox();
            this.TXT_email = new System.Windows.Forms.TextBox();
            this.BTN_close = new System.Windows.Forms.Button();
            this.LBL_laden = new System.Windows.Forms.Label();
            this.BTN_email = new System.Windows.Forms.Button();
            this.DTG_verbindungen = new System.Windows.Forms.DataGridView();
            this.PNL_2 = new System.Windows.Forms.Panel();
            this.LBL_titel_abfahrtstafel = new System.Windows.Forms.Label();
            this.bkbutton = new System.Windows.Forms.Button();
            this.bkbutton2 = new System.Windows.Forms.Button();
            this.GRP_suche_3.SuspendLayout();
            this.GRP_suche_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_Verbindungen_2)).BeginInit();
            this.GRP_result_2.SuspendLayout();
            this.PNL_3.SuspendLayout();
            this.PNL_1.SuspendLayout();
            this.GRP_suche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_switch)).BeginInit();
            this.GRP_result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_verbindungen)).BeginInit();
            this.PNL_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBX_station
            // 
            this.LBX_station.FormattingEnabled = true;
            this.LBX_station.ItemHeight = 16;
            this.LBX_station.Location = new System.Drawing.Point(8, 106);
            this.LBX_station.Margin = new System.Windows.Forms.Padding(4);
            this.LBX_station.Name = "LBX_station";
            this.LBX_station.Size = new System.Drawing.Size(265, 116);
            this.LBX_station.TabIndex = 9;
            this.LBX_station.Visible = false;
            this.LBX_station.DoubleClick += new System.EventHandler(this.lbx_3_start_DoubleClick);
            // 
            // BTN_suche_3
            // 
            this.BTN_suche_3.BackColor = System.Drawing.Color.Red;
            this.BTN_suche_3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_suche_3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_suche_3.Location = new System.Drawing.Point(350, 69);
            this.BTN_suche_3.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_suche_3.Name = "BTN_suche_3";
            this.BTN_suche_3.Size = new System.Drawing.Size(179, 33);
            this.BTN_suche_3.TabIndex = 14;
            this.BTN_suche_3.Text = "Station anzeigen";
            this.BTN_suche_3.UseVisualStyleBackColor = false;
            this.BTN_suche_3.Click += new System.EventHandler(this.BTN_suche_3_Click);
            // 
            // TXT_station
            // 
            this.TXT_station.Location = new System.Drawing.Point(8, 75);
            this.TXT_station.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_station.Name = "TXT_station";
            this.TXT_station.Size = new System.Drawing.Size(265, 22);
            this.TXT_station.TabIndex = 13;
            this.TXT_station.TextChanged += new System.EventHandler(this.TXT_station_TextChanged);
            // 
            // WEB_google_maps
            // 
            this.WEB_google_maps.Location = new System.Drawing.Point(19, 259);
            this.WEB_google_maps.Margin = new System.Windows.Forms.Padding(4);
            this.WEB_google_maps.MinimumSize = new System.Drawing.Size(27, 25);
            this.WEB_google_maps.Name = "WEB_google_maps";
            this.WEB_google_maps.ScriptErrorsSuppressed = true;
            this.WEB_google_maps.Size = new System.Drawing.Size(921, 533);
            this.WEB_google_maps.TabIndex = 5;
            // 
            // GRP_suche_3
            // 
            this.GRP_suche_3.BackColor = System.Drawing.Color.Red;
            this.GRP_suche_3.Controls.Add(this.bkbutton);
            this.GRP_suche_3.Controls.Add(this.LBX_station);
            this.GRP_suche_3.Controls.Add(this.BTN_suche_3);
            this.GRP_suche_3.Controls.Add(this.TXT_station);
            this.GRP_suche_3.Controls.Add(this.LBL_station);
            this.GRP_suche_3.Location = new System.Drawing.Point(11, 13);
            this.GRP_suche_3.Margin = new System.Windows.Forms.Padding(4);
            this.GRP_suche_3.Name = "GRP_suche_3";
            this.GRP_suche_3.Padding = new System.Windows.Forms.Padding(4);
            this.GRP_suche_3.Size = new System.Drawing.Size(1183, 238);
            this.GRP_suche_3.TabIndex = 4;
            this.GRP_suche_3.TabStop = false;
            this.GRP_suche_3.Text = "Suche";
            // 
            // LBL_station
            // 
            this.LBL_station.AutoSize = true;
            this.LBL_station.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_station.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBL_station.Location = new System.Drawing.Point(8, 47);
            this.LBL_station.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_station.Name = "LBL_station";
            this.LBL_station.Size = new System.Drawing.Size(73, 29);
            this.LBL_station.TabIndex = 2;
            this.LBL_station.Text = "Station";
            // 
            // LBX_von_2
            // 
            this.LBX_von_2.FormattingEnabled = true;
            this.LBX_von_2.ItemHeight = 16;
            this.LBX_von_2.Location = new System.Drawing.Point(8, 110);
            this.LBX_von_2.Margin = new System.Windows.Forms.Padding(4);
            this.LBX_von_2.Name = "LBX_von_2";
            this.LBX_von_2.Size = new System.Drawing.Size(265, 116);
            this.LBX_von_2.TabIndex = 0;
            this.LBX_von_2.Visible = false;
            this.LBX_von_2.DoubleClick += new System.EventHandler(this.LBX_von_2_DoubleClick);
            // 
            // BTN_suche_2
            // 
            this.BTN_suche_2.BackColor = System.Drawing.Color.Red;
            this.BTN_suche_2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_suche_2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_suche_2.Location = new System.Drawing.Point(382, 138);
            this.BTN_suche_2.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_suche_2.Name = "BTN_suche_2";
            this.BTN_suche_2.Size = new System.Drawing.Size(179, 46);
            this.BTN_suche_2.TabIndex = 12;
            this.BTN_suche_2.Text = "Abfahrtstafel anzeigen";
            this.BTN_suche_2.UseVisualStyleBackColor = false;
            this.BTN_suche_2.Click += new System.EventHandler(this.BTN_suche_2_Click);
            // 
            // BTN_von_2
            // 
            this.BTN_von_2.Location = new System.Drawing.Point(8, 80);
            this.BTN_von_2.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_von_2.Name = "BTN_von_2";
            this.BTN_von_2.Size = new System.Drawing.Size(265, 22);
            this.BTN_von_2.TabIndex = 11;
            this.BTN_von_2.TextChanged += new System.EventHandler(this.BTN_von_2_TextChanged);
            // 
            // LBL_von_2
            // 
            this.LBL_von_2.AutoSize = true;
            this.LBL_von_2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_von_2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBL_von_2.Location = new System.Drawing.Point(8, 47);
            this.LBL_von_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_von_2.Name = "LBL_von_2";
            this.LBL_von_2.Size = new System.Drawing.Size(48, 29);
            this.LBL_von_2.TabIndex = 2;
            this.LBL_von_2.Text = "Von";
            // 
            // GRP_suche_2
            // 
            this.GRP_suche_2.BackColor = System.Drawing.Color.Red;
            this.GRP_suche_2.Controls.Add(this.LBX_von_2);
            this.GRP_suche_2.Controls.Add(this.BTN_suche_2);
            this.GRP_suche_2.Controls.Add(this.BTN_von_2);
            this.GRP_suche_2.Controls.Add(this.LBL_von_2);
            this.GRP_suche_2.Location = new System.Drawing.Point(16, 126);
            this.GRP_suche_2.Margin = new System.Windows.Forms.Padding(4);
            this.GRP_suche_2.Name = "GRP_suche_2";
            this.GRP_suche_2.Padding = new System.Windows.Forms.Padding(4);
            this.GRP_suche_2.Size = new System.Drawing.Size(669, 241);
            this.GRP_suche_2.TabIndex = 3;
            this.GRP_suche_2.TabStop = false;
            this.GRP_suche_2.Text = "Suche";
            // 
            // DTG_Verbindungen_2
            // 
            this.DTG_Verbindungen_2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DTG_Verbindungen_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG_Verbindungen_2.Cursor = System.Windows.Forms.Cursors.No;
            this.DTG_Verbindungen_2.Location = new System.Drawing.Point(20, 23);
            this.DTG_Verbindungen_2.Margin = new System.Windows.Forms.Padding(4);
            this.DTG_Verbindungen_2.Name = "DTG_Verbindungen_2";
            this.DTG_Verbindungen_2.RowHeadersVisible = false;
            this.DTG_Verbindungen_2.Size = new System.Drawing.Size(641, 324);
            this.DTG_Verbindungen_2.TabIndex = 0;
            // 
            // GRP_result_2
            // 
            this.GRP_result_2.Controls.Add(this.DTG_Verbindungen_2);
            this.GRP_result_2.Location = new System.Drawing.Point(16, 375);
            this.GRP_result_2.Margin = new System.Windows.Forms.Padding(4);
            this.GRP_result_2.Name = "GRP_result_2";
            this.GRP_result_2.Padding = new System.Windows.Forms.Padding(4);
            this.GRP_result_2.Size = new System.Drawing.Size(669, 348);
            this.GRP_result_2.TabIndex = 4;
            this.GRP_result_2.TabStop = false;
            this.GRP_result_2.Text = "Suchergebniss";
            // 
            // PNL_3
            // 
            this.PNL_3.Controls.Add(this.WEB_google_maps);
            this.PNL_3.Controls.Add(this.GRP_suche_3);
            this.PNL_3.Location = new System.Drawing.Point(48, 109);
            this.PNL_3.Margin = new System.Windows.Forms.Padding(4);
            this.PNL_3.Name = "PNL_3";
            this.PNL_3.Size = new System.Drawing.Size(962, 701);
            this.PNL_3.TabIndex = 11;
            // 
            // PNL_1
            // 
            this.PNL_1.BackColor = System.Drawing.Color.White;
            this.PNL_1.Controls.Add(this.GRP_suche);
            this.PNL_1.Controls.Add(this.GRP_result);
            this.PNL_1.Location = new System.Drawing.Point(24, 49);
            this.PNL_1.Margin = new System.Windows.Forms.Padding(4);
            this.PNL_1.Name = "PNL_1";
            this.PNL_1.Size = new System.Drawing.Size(1139, 926);
            this.PNL_1.TabIndex = 7;
            // 
            // GRP_suche
            // 
            this.GRP_suche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GRP_suche.BackColor = System.Drawing.Color.White;
            this.GRP_suche.BackgroundImage = global::Fahrplan.Properties.Resources._131125_scholtysik_news_sbb_new;
            this.GRP_suche.Controls.Add(this.BTN_suche);
            this.GRP_suche.Controls.Add(this.PB_switch);
            this.GRP_suche.Controls.Add(this.TXT_nach);
            this.GRP_suche.Controls.Add(this.TXT_von);
            this.GRP_suche.Controls.Add(this.LBL_von);
            this.GRP_suche.Controls.Add(this.BTN_nav2);
            this.GRP_suche.Controls.Add(this.DTP_zeit);
            this.GRP_suche.Controls.Add(this.BTN_google_maps);
            this.GRP_suche.Controls.Add(this.LBX_von);
            this.GRP_suche.Controls.Add(this.LBL_nach);
            this.GRP_suche.Controls.Add(this.LBL_zeit);
            this.GRP_suche.Controls.Add(this.DTP_datum);
            this.GRP_suche.Controls.Add(this.LBX_nach);
            this.GRP_suche.Controls.Add(this.LBL_datum);
            this.GRP_suche.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRP_suche.Location = new System.Drawing.Point(5, 14);
            this.GRP_suche.Margin = new System.Windows.Forms.Padding(4);
            this.GRP_suche.Name = "GRP_suche";
            this.GRP_suche.Padding = new System.Windows.Forms.Padding(4);
            this.GRP_suche.Size = new System.Drawing.Size(1092, 300);
            this.GRP_suche.TabIndex = 0;
            this.GRP_suche.TabStop = false;
            this.GRP_suche.Text = "Verbindungen";
            this.GRP_suche.Enter += new System.EventHandler(this.GRP_suche_Enter);
            // 
            // PB_switch
            // 
            this.PB_switch.BackColor = System.Drawing.Color.Transparent;
            this.PB_switch.Image = ((System.Drawing.Image)(resources.GetObject("PB_switch.Image")));
            this.PB_switch.Location = new System.Drawing.Point(373, 97);
            this.PB_switch.Margin = new System.Windows.Forms.Padding(4);
            this.PB_switch.Name = "PB_switch";
            this.PB_switch.Size = new System.Drawing.Size(70, 76);
            this.PB_switch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_switch.TabIndex = 11;
            this.PB_switch.TabStop = false;
            this.PB_switch.Click += new System.EventHandler(this.PB_switch_Click);
            // 
            // TXT_nach
            // 
            this.TXT_nach.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_nach.Location = new System.Drawing.Point(100, 188);
            this.TXT_nach.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_nach.Name = "TXT_nach";
            this.TXT_nach.Size = new System.Drawing.Size(265, 34);
            this.TXT_nach.TabIndex = 5;
            this.TXT_nach.TextChanged += new System.EventHandler(this.TXT_nach_TextChanged);
            // 
            // TXT_von
            // 
            this.TXT_von.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TXT_von.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_von.Location = new System.Drawing.Point(100, 55);
            this.TXT_von.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_von.Name = "TXT_von";
            this.TXT_von.Size = new System.Drawing.Size(265, 34);
            this.TXT_von.TabIndex = 4;
            this.TXT_von.TextChanged += new System.EventHandler(this.TXT_von_TextChanged);
            // 
            // LBL_von
            // 
            this.LBL_von.AutoSize = true;
            this.LBL_von.BackColor = System.Drawing.Color.Transparent;
            this.LBL_von.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_von.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBL_von.Location = new System.Drawing.Point(6, 49);
            this.LBL_von.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_von.Name = "LBL_von";
            this.LBL_von.Size = new System.Drawing.Size(77, 29);
            this.LBL_von.TabIndex = 0;
            this.LBL_von.Text = "Abfahrt";
            // 
            // DTP_zeit
            // 
            this.DTP_zeit.CalendarForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DTP_zeit.CustomFormat = "HH:mm";
            this.DTP_zeit.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_zeit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_zeit.Location = new System.Drawing.Point(606, 55);
            this.DTP_zeit.Margin = new System.Windows.Forms.Padding(4);
            this.DTP_zeit.Name = "DTP_zeit";
            this.DTP_zeit.ShowUpDown = true;
            this.DTP_zeit.Size = new System.Drawing.Size(92, 34);
            this.DTP_zeit.TabIndex = 8;
            // 
            // BTN_google_maps
            // 
            this.BTN_google_maps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_google_maps.BackColor = System.Drawing.Color.Maroon;
            this.BTN_google_maps.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_google_maps.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_google_maps.Location = new System.Drawing.Point(419, 218);
            this.BTN_google_maps.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_google_maps.Name = "BTN_google_maps";
            this.BTN_google_maps.Size = new System.Drawing.Size(303, 46);
            this.BTN_google_maps.TabIndex = 10;
            this.BTN_google_maps.Text = "In Google Maps öffnen";
            this.BTN_google_maps.UseVisualStyleBackColor = false;
            this.BTN_google_maps.Click += new System.EventHandler(this.BTN_google_maps_Click);
            // 
            // LBX_von
            // 
            this.LBX_von.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBX_von.FormattingEnabled = true;
            this.LBX_von.ItemHeight = 27;
            this.LBX_von.Location = new System.Drawing.Point(100, 92);
            this.LBX_von.Margin = new System.Windows.Forms.Padding(4);
            this.LBX_von.Name = "LBX_von";
            this.LBX_von.Size = new System.Drawing.Size(265, 58);
            this.LBX_von.TabIndex = 0;
            this.LBX_von.Visible = false;
            this.LBX_von.SelectedIndexChanged += new System.EventHandler(this.LBX_von_SelectedIndexChanged);
            this.LBX_von.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LBX_von_MouseDoubleClick);
            // 
            // LBL_nach
            // 
            this.LBL_nach.AutoSize = true;
            this.LBL_nach.BackColor = System.Drawing.Color.Transparent;
            this.LBL_nach.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_nach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBL_nach.Location = new System.Drawing.Point(6, 182);
            this.LBL_nach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_nach.Name = "LBL_nach";
            this.LBL_nach.Size = new System.Drawing.Size(44, 29);
            this.LBL_nach.TabIndex = 0;
            this.LBL_nach.Text = "Ziel";
            // 
            // LBL_zeit
            // 
            this.LBL_zeit.AutoSize = true;
            this.LBL_zeit.BackColor = System.Drawing.Color.Transparent;
            this.LBL_zeit.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_zeit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBL_zeit.Location = new System.Drawing.Point(635, 22);
            this.LBL_zeit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_zeit.Name = "LBL_zeit";
            this.LBL_zeit.Size = new System.Drawing.Size(45, 29);
            this.LBL_zeit.TabIndex = 0;
            this.LBL_zeit.Text = "Zeit";
            // 
            // DTP_datum
            // 
            this.DTP_datum.CalendarForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DTP_datum.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.DTP_datum.CustomFormat = "dd.MM.yyyy";
            this.DTP_datum.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_datum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_datum.Location = new System.Drawing.Point(419, 55);
            this.DTP_datum.Margin = new System.Windows.Forms.Padding(4);
            this.DTP_datum.Name = "DTP_datum";
            this.DTP_datum.Size = new System.Drawing.Size(157, 34);
            this.DTP_datum.TabIndex = 7;
            // 
            // LBX_nach
            // 
            this.LBX_nach.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBX_nach.FormattingEnabled = true;
            this.LBX_nach.ItemHeight = 27;
            this.LBX_nach.Location = new System.Drawing.Point(100, 218);
            this.LBX_nach.Margin = new System.Windows.Forms.Padding(4);
            this.LBX_nach.Name = "LBX_nach";
            this.LBX_nach.Size = new System.Drawing.Size(265, 58);
            this.LBX_nach.TabIndex = 0;
            this.LBX_nach.Visible = false;
            this.LBX_nach.SelectedIndexChanged += new System.EventHandler(this.LBX_nach_SelectedIndexChanged);
            this.LBX_nach.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LBX_nach_MouseDoubleClick);
            // 
            // LBL_datum
            // 
            this.LBL_datum.AutoSize = true;
            this.LBL_datum.BackColor = System.Drawing.Color.Transparent;
            this.LBL_datum.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_datum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBL_datum.Location = new System.Drawing.Point(457, 22);
            this.LBL_datum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_datum.Name = "LBL_datum";
            this.LBL_datum.Size = new System.Drawing.Size(70, 29);
            this.LBL_datum.TabIndex = 0;
            this.LBL_datum.Text = "Datum";
            // 
            // BTN_suche
            // 
            this.BTN_suche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_suche.BackColor = System.Drawing.Color.Maroon;
            this.BTN_suche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN_suche.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.BTN_suche.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_suche.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_suche.Location = new System.Drawing.Point(479, 123);
            this.BTN_suche.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_suche.Name = "BTN_suche";
            this.BTN_suche.Size = new System.Drawing.Size(201, 52);
            this.BTN_suche.TabIndex = 9;
            this.BTN_suche.Text = "Search";
            this.BTN_suche.UseVisualStyleBackColor = false;
            this.BTN_suche.Click += new System.EventHandler(this.BTN_suche_Click_1);
            // 
            // BTN_nav2
            // 
            this.BTN_nav2.BackColor = System.Drawing.Color.Black;
            this.BTN_nav2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_nav2.ForeColor = System.Drawing.Color.White;
            this.BTN_nav2.Location = new System.Drawing.Point(888, 18);
            this.BTN_nav2.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.BTN_nav2.Name = "BTN_nav2";
            this.BTN_nav2.Size = new System.Drawing.Size(200, 71);
            this.BTN_nav2.TabIndex = 6;
            this.BTN_nav2.Text = "Abfahrtstafel";
            this.BTN_nav2.UseVisualStyleBackColor = false;
            this.BTN_nav2.Click += new System.EventHandler(this.BTN_nav2_Click);
            // 
            // GRP_result
            // 
            this.GRP_result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GRP_result.BackColor = System.Drawing.Color.White;
            this.GRP_result.BackgroundImage = global::Fahrplan.Properties.Resources.cq5dam_web_1280_1280;
            this.GRP_result.Controls.Add(this.TXT_email);
            this.GRP_result.Controls.Add(this.BTN_close);
            this.GRP_result.Controls.Add(this.LBL_laden);
            this.GRP_result.Controls.Add(this.BTN_email);
            this.GRP_result.Controls.Add(this.DTG_verbindungen);
            this.GRP_result.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRP_result.Location = new System.Drawing.Point(8, 448);
            this.GRP_result.Margin = new System.Windows.Forms.Padding(4);
            this.GRP_result.Name = "GRP_result";
            this.GRP_result.Padding = new System.Windows.Forms.Padding(4);
            this.GRP_result.Size = new System.Drawing.Size(1089, 379);
            this.GRP_result.TabIndex = 0;
            this.GRP_result.TabStop = false;
            this.GRP_result.Text = "Fahrplan";
            this.GRP_result.Enter += new System.EventHandler(this.GRP_result_Enter);
            // 
            // TXT_email
            // 
            this.TXT_email.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_email.Location = new System.Drawing.Point(97, 296);
            this.TXT_email.Name = "TXT_email";
            this.TXT_email.Size = new System.Drawing.Size(201, 34);
            this.TXT_email.TabIndex = 13;
            this.TXT_email.TextChanged += new System.EventHandler(this.TXT_email_TextChanged);
            // 
            // BTN_close
            // 
            this.BTN_close.BackColor = System.Drawing.Color.Black;
            this.BTN_close.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_close.ForeColor = System.Drawing.Color.White;
            this.BTN_close.Location = new System.Drawing.Point(885, 261);
            this.BTN_close.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.BTN_close.Name = "BTN_close";
            this.BTN_close.Size = new System.Drawing.Size(200, 71);
            this.BTN_close.TabIndex = 12;
            this.BTN_close.Text = "Anwendung Schliessen";
            this.BTN_close.UseVisualStyleBackColor = false;
            this.BTN_close.Click += new System.EventHandler(this.btn_exit_Click_1);
            // 
            // LBL_laden
            // 
            this.LBL_laden.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_laden.AutoSize = true;
            this.LBL_laden.BackColor = System.Drawing.SystemColors.Window;
            this.LBL_laden.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_laden.Location = new System.Drawing.Point(537, 105);
            this.LBL_laden.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_laden.Name = "LBL_laden";
            this.LBL_laden.Size = new System.Drawing.Size(124, 29);
            this.LBL_laden.TabIndex = 1;
            this.LBL_laden.Text = "Loading...";
            // 
            // BTN_email
            // 
            this.BTN_email.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_email.Location = new System.Drawing.Point(97, 242);
            this.BTN_email.Name = "BTN_email";
            this.BTN_email.Size = new System.Drawing.Size(201, 35);
            this.BTN_email.TabIndex = 12;
            this.BTN_email.Text = "Per Email versenden";
            this.BTN_email.UseVisualStyleBackColor = true;
            this.BTN_email.Click += new System.EventHandler(this.BTN_email_Click);
            // 
            // DTG_verbindungen
            // 
            this.DTG_verbindungen.AllowUserToAddRows = false;
            this.DTG_verbindungen.AllowUserToDeleteRows = false;
            this.DTG_verbindungen.AllowUserToResizeRows = false;
            this.DTG_verbindungen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DTG_verbindungen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTG_verbindungen.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DTG_verbindungen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DTG_verbindungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG_verbindungen.Cursor = System.Windows.Forms.Cursors.No;
            this.DTG_verbindungen.Location = new System.Drawing.Point(153, 36);
            this.DTG_verbindungen.Name = "DTG_verbindungen";
            this.DTG_verbindungen.ReadOnly = true;
            this.DTG_verbindungen.RowHeadersVisible = false;
            this.DTG_verbindungen.Size = new System.Drawing.Size(866, 162);
            this.DTG_verbindungen.TabIndex = 0;
            this.DTG_verbindungen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTG_verbindungen_CellContentClick);
            // 
            // PNL_2
            // 
            this.PNL_2.BackColor = System.Drawing.Color.White;
            this.PNL_2.Controls.Add(this.bkbutton2);
            this.PNL_2.Controls.Add(this.LBL_titel_abfahrtstafel);
            this.PNL_2.Controls.Add(this.GRP_result_2);
            this.PNL_2.Controls.Add(this.GRP_suche_2);
            this.PNL_2.Location = new System.Drawing.Point(77, 139);
            this.PNL_2.Margin = new System.Windows.Forms.Padding(4);
            this.PNL_2.Name = "PNL_2";
            this.PNL_2.Size = new System.Drawing.Size(692, 742);
            this.PNL_2.TabIndex = 10;
            // 
            // LBL_titel_abfahrtstafel
            // 
            this.LBL_titel_abfahrtstafel.AutoSize = true;
            this.LBL_titel_abfahrtstafel.Font = new System.Drawing.Font("Arial Narrow", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_titel_abfahrtstafel.Location = new System.Drawing.Point(263, 28);
            this.LBL_titel_abfahrtstafel.Name = "LBL_titel_abfahrtstafel";
            this.LBL_titel_abfahrtstafel.Size = new System.Drawing.Size(163, 57);
            this.LBL_titel_abfahrtstafel.TabIndex = 5;
            this.LBL_titel_abfahrtstafel.Text = "Abfahrt ";
            // 
            // bkbutton
            // 
            this.bkbutton.Location = new System.Drawing.Point(857, 22);
            this.bkbutton.Name = "bkbutton";
            this.bkbutton.Size = new System.Drawing.Size(75, 23);
            this.bkbutton.TabIndex = 6;
            this.bkbutton.Text = "back";
            this.bkbutton.UseVisualStyleBackColor = true;
            this.bkbutton.Click += new System.EventHandler(this.bkbutton_Click);
            // 
            // bkbutton2
            // 
            this.bkbutton2.Location = new System.Drawing.Point(594, 13);
            this.bkbutton2.Name = "bkbutton2";
            this.bkbutton2.Size = new System.Drawing.Size(75, 23);
            this.bkbutton2.TabIndex = 13;
            this.bkbutton2.Text = "back";
            this.bkbutton2.UseVisualStyleBackColor = true;
            this.bkbutton2.Click += new System.EventHandler(this.bkbutton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1422, 943);
            this.Controls.Add(this.PNL_1);
            this.Controls.Add(this.PNL_3);
            this.Controls.Add(this.PNL_2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 990);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1440, 990);
            this.Name = "Form1";
            this.Text = "fahrplan von Noah Lawrence March";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GRP_suche_3.ResumeLayout(false);
            this.GRP_suche_3.PerformLayout();
            this.GRP_suche_2.ResumeLayout(false);
            this.GRP_suche_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_Verbindungen_2)).EndInit();
            this.GRP_result_2.ResumeLayout(false);
            this.PNL_3.ResumeLayout(false);
            this.PNL_1.ResumeLayout(false);
            this.GRP_suche.ResumeLayout(false);
            this.GRP_suche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_switch)).EndInit();
            this.GRP_result.ResumeLayout(false);
            this.GRP_result.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_verbindungen)).EndInit();
            this.PNL_2.ResumeLayout(false);
            this.PNL_2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox LBX_station;
        private System.Windows.Forms.Button BTN_suche_3;
        private System.Windows.Forms.TextBox TXT_station;
        private System.Windows.Forms.WebBrowser WEB_google_maps;
        private System.Windows.Forms.GroupBox GRP_suche_3;
        private System.Windows.Forms.Label LBL_station;
        private System.Windows.Forms.ListBox LBX_von_2;
        private System.Windows.Forms.Button BTN_suche_2;
        private System.Windows.Forms.TextBox BTN_von_2;
        private System.Windows.Forms.Label LBL_von_2;
        private System.Windows.Forms.GroupBox GRP_suche_2;
        private System.Windows.Forms.DataGridView DTG_Verbindungen_2;
        private System.Windows.Forms.GroupBox GRP_result_2;
        private System.Windows.Forms.Button BTN_nav2;
        private System.Windows.Forms.DateTimePicker DTP_zeit;
        private System.Windows.Forms.DateTimePicker DTP_datum;
        private System.Windows.Forms.Button BTN_google_maps;
        private System.Windows.Forms.Label LBL_datum;
        private System.Windows.Forms.Label LBL_zeit;
        private System.Windows.Forms.Panel PNL_3;
        private System.Windows.Forms.Panel PNL_1;
        private System.Windows.Forms.Panel PNL_2;
        private System.Windows.Forms.Label LBL_titel_abfahrtstafel;
        private System.Windows.Forms.Button BTN_close;
        private System.Windows.Forms.Button BTN_email;
        private System.Windows.Forms.TextBox TXT_email;
        private System.Windows.Forms.GroupBox GRP_result;
        private System.Windows.Forms.Label LBL_laden;
        private System.Windows.Forms.DataGridView DTG_verbindungen;
        private System.Windows.Forms.GroupBox GRP_suche;
        private System.Windows.Forms.PictureBox PB_switch;
        private System.Windows.Forms.TextBox TXT_nach;
        private System.Windows.Forms.TextBox TXT_von;
        private System.Windows.Forms.Label LBL_von;
        private System.Windows.Forms.ListBox LBX_von;
        private System.Windows.Forms.Label LBL_nach;
        private System.Windows.Forms.ListBox LBX_nach;
        private System.Windows.Forms.Button BTN_suche;
        private System.Windows.Forms.Button bkbutton;
        private System.Windows.Forms.Button bkbutton2;
    }
}

