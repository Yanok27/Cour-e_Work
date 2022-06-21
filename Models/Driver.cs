namespace Course_work_Cash_Dispatcher.Models;

public class Driver
{
    private int _id;
    private string _name;
    private string _birthDate;
    private int _passId;

    public int Id
    {
        get => _id; 
        set => _id = value;
    }

    public string Name
    {
        get=> _name;
        set => _name = value;
    }

    public string BirthDate
    {
        get => _birthDate;
        set => _birthDate = value;
    }

    public int PassId
    {
        get=> _passId;
        set => _passId = value;
    }

}