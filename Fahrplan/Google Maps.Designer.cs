namespace Fahrplan
{
    partial class Form2
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
            this.btbSuchen = new System.Windows.Forms.Panel();
            this.lsbxStation = new System.Windows.Forms.ListBox();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.webGoogle = new System.Windows.Forms.WebBrowser();
            this.txtStation = new System.Windows.Forms.TextBox();
            this.lblStation = new System.Windows.Forms.Label();
            this.btbStationen = new System.Windows.Forms.Button();
            this.btbSchliessen = new System.Windows.Forms.Button();
            this.btnWeb = new System.Windows.Forms.Button();
            this.btbSuchen.SuspendLayout();
            this.SuspendLayout();
            // 
            // btbSuchen
            // 
            this.btbSuchen.Controls.Add(this.btnWeb);
            this.btbSuchen.Controls.Add(this.btbSchliessen);
            this.btbSuchen.Controls.Add(this.btbStationen);
            this.btbSuchen.Controls.Add(this.lsbxStation);
            this.btbSuchen.Controls.Add(this.btnSuchen);
            this.btbSuchen.Controls.Add(this.webGoogle);
            this.btbSuchen.Controls.Add(this.txtStation);
            this.btbSuchen.Controls.Add(this.lblStation);
            this.btbSuchen.Location = new System.Drawing.Point(16, 45);
            this.btbSuchen.Margin = new System.Windows.Forms.Padding(7);
            this.btbSuchen.Name = "btbSuchen";
            this.btbSuchen.Size = new System.Drawing.Size(1815, 1110);
            this.btbSuchen.TabIndex = 0;
            // 
            // lsbxStation
            // 
            this.lsbxStation.FormattingEnabled = true;
            this.lsbxStation.ItemHeight = 29;
            this.lsbxStation.Location = new System.Drawing.Point(112, 169);
            this.lsbxStation.Margin = new System.Windows.Forms.Padding(7);
            this.lsbxStation.Name = "lsbxStation";
            this.lsbxStation.Size = new System.Drawing.Size(1154, 178);
            this.lsbxStation.TabIndex = 4;
            this.lsbxStation.Visible = false;
            this.lsbxStation.DoubleClick += new System.EventHandler(this.lsbxStation_DoubleClick);
            this.lsbxStation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lsbxStation_KeyDown);
            // 
            // btnSuchen
            // 
            this.btnSuchen.Location = new System.Drawing.Point(1318, 132);
            this.btnSuchen.Margin = new System.Windows.Forms.Padding(7);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(347, 66);
            this.btnSuchen.TabIndex = 3;
            this.btnSuchen.Text = "Suchen";
            this.btnSuchen.UseVisualStyleBackColor = true;
            this.btnSuchen.Click += new System.EventHandler(this.btnSuchen_Click);
            // 
            // webGoogle
            // 
            this.webGoogle.Location = new System.Drawing.Point(112, 235);
            this.webGoogle.Margin = new System.Windows.Forms.Padding(7);
            this.webGoogle.MinimumSize = new System.Drawing.Size(47, 45);
            this.webGoogle.Name = "webGoogle";
            this.webGoogle.Size = new System.Drawing.Size(1553, 663);
            this.webGoogle.TabIndex = 2;
            // 
            // txtStation
            // 
            this.txtStation.Location = new System.Drawing.Point(112, 133);
            this.txtStation.Margin = new System.Windows.Forms.Padding(7);
            this.txtStation.Name = "txtStation";
            this.txtStation.Size = new System.Drawing.Size(1154, 35);
            this.txtStation.TabIndex = 1;
            this.txtStation.TextChanged += new System.EventHandler(this.txtStation_TextChanged);
            this.txtStation.Enter += new System.EventHandler(this.txtStation_Enter);
            this.txtStation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStation_KeyDown);
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Location = new System.Drawing.Point(7, 136);
            this.lblStation.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(87, 29);
            this.lblStation.TabIndex = 0;
            this.lblStation.Text = "Station";
            // 
            // btbStationen
            // 
            this.btbStationen.Location = new System.Drawing.Point(1318, 39);
            this.btbStationen.Margin = new System.Windows.Forms.Padding(7);
            this.btbStationen.Name = "btbStationen";
            this.btbStationen.Size = new System.Drawing.Size(347, 65);
            this.btbStationen.TabIndex = 5;
            this.btbStationen.Text = "Stationen";
            this.btbStationen.UseVisualStyleBackColor = true;
            this.btbStationen.Click += new System.EventHandler(this.btbStationen_Click);
            // 
            // btbSchliessen
            // 
            this.btbSchliessen.Location = new System.Drawing.Point(965, 962);
            this.btbSchliessen.Name = "btbSchliessen";
            this.btbSchliessen.Size = new System.Drawing.Size(700, 74);
            this.btbSchliessen.TabIndex = 6;
            this.btbSchliessen.Text = "Schliessen";
            this.btbSchliessen.UseVisualStyleBackColor = true;
            this.btbSchliessen.Click += new System.EventHandler(this.btbSchliessen_Click);
            // 
            // btnWeb
            // 
            this.btnWeb.Location = new System.Drawing.Point(112, 962);
            this.btnWeb.Name = "btnWeb";
            this.btnWeb.Size = new System.Drawing.Size(700, 74);
            this.btnWeb.TabIndex = 7;
            this.btnWeb.Text = "Web Ansicht";
            this.btnWeb.UseVisualStyleBackColor = true;
            this.btnWeb.Click += new System.EventHandler(this.btnWeb_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1867, 1193);
            this.ControlBox = false;
            this.Controls.Add(this.btbSuchen);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.btbSuchen.ResumeLayout(false);
            this.btbSuchen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel btbSuchen;
        private System.Windows.Forms.Button btnSuchen;
        private System.Windows.Forms.WebBrowser webGoogle;
        private System.Windows.Forms.TextBox txtStation;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.ListBox lsbxStation;
        private System.Windows.Forms.Button btbStationen;
        private System.Windows.Forms.Button btbSchliessen;
        private System.Windows.Forms.Button btnWeb;
    }
}