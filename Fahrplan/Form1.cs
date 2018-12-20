using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;
using System.Net.Mail;

namespace Fahrplan
{
    public partial class Form1 : Form
    {
        Transport transport = new  Transport();
        Coordinate coordinate = new Coordinate();
        Form2 Maps = new Form2();
        private bool Von;
        private bool Nach;
        public Form1()
        {
            InitializeComponent();
            lsbxSuche_Von.Visible = false;
            lsbxSuche_Nache.Visible = false;
        }

        //Sucht die Station
        private void Get_Stations(string text)
        {
            try
            {
                if (text.Length >= 3)
                {
                    lsbxSuche_Von.Items.Clear();
                    Stations stations = transport.GetStations(text);
                    foreach (Station station in stations.StationList)
                    {
                        if (Von == true)
                        {
                            lsbxSuche_Von.Items.Add(station.Name);
                            lsbxSuche_Von.BringToFront();
                        }

                        if (Nach == true)
                        {
                            lsbxSuche_Nache.Items.Add(station.Name);
                            lsbxSuche_Nache.BringToFront();
                        }

                    }
                }

                Von = false;
                Nach = false;
            }
            catch
            {
                MessageBox.Show("Es konnte keine Station gefunden werden");
            }
        }

        //Definiert die Werte für das DataGridView
        public string Get_TableFromDataGrid()
        {
            StringBuilder strTable = new StringBuilder();
            try
            {
                strTable.Append(("<table border='1 cellpadding='0' cellspacing='0'>"));
                strTable.Append("<tr>");
                foreach (DataGridViewColumn col in dtgverbindung.Columns)
                {
                    
                    strTable.AppendFormat("<th>{0}</td>", col.HeaderText);
                }

                strTable.Append("</tr>");
                for (int i = 0; i < dtgverbindung.RowCount; i++)
                {
                    strTable.Append("<tr>");
                    foreach (DataGridViewCell cell in dtgverbindung.Rows[i].Cells) 
                    {
                        if (cell.Value != null)
                        {
                            strTable.AppendFormat("<td>{0}</td>", cell.Value.ToString());
                        }
                    }

                    strTable.Append("</tr>");
                }

                strTable.Append("</table>");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: + ex.Message");
            }

            return strTable.ToString();
        }

        //Methoden zum auslesen der gesuchten verbindung
        private void Get_Grid()
        {
            Cursor.Current = Cursors.WaitCursor;
            DataTable dtt_connections = new DataTable();
            dtt_connections.Columns.Add("Datum");
            dtt_connections.Columns.Add("Von");
            dtt_connections.Columns.Add("Abfahrt");
            dtt_connections.Columns.Add("Nach");
            dtt_connections.Columns.Add("Ankunft");
            dtt_connections.Columns.Add("Gleis");

            Connections connections = transport.GetConnections(txtSuche_Von.Text, txtSuche_Nach.Text, dtpDatum.Value.ToString("dd-MM-yyyy"), dtpZeit.Text);

            foreach (Connection connection in connections.ConnectionList)
            {
                dtt_connections.Rows.Add(Get_Date(connection.From.Departure), connection.From.Station.Name, Get_Time(connection.From.Departure), connection.To.Station.Name, Get_Time(connection.To.Arrival), connection.To.Platform);

            }

            dtgverbindung.DataSource = dtt_connections;
            UseWaitCursor = false;
        }

        //Methode zum auslesen der Verbindungen für die Abfahrtstabelle
        private void Get_2_Grid()
        {
            DataTable dtt_routes = new DataTable();
            dtt_routes.Columns.Add("Zeit");
            dtt_routes.Columns.Add("Nach");
            dtt_routes.Columns.Add("Linie");


            Station station = transport.GetStations(txtSuche_Von.Text).StationList.First();
            StationBoardRoot departures = transport.GetStationBoard(station.Name, station.Id);

            foreach (StationBoard station_b in departures.Entries)
            {
                dtt_routes.Rows.Add(Get_Time(station_b.Stop.Departure.ToString()), station_b.To, (station_b.Category + " " + station_b.Number ));
            }

            dtgverbindung.DataSource = dtt_routes;
        }


        private string Get_Date(string date1)
        {
            string date2 = date1.Remove(10);
            DateTime date3 = Convert.ToDateTime(date2);
            return date3.ToString("dd.MM.yyyy");
        }

        private string Get_Time(string time1)
        {
            string time2 = time1.Remove(0, 11);
            time2 = time2.Remove(5);
            return time2;
        }

        //Event der die Methode Get_Grid aufruft zum anzeigen der gewählten verbindung im DataGridView
        private void btnSuchen_Click(object sender, EventArgs e)
        {
            if (txtSuche_Von.Text != string.Empty)
            {
                Get_Grid();
            }
            else
            {
                MessageBox.Show("Bitte geben Sie zwei Orte ein");
            }
        }

        //Event der die Methode Get_2_Grid aufruft zum anzeigen der Abfahrtstafel im DataGridView
        private void btnAbfahrt_Click(object sender, EventArgs e)
        {
            if (btnAbfahrt.Text != string.Empty)
            {
                Get_2_Grid();
            }
            else
            {
                MessageBox.Show("Bitte geben Sie einen Ort ein");
            }
        }

        //Öffnet das Form2 zum aufrufen von Gmap
        private void btnMaps_Click(object sender, EventArgs e)
        {
            Maps.Show();
        }

        //Event zum senden einer E-Mail an eine E-mail Adresse
        private void btbEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
                MessageBox.Show("Bitte geben Sie eine Email-Adresse ein!");
            else
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("modul318.andreas@gmail.com");
                    mail.To.Add(new MailAddress(Convert.ToString(this.txtEmail)));
                    mail.Subject = "Fahrplan";
                    mail.Body = "Hallo, hier ein Fahrplan, den ich mit dir teilen wollte. ";
                    mail.Body += "<b>" + Get_TableFromDataGrid() + "</b>";
                    mail.IsBodyHtml = true;
                    SmtpClient SmtpServer = new SmtpClient();
                    SmtpServer.Host = "smtp.gmail.com";
                    SmtpServer.Port = 587;
                    SmtpServer.Credentials =
                        new System.Net.NetworkCredential("m318.domkuechler@gmail.com", "P@ssw0rd$11");
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Send(mail);
                    MessageBox.Show("Email wurde erfolgreich gesendet");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void txtSuche_Von_TextChanged(object sender, EventArgs e)
        {
            Von = true;
            lsbxSuche_Von.Items.Clear();
            if (txtSuche_Von.Text == "" || txtSuche_Von.Text == null)
            {
                lsbxSuche_Von.Visible = false;
                lsbxSuche_Von.Items.Clear();
            }
            else
            {
                lsbxSuche_Von.Visible = true;
            }
            Get_Stations(txtSuche_Von.Text);
        }

        private void txtSuche_Von_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && lsbxSuche_Von.SelectedIndex < lsbxSuche_Von.Items.Count - 1)
            {
                lsbxSuche_Von.Focus();
                lsbxSuche_Von.SelectedIndex++;
            }

            if (e.KeyCode == Keys.Up && lsbxSuche_Von.SelectedIndex > 0)
            {
                lsbxSuche_Von.Focus();
                lsbxSuche_Von.SelectedIndex--;
            }
        }

        private void txtSuche_Von_Enter(object sender, EventArgs e)
        {
            lsbxSuche_Von.Visible = true;
            lsbxSuche_Nache.Visible = false;
        }

        private void lsbxSuche_Von_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSuche_Von.Text = Convert.ToString(lsbxSuche_Von.SelectedItem);
                lsbxSuche_Von.Visible = false;
                txtSuche_Nach.Focus();
            }
        }

        private void txtSuche_Nach_TextChanged(object sender, EventArgs e)
        {
            Nach = true;
            lsbxSuche_Nache.Items.Clear();
            if (txtSuche_Von.Text == "" || txtSuche_Von.Text == null)
            {
                lsbxSuche_Nache.Visible = false;
                lsbxSuche_Nache.Items.Clear();
            }
            else
            {
                lsbxSuche_Nache.Visible = true;

            }
            Get_Stations(txtSuche_Nach.Text);
        }

        private void txtSuche_Nach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && lsbxSuche_Nache.SelectedIndex < lsbxSuche_Nache.Items.Count - 1)
            {
                lsbxSuche_Nache.Focus();
                lsbxSuche_Nache.SelectedIndex++;
            }

            if (e.KeyCode == Keys.Up && lsbxSuche_Nache.SelectedIndex > 0)
            {
                lsbxSuche_Nache.Focus();
                lsbxSuche_Nache.SelectedIndex--;
            }
        }

        private void txtSuche_Nach_Enter(object sender, EventArgs e)
        {
            lsbxSuche_Von.Visible = false;
            lsbxSuche_Nache.Visible = true;
        }

        private void lsbxSuche_Nache_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSuche_Nach.Text = Convert.ToString(lsbxSuche_Nache.SelectedItem);
                lsbxSuche_Nache.Visible = false;
                btnSuchen.Focus();
            }
        }
    }
}
