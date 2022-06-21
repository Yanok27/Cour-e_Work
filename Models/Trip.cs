namespace Course_work_Cash_Dispatcher.Models;

public class Trip
{
    private int _id;
    private int _tripNumber;
    private Route _route;
    private Ticket _ticket;
    private Dispatcher _dispatcher;
    private Bus _bus;
    private Driver _driver;

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public int TripNumber
    {
        get => _tripNumber;
        set => _tripNumber = value;
    }

    public Route Route
    {
        get => _route;
        set => _route = value;
    }

    public Ticket Ticket
    {
        get => _ticket;
        set => _ticket = value;
    }

    public Dispatcher Dispatcher
    {
        get => _dispatcher;
        set => _dispatcher = value;
    }

    public Bus Bus
    {
        get => _bus;
        set => _bus = value;
    }

    public Driver Driver
    {
        get => _driver;
        set => _driver = value;
    }

   

    public string Destination => Route.Destination;

    public string StartTime => Route.StartTime;

    public string EndTime => Route.EndTime;

    public int Place => Ticket.Place;

    public string Name => Ticket.PassangerName;

    public int Price => Ticket.Price;

    public string DriverName => Driver.Name;

    public string DispatcherName => Dispatcher.Name;

    public string Model => Bus.Model;
}