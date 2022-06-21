namespace Course_work_Cash_Dispatcher.Models;

public class Dispatcher
{
    private int _id;
    private string _name;
    private string _birthDate;
    private string _address;

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public string BirthDate
    {
        get => _birthDate;
        set => _birthDate = value;
    }

    public string Address
    {
        get => _address;
        set => _address = value;
    }

}