namespace Course_work_Cash_Dispatcher.Models;

public class Route
{
    private int _id;
    private int _routeNumber;
    private string _destination;
    private string _region;
    private string _district;
    private int _distance;
    private int _importance;
    private string _startTime;
    private string _endTime;

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public int RouteNumber
    {
        get => _routeNumber;
        set => _routeNumber = value;
    }

    public string Destination
    {
        get => _destination;
        set => _destination = value;
    }

    public string Region
    {
        get => _region;
        set => _region = value;
    }

    public string District
    {
        get => _district;
        set => _district = value;
    }

    public int Distance
    {
        get => _distance;
        set => _distance = value;
    }

    public int Importance
    {
        get => _importance;
        set => _importance = value;
    }

    public string StartTime
    {
        get => _startTime;
        set => _startTime = value;
    }

    public string EndTime
    {
        get => _endTime;
        set => _endTime = value;
    }
}