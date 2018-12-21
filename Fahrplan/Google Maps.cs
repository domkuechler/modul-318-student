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
        private bool location;
        private string url;
        public Form2()
        {
            InitializeComponent();

            lsbxStation.Visible = false;
        }

        #region station
        //Methode um die Stationen zu suchen
        private void GetStations(string text)
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
        #endregion

        #region Ergonimie

        //Automatische vervollständigung
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
            GetStations(txtStation.Text);
        }

        //von von textbox auf Listbox zugreifen mittels Tastatur
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

        //
        private void txtStation_Enter(object sender, EventArgs e)
        {
            lsbxStation.Visible = true;
        }

        //Wählt die gewählte Station und schreibt si in die Textbox
        private void lsbxStation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtStation.Text = Convert.ToString(lsbxStation.SelectedItem);
                lsbxStation.Visible = false;
                btnSuchen.Focus();
            }
        }

        private void lsbxStation_DoubleClick(object sender, EventArgs e)
        {
            txtStation.Text = Convert.ToString(lsbxStation.SelectedItem);
            lsbxStation.Visible = false;
            btnSuchen.Focus();
        }

        #endregion

        #region Map
        //Erstellt ein Gmap für die gesuchte Station
        private void CreateGmapStation(string x, string y)
        {
            if (location != true)
            {
                url = "https://www.google.ch/maps/place/" + x + "," + y;
                webGoogle.Navigate(url);
            }
            else
            {
                string url = "https://www.google.ch/maps/search/transit+stop+near";
                webGoogle.Navigate(url);
            }
        }



        #endregion

        #region Events

        //Ruft die methode Gmap auf um
        private void btnSuchen_Click(object sender, EventArgs e)
        {
            location = false;
            if (txtStation.Text != string.Empty)
            {
                Stations stations = transport.GetStations(txtStation.Text);
                Station station = stations.StationList[0];
                CreateGmapStation(Convert.ToString(station.Coordinate.XCoordinate).Replace(',', '.'), Convert.ToString(station.Coordinate.YCoordinate).Replace(',', '.'));
            }
            else
            {
                MessageBox.Show("Bitte geben Sie einen Ort ein!");
            }
        }

        private void btbStationen_Click(object sender, EventArgs e)
        {
            location = true;
            CreateGmapStation("5","4");
            lsbxStation.Visible = false;
        }

        private void btbSchliessen_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       

        private void btnWeb_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch 
            {
                MessageBox.Show("Es wurde keine Station angegeben");
            }
            
        }
        #endregion
    }
}
