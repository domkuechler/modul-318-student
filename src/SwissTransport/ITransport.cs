namespace SwissTransport
{
    public interface ITransport
    {
        Stations GetStations(string query);
        StationBoardRoot GetStationBoard(string station, string id);
        //Hinzugefügt von date und time
        Connections GetConnections(string fromStation, string toStattion, string date, string time);
    }
}