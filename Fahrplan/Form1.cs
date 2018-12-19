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

namespace Fahrplan
{
    public partial class Form1 : Form
    {
        Transport transport = new  Transport();
        Coordinate coordinate = new Coordinate();
        private bool Von;
        private bool Nach;
        public Form1()
        {
            InitializeComponent();
            lsbxVon.Visible = false;
            lsbxNach.Visible = false;
        }

        private void Get_Stations(string text)
        {
            if (text.Length >= 3)
            {
                lsbxVon.Items.Clear();
                Stations stations = transport.GetStations(text);
                foreach (Station station in stations.StationList)
                {
                    if (Von == true)
                    {
                        lsbxVon.Items.Add(station.Name);
                        lsbxVon.BringToFront();
                    }

                    if (Nach == true)
                    {
                        lsbxVon.Items.Add(station.Name);
                        lsbxVon.BringToFront();
                    }
                   
                }
            }
            Von = false;
            Nach = false;
        }


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

        private void Get_Grid()
        {
            Cursor.Current = Cursors.WaitCursor;
            //lblladen.Visible = true;
            DataTable dtt_connections = new DataTable();
            dtt_connections.Columns.Add("Datum");
            dtt_connections.Columns.Add("VON");
            dtt_connections.Columns.Add("Abfahrt");
            dtt_connections.Columns.Add("Nach");
            dtt_connections.Columns.Add("Ankunft");
            dtt_connections.Columns.Add("Gleis");

            Connections connections = transport.GetConnections(txtVon.Text, txtNach.Text, dtpDatum.Value.ToString("dd-MM-yyyy"), dtpZeit.Text);

            foreach (Connection connection in connections.ConnectionList)
            {
                dtt_connections.Rows.Add(Get_Date(connection.From.Departure), connection.From.Station.Name, Get_Time(connection.From.Departure), connection.To.Station.Name, Get_Time(connection.To.Arrival), connection.To.Platform);

            }

            dtgverbindung.DataSource = dtt_connections;
            //lblLaden.Visible = false;
            UseWaitCursor = false;
        }

        private void Get_2_Grid()
        {
            DataTable dtt_routes = new DataTable();
            dtt_routes.Columns.Add("Zeit");
            dtt_routes.Columns.Add("Nach");
            dtt_routes.Columns.Add("Linie");


            Station station = transport.GetStations(txtVon.Text).StationList.First();
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

        private void btnSuchen_Click(object sender, EventArgs e)
        {
            if (txtVon.Text != string.Empty)
            {
                Get_Grid();
            }
            else
            {
                MessageBox.Show("Bitte geben Sie zwei Orte ein");
            }
        }

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

        private void txtVon_TextChanged(object sender, EventArgs e)
        {
            Von = true;
            lsbxVon.Items.Clear();
            if (txtVon.Text == "" || txtVon.Text == null)
            {
                lsbxVon.Visible = false;
                lsbxVon.Items.Clear();
            }
            else
            {
                lsbxVon.Visible = true;
            }
            Get_Stations(txtVon.Text);
        }

        private void txtNach_TabStopChanged(object sender, EventArgs e)
        {
            Von = true;
            lsbxNach.Items.Clear();
            if (txtNach.Text == "" || txtNach.Text == null)
            {
                lsbxNach.Visible = false;
                lsbxNach.Items.Clear();
            }
            else
            {
                lsbxNach.Visible = true;
            }
            Get_Stations(txtNach.Text);
        }

        private void txtVon_Enter(object sender, EventArgs e)
        {
            lsbxVon.Visible = true;
            lsbxNach.Visible = false;
        }

        private void txtVon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lsbxVon.Focus();
                lsbxVon.SelectedIndex = -1;
            }
        }
    }
}
