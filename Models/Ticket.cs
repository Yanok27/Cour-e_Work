namespace Course_work_Cash_Dispatcher.Models;

public class Ticket
{
    private int _id;
    private int _place;
    private int _price;
    private string _buyTime;
    private string _passangerName;
    private int _passId;
    private bool _priv;

    public int Id
    {
        get => _id;
        set => _id = value;
    }
    public int Place
    {
        get => _place;
        set => _place = value;
    }
    public int Price
    {
        get => _price;
        set => _price = value;
    }

    public string BuyTime
    {
        get => _buyTime;
        set=> _buyTime = value;
    }

    public string PassangerName
    {
        get => _passangerName;
        set => _passangerName = value;
    }

    public int PassId
    {
        get => _passId;
        set => _passId = value;
    }

    public bool Priv
    {
        get => _priv;
        set => _priv = value;
    }
}