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
            this.btbSuchen.SuspendLayout();
            this.SuspendLayout();
            // 
            // btbSuchen
            // 
            this.btbSuchen.Controls.Add(this.lsbxStation);
            this.btbSuchen.Controls.Add(this.btnSuchen);
            this.btbSuchen.Controls.Add(this.webGoogle);
            this.btbSuchen.Controls.Add(this.txtStation);
            this.btbSuchen.Controls.Add(this.lblStation);
            this.btbSuchen.Location = new System.Drawing.Point(89, 45);
            this.btbSuchen.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btbSuchen.Name = "btbSuchen";
            this.btbSuchen.Size = new System.Drawing.Size(1678, 932);
            this.btbSuchen.TabIndex = 0;
            // 
            // lsbxStation
            // 
            this.lsbxStation.FormattingEnabled = true;
            this.lsbxStation.ItemHeight = 29;
            this.lsbxStation.Location = new System.Drawing.Point(220, 166);
            this.lsbxStation.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.lsbxStation.Name = "lsbxStation";
            this.lsbxStation.Size = new System.Drawing.Size(1149, 178);
            this.lsbxStation.TabIndex = 4;
            this.lsbxStation.Visible = false;
            this.lsbxStation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lsbxStation_KeyDown);
            // 
            // btnSuchen
            // 
            this.btnSuchen.Location = new System.Drawing.Point(1388, 127);
            this.btnSuchen.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(238, 51);
            this.btnSuchen.TabIndex = 3;
            this.btnSuchen.Text = "Suchen";
            this.btnSuchen.UseVisualStyleBackColor = true;
            this.btnSuchen.Click += new System.EventHandler(this.btnSuchen_Click);
            // 
            // webGoogle
            // 
            this.webGoogle.Location = new System.Drawing.Point(215, 228);
            this.webGoogle.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.webGoogle.MinimumSize = new System.Drawing.Size(47, 45);
            this.webGoogle.Name = "webGoogle";
            this.webGoogle.Size = new System.Drawing.Size(1412, 663);
            this.webGoogle.TabIndex = 2;
            // 
            // txtStation
            // 
            this.txtStation.Location = new System.Drawing.Point(215, 127);
            this.txtStation.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
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
            this.lblStation.Location = new System.Drawing.Point(107, 134);
            this.lblStation.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(87, 29);
            this.lblStation.TabIndex = 0;
            this.lblStation.Text = "Station";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1867, 1004);
            this.Controls.Add(this.btbSuchen);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
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
    }
}