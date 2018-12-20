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
    public partial class Form2 : Form
    {
        Transport transport = new Transport();
        Coordinate coordinate = new Coordinate();
        private bool Station;
        public Form2()
        {
            InitializeComponent();

            lsbxStation.Visible = false;
        }
        private void Get_Stations(string text)
        {
            try
            {
                if (text.Length >= 3)
                {
                    lsbxStation.Items.Clear();
                    Stations stations = transport.GetStations(text);
                    foreach (Station station in stations.StationList)
                    {
                        if (Station == true)
                        {
                            lsbxStation.Items.Add(station.Name);
                            lsbxStation.BringToFront();
                        }

                    }
                }

                Station = false;
                
            }
            catch
            {
                MessageBox.Show("Es konnte keine Verbindung hergestellt werden überprüfen sie die Internet verbindung");
            }
        }
        private void Create_GmapStation(string x, string y)
        {
            string url = "https://www.google.ch/maps/place/" + x + "," + y;
            webGoogle.Navigate(url);
        }


       

        private void txtStation_TextChanged(object sender, EventArgs e)
        {
            Station = true;
            lsbxStation.Items.Clear();
            if (txtStation.Text == "" || txtStation.Text == null)
            {
                lsbxStation.Visible = false;
                lsbxStation.Items.Clear();
            }
            else
            {
                lsbxStation.Visible = true;
            }
            Get_Stations(txtStation.Text);
        }

        private void txtStation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && lsbxStation.SelectedIndex < lsbxStation.Items.Count - 1)
            {
                lsbxStation.Focus();
                lsbxStation.SelectedIndex++;
            }

            if (e.KeyCode == Keys.Up && lsbxStation.SelectedIndex > 0)
            {
                lsbxStation.Focus();
                lsbxStation.SelectedIndex--;
            }
        }

        private void txtStation_Enter(object sender, EventArgs e)
        {
            lsbxStation.Visible = true;
        }

        private void lsbxStation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtStation.Text = Convert.ToString(lsbxStation.SelectedItem);
                lsbxStation.Visible = false;
                btnSuchen.Focus();
            }
        }

        private void btnSuchen_Click(object sender, EventArgs e)
        {
            if (txtStation.Text != string.Empty)
            {
                Stations stations = transport.GetStations(txtStation.Text);
                Station station = stations.StationList[0];
                Create_GmapStation(Convert.ToString(station.Coordinate.XCoordinate).Replace(',', '.'), Convert.ToString(station.Coordinate.YCoordinate).Replace(',', '.'));
            }
            else
            {
                MessageBox.Show("Bitte geben Sie einen Ort ein!");
            }
        }
    }
}
