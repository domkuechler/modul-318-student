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
            this.btbSchliessen = new System.Windows.Forms.Button();
            this.btnAbfahrt = new System.Windows.Forms.Button();
            this.lblGes_Ver = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.dtpZeit = new System.Windows.Forms.DateTimePicker();
            this.lblZeit = new System.Windows.Forms.Label();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.dtgverbindung = new System.Windows.Forms.DataGridView();
            this.txtNach = new System.Windows.Forms.TextBox();
            this.txtVon = new System.Windows.Forms.TextBox();
            this.lblNach = new System.Windows.Forms.Label();
            this.lsbxVon = new System.Windows.Forms.ListBox();
            this.lsbxNach = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgverbindung)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMaps
            // 
            this.btnMaps.Location = new System.Drawing.Point(286, 25);
            this.btnMaps.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnMaps.Name = "btnMaps";
            this.btnMaps.Size = new System.Drawing.Size(209, 47);
            this.btnMaps.TabIndex = 1;
            this.btnMaps.Text = "Google Maps";
            this.btnMaps.UseVisualStyleBackColor = true;
            // 
            // lblVon
            // 
            this.lblVon.AutoSize = true;
            this.lblVon.Location = new System.Drawing.Point(9, 100);
            this.lblVon.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblVon.Name = "lblVon";
            this.lblVon.Size = new System.Drawing.Size(33, 13);
            this.lblVon.TabIndex = 4;
            this.lblVon.Text = "VON:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lsbxNach);
            this.panel1.Controls.Add(this.lsbxVon);
            this.panel1.Controls.Add(this.btbSchliessen);
            this.panel1.Controls.Add(this.btnAbfahrt);
            this.panel1.Controls.Add(this.lblGes_Ver);
            this.panel1.Controls.Add(this.lblDatum);
            this.panel1.Controls.Add(this.dtpZeit);
            this.panel1.Controls.Add(this.lblZeit);
            this.panel1.Controls.Add(this.btnSuchen);
            this.panel1.Controls.Add(this.dtpDatum);
            this.panel1.Controls.Add(this.dtgverbindung);
            this.panel1.Controls.Add(this.txtNach);
            this.panel1.Controls.Add(this.txtVon);
            this.panel1.Controls.Add(this.lblNach);
            this.panel1.Controls.Add(this.lblVon);
            this.panel1.Controls.Add(this.btnMaps);
            this.panel1.Location = new System.Drawing.Point(26, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 472);
            this.panel1.TabIndex = 5;
            // 
            // btbSchliessen
            // 
            this.btbSchliessen.Location = new System.Drawing.Point(409, 436);
            this.btbSchliessen.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btbSchliessen.Name = "btbSchliessen";
            this.btbSchliessen.Size = new System.Drawing.Size(87, 25);
            this.btbSchliessen.TabIndex = 16;
            this.btbSchliessen.Text = "Schliessen";
            this.btbSchliessen.UseVisualStyleBackColor = true;
            // 
            // btnAbfahrt
            // 
            this.btnAbfahrt.Location = new System.Drawing.Point(63, 25);
            this.btnAbfahrt.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnAbfahrt.Name = "btnAbfahrt";
            this.btnAbfahrt.Size = new System.Drawing.Size(220, 47);
            this.btnAbfahrt.TabIndex = 15;
            this.btnAbfahrt.Text = "Abfahrtstabelle";
            this.btnAbfahrt.UseVisualStyleBackColor = true;
            this.btnAbfahrt.Click += new System.EventHandler(this.btnAbfahrt_Click);
            // 
            // lblGes_Ver
            // 
            this.lblGes_Ver.AutoSize = true;
            this.lblGes_Ver.Location = new System.Drawing.Point(224, 204);
            this.lblGes_Ver.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblGes_Ver.Name = "lblGes_Ver";
            this.lblGes_Ver.Size = new System.Drawing.Size(110, 13);
            this.lblGes_Ver.TabIndex = 14;
            this.lblGes_Ver.Text = "Gesuchte Verbindung";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(144, 182);
            this.lblDatum.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(49, 13);
            this.lblDatum.TabIndex = 13;
            this.lblDatum.Text = "DATUM:";
            // 
            // dtpZeit
            // 
            this.dtpZeit.CustomFormat = "HH:mm";
            this.dtpZeit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpZeit.Location = new System.Drawing.Point(61, 180);
            this.dtpZeit.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dtpZeit.Name = "dtpZeit";
            this.dtpZeit.ShowUpDown = true;
            this.dtpZeit.Size = new System.Drawing.Size(62, 20);
            this.dtpZeit.TabIndex = 12;
            // 
            // lblZeit
            // 
            this.lblZeit.AutoSize = true;
            this.lblZeit.Location = new System.Drawing.Point(9, 182);
            this.lblZeit.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblZeit.Name = "lblZeit";
            this.lblZeit.Size = new System.Drawing.Size(34, 13);
            this.lblZeit.TabIndex = 11;
            this.lblZeit.Text = "ZEIT:";
            // 
            // btnSuchen
            // 
            this.btnSuchen.Location = new System.Drawing.Point(397, 178);
            this.btnSuchen.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(99, 20);
            this.btnSuchen.TabIndex = 10;
            this.btnSuchen.Text = "Verbindung suchen";
            this.btnSuchen.UseVisualStyleBackColor = true;
            this.btnSuchen.Click += new System.EventHandler(this.btnSuchen_Click);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(200, 179);
            this.dtpDatum.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(175, 20);
            this.dtpDatum.TabIndex = 9;
            // 
            // dtgverbindung
            // 
            this.dtgverbindung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgverbindung.Location = new System.Drawing.Point(61, 224);
            this.dtgverbindung.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dtgverbindung.Name = "dtgverbindung";
            this.dtgverbindung.RowTemplate.Height = 37;
            this.dtgverbindung.Size = new System.Drawing.Size(619, 199);
            this.dtgverbindung.TabIndex = 8;
            // 
            // txtNach
            // 
            this.txtNach.Location = new System.Drawing.Point(61, 137);
            this.txtNach.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtNach.Multiline = true;
            this.txtNach.Name = "txtNach";
            this.txtNach.Size = new System.Drawing.Size(437, 25);
            this.txtNach.TabIndex = 7;
            this.txtNach.TabStopChanged += new System.EventHandler(this.txtNach_TabStopChanged);
            // 
            // txtVon
            // 
            this.txtVon.Location = new System.Drawing.Point(61, 97);
            this.txtVon.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtVon.Multiline = true;
            this.txtVon.Name = "txtVon";
            this.txtVon.Size = new System.Drawing.Size(437, 25);
            this.txtVon.TabIndex = 6;
            this.txtVon.TextChanged += new System.EventHandler(this.txtVon_TextChanged);
            this.txtVon.Enter += new System.EventHandler(this.txtVon_Enter);
            this.txtVon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVon_KeyDown);
            // 
            // lblNach
            // 
            this.lblNach.AutoSize = true;
            this.lblNach.Location = new System.Drawing.Point(9, 146);
            this.lblNach.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNach.Name = "lblNach";
            this.lblNach.Size = new System.Drawing.Size(40, 13);
            this.lblNach.TabIndex = 5;
            this.lblNach.Text = "NACH:";
            // 
            // lsbxVon
            // 
            this.lsbxVon.FormattingEnabled = true;
            this.lsbxVon.Location = new System.Drawing.Point(60, 123);
            this.lsbxVon.Name = "lsbxVon";
            this.lsbxVon.Size = new System.Drawing.Size(440, 56);
            this.lsbxVon.TabIndex = 17;
            // 
            // lsbxNach
            // 
            this.lsbxNach.FormattingEnabled = true;
            this.lsbxNach.Location = new System.Drawing.Point(60, 161);
            this.lsbxNach.Name = "lsbxNach";
            this.lsbxNach.Size = new System.Drawing.Size(440, 56);
            this.lsbxNach.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 515);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
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
        private System.Windows.Forms.TextBox txtNach;
        private System.Windows.Forms.TextBox txtVon;
        private System.Windows.Forms.Label lblNach;
        private System.Windows.Forms.Button btnSuchen;
        private System.Windows.Forms.Button btbSchliessen;
        private System.Windows.Forms.Button btnAbfahrt;
        private System.Windows.Forms.Label lblGes_Ver;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.DateTimePicker dtpZeit;
        private System.Windows.Forms.Label lblZeit;
        private System.Windows.Forms.ListBox lsbxNach;
        private System.Windows.Forms.ListBox lsbxVon;
    }
}

