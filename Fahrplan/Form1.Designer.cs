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
            this.btnMaps = new System.Windows.Forms.Button();
            this.lblVon = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lsbxSuche_Nache = new System.Windows.Forms.ListBox();
            this.lsbxSuche_Von = new System.Windows.Forms.ListBox();
            this.txtSuche_Nach = new System.Windows.Forms.TextBox();
            this.txtSuche_Von = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btbEmail = new System.Windows.Forms.Button();
            this.btbSchliessen = new System.Windows.Forms.Button();
            this.btnAbfahrt = new System.Windows.Forms.Button();
            this.lblDatum = new System.Windows.Forms.Label();
            this.dtpZeit = new System.Windows.Forms.DateTimePicker();
            this.lblZeit = new System.Windows.Forms.Label();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.dtgverbindung = new System.Windows.Forms.DataGridView();
            this.lblNach = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgverbindung)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMaps
            // 
            this.btnMaps.Location = new System.Drawing.Point(844, 40);
            this.btnMaps.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaps.Name = "btnMaps";
            this.btnMaps.Size = new System.Drawing.Size(462, 105);
            this.btnMaps.TabIndex = 6;
            this.btnMaps.Text = "Google Maps";
            this.btnMaps.UseVisualStyleBackColor = true;
            this.btnMaps.Click += new System.EventHandler(this.btnMaps_Click);
            // 
            // lblVon
            // 
            this.lblVon.AutoSize = true;
            this.lblVon.Location = new System.Drawing.Point(142, 234);
            this.lblVon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVon.Name = "lblVon";
            this.lblVon.Size = new System.Drawing.Size(61, 29);
            this.lblVon.TabIndex = 4;
            this.lblVon.Text = "Von:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lsbxSuche_Nache);
            this.panel1.Controls.Add(this.lsbxSuche_Von);
            this.panel1.Controls.Add(this.txtSuche_Nach);
            this.panel1.Controls.Add(this.txtSuche_Von);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.btbEmail);
            this.panel1.Controls.Add(this.btbSchliessen);
            this.panel1.Controls.Add(this.btnAbfahrt);
            this.panel1.Controls.Add(this.lblDatum);
            this.panel1.Controls.Add(this.dtpZeit);
            this.panel1.Controls.Add(this.lblZeit);
            this.panel1.Controls.Add(this.btnSuchen);
            this.panel1.Controls.Add(this.dtpDatum);
            this.panel1.Controls.Add(this.dtgverbindung);
            this.panel1.Controls.Add(this.lblNach);
            this.panel1.Controls.Add(this.lblVon);
            this.panel1.Controls.Add(this.btnMaps);
            this.panel1.Location = new System.Drawing.Point(61, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2015, 1201);
            this.panel1.TabIndex = 5;
            // 
            // lsbxSuche_Nache
            // 
            this.lsbxSuche_Nache.FormattingEnabled = true;
            this.lsbxSuche_Nache.ItemHeight = 29;
            this.lsbxSuche_Nache.Location = new System.Drawing.Point(844, 260);
            this.lsbxSuche_Nache.Name = "lsbxSuche_Nache";
            this.lsbxSuche_Nache.Size = new System.Drawing.Size(462, 62);
            this.lsbxSuche_Nache.TabIndex = 27;
            this.lsbxSuche_Nache.Visible = false;
            this.lsbxSuche_Nache.DoubleClick += new System.EventHandler(this.lsbxSuche_Nache_DoubleClick);
            this.lsbxSuche_Nache.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lsbxSuche_Nache_KeyDown);
            // 
            // lsbxSuche_Von
            // 
            this.lsbxSuche_Von.FormattingEnabled = true;
            this.lsbxSuche_Von.ItemHeight = 29;
            this.lsbxSuche_Von.Location = new System.Drawing.Point(218, 260);
            this.lsbxSuche_Von.Name = "lsbxSuche_Von";
            this.lsbxSuche_Von.Size = new System.Drawing.Size(442, 62);
            this.lsbxSuche_Von.TabIndex = 26;
            this.lsbxSuche_Von.Visible = false;
            this.lsbxSuche_Von.DoubleClick += new System.EventHandler(this.lsbxSuche_Von_DoubleClick);
            this.lsbxSuche_Von.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lsbxSuche_Von_KeyDown);
            // 
            // txtSuche_Nach
            // 
            this.txtSuche_Nach.Location = new System.Drawing.Point(844, 222);
            this.txtSuche_Nach.Multiline = true;
            this.txtSuche_Nach.Name = "txtSuche_Nach";
            this.txtSuche_Nach.Size = new System.Drawing.Size(462, 41);
            this.txtSuche_Nach.TabIndex = 2;
            this.txtSuche_Nach.TextChanged += new System.EventHandler(this.txtSuche_Nach_TextChanged);
            this.txtSuche_Nach.Enter += new System.EventHandler(this.txtSuche_Nach_Enter);
            this.txtSuche_Nach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSuche_Nach_KeyDown);
            // 
            // txtSuche_Von
            // 
            this.txtSuche_Von.Location = new System.Drawing.Point(218, 222);
            this.txtSuche_Von.Multiline = true;
            this.txtSuche_Von.Name = "txtSuche_Von";
            this.txtSuche_Von.Size = new System.Drawing.Size(442, 41);
            this.txtSuche_Von.TabIndex = 1;
            this.txtSuche_Von.TextChanged += new System.EventHandler(this.txtSuche_Von_TextChanged);
            this.txtSuche_Von.Enter += new System.EventHandler(this.txtSuche_Von_Enter);
            this.txtSuche_Von.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSuche_Von_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1423, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "E-Mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(1532, 346);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(431, 35);
            this.txtEmail.TabIndex = 4;
            // 
            // btbEmail
            // 
            this.btbEmail.Location = new System.Drawing.Point(1532, 413);
            this.btbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.btbEmail.Name = "btbEmail";
            this.btbEmail.Size = new System.Drawing.Size(431, 92);
            this.btbEmail.TabIndex = 5;
            this.btbEmail.Text = "E-Mail senden";
            this.btbEmail.UseVisualStyleBackColor = true;
            this.btbEmail.Click += new System.EventHandler(this.btbEmail_Click);
            // 
            // btbSchliessen
            // 
            this.btbSchliessen.Location = new System.Drawing.Point(727, 1055);
            this.btbSchliessen.Margin = new System.Windows.Forms.Padding(2);
            this.btbSchliessen.Name = "btbSchliessen";
            this.btbSchliessen.Size = new System.Drawing.Size(579, 112);
            this.btbSchliessen.TabIndex = 9;
            this.btbSchliessen.Text = "Schliessen";
            this.btbSchliessen.UseVisualStyleBackColor = true;
            this.btbSchliessen.Click += new System.EventHandler(this.btbSchliessen_Click);
            // 
            // btnAbfahrt
            // 
            this.btnAbfahrt.Location = new System.Drawing.Point(218, 40);
            this.btnAbfahrt.Margin = new System.Windows.Forms.Padding(2);
            this.btnAbfahrt.Name = "btnAbfahrt";
            this.btnAbfahrt.Size = new System.Drawing.Size(442, 105);
            this.btnAbfahrt.TabIndex = 7;
            this.btnAbfahrt.Text = "Abfahrtstabelle";
            this.btnAbfahrt.UseVisualStyleBackColor = true;
            this.btnAbfahrt.Click += new System.EventHandler(this.btnAbfahrt_Click);
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(719, 364);
            this.lblDatum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(88, 29);
            this.lblDatum.TabIndex = 13;
            this.lblDatum.Text = "Datum:";
            // 
            // dtpZeit
            // 
            this.dtpZeit.CustomFormat = "HH:mm";
            this.dtpZeit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpZeit.Location = new System.Drawing.Point(218, 356);
            this.dtpZeit.Margin = new System.Windows.Forms.Padding(2);
            this.dtpZeit.Name = "dtpZeit";
            this.dtpZeit.ShowUpDown = true;
            this.dtpZeit.Size = new System.Drawing.Size(139, 35);
            this.dtpZeit.TabIndex = 12;
            // 
            // lblZeit
            // 
            this.lblZeit.AutoSize = true;
            this.lblZeit.Location = new System.Drawing.Point(142, 362);
            this.lblZeit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZeit.Name = "lblZeit";
            this.lblZeit.Size = new System.Drawing.Size(59, 29);
            this.lblZeit.TabIndex = 11;
            this.lblZeit.Text = "Zeit:";
            // 
            // btnSuchen
            // 
            this.btnSuchen.Location = new System.Drawing.Point(1532, 202);
            this.btnSuchen.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(431, 92);
            this.btnSuchen.TabIndex = 3;
            this.btnSuchen.Text = "Verbindung suchen";
            this.btnSuchen.UseVisualStyleBackColor = true;
            this.btnSuchen.Click += new System.EventHandler(this.btnSuchen_Click);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(844, 356);
            this.dtpDatum.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(462, 35);
            this.dtpDatum.TabIndex = 9;
            // 
            // dtgverbindung
            // 
            this.dtgverbindung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgverbindung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgverbindung.Location = new System.Drawing.Point(147, 538);
            this.dtgverbindung.Margin = new System.Windows.Forms.Padding(2);
            this.dtgverbindung.Name = "dtgverbindung";
            this.dtgverbindung.RowTemplate.Height = 37;
            this.dtgverbindung.Size = new System.Drawing.Size(1830, 467);
            this.dtgverbindung.TabIndex = 8;
            // 
            // lblNach
            // 
            this.lblNach.AutoSize = true;
            this.lblNach.Location = new System.Drawing.Point(737, 234);
            this.lblNach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNach.Name = "lblNach";
            this.lblNach.Size = new System.Drawing.Size(75, 29);
            this.lblNach.TabIndex = 5;
            this.lblNach.Text = "Nach:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2140, 1328);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(2168, 1407);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgverbindung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMaps;
        private System.Windows.Forms.Label lblVon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.DataGridView dtgverbindung;
        private System.Windows.Forms.Label lblNach;
        private System.Windows.Forms.Button btnSuchen;
        private System.Windows.Forms.Button btbSchliessen;
        private System.Windows.Forms.Button btnAbfahrt;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.DateTimePicker dtpZeit;
        private System.Windows.Forms.Label lblZeit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btbEmail;
        private System.Windows.Forms.ListBox lsbxSuche_Nache;
        private System.Windows.Forms.ListBox lsbxSuche_Von;
        private System.Windows.Forms.TextBox txtSuche_Nach;
        private System.Windows.Forms.TextBox txtSuche_Von;
    }
}

