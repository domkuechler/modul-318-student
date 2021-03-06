﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SwissTransport
{
    [TestClass]
    public class TransportTest
    {
        private ITransport testee;

        [TestMethod]
        public void Locations()
        {
            testee = new Transport();
            var stations = testee.GetStations("Sursee,");

            Assert.AreEqual(10, stations.StationList.Count);
        }

        [TestMethod]
        public void StationBoard()
        {
            testee = new Transport();
            var stationBoard = testee.GetStationBoard("Sursee", "8502007");

            Assert.IsNotNull(stationBoard);
        }

        [TestMethod]
        //Hinzufügen von einem Datum und einer Uhrezeit da ich in GetConnections Datum und zeit hinzugefügt habe
        public void Connections()
        {
            testee = new Transport();
            var connections = testee.GetConnections("Sursee", "Luzern", "20-12-2018", "13:00");

            Assert.IsNotNull(connections);
        }
    }
}
