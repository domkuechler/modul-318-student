namespace SwissTransport
{
    public interface ITransport
    {
        Stations GetStations(string query);
        StationBoardRoot GetStationBoard(string station, string id);
        //Hinzugefügt von Datum und Zeit
        Connections GetConnections(string fromStation, string toStattion, string date, string time);
    }
}