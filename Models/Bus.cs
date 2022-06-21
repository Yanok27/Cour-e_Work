namespace Course_work_Cash_Dispatcher.Models;

public class Bus
{
    private int _id;
    private int _number;
    private string _model;
    private int _placeCount;

    public int Id
    {
        get=> _id;
        set=> _id = value;
    }

    public int Number
    {
        get => _number;
        set => _number = value;
    }
    public string Model
    {
        get => _model;
        set => _model = value;
    }

    public int PlaceCount
    {
        get => _placeCount;
        set => _placeCount = value;
    }
}