using UnityEngine;

public class Fruit
{

    private string _name;
    private GameObject _prefab;
    private MinMax _volume;
    private MinMax _juiciness;
    private MinMax _amountOfPeople;

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public GameObject Prefab
    {
        get => _prefab;
        set => _prefab = value;
    }

    public MinMax Volume
    {
        get => _volume;
        set => _volume = value;
    }

    public MinMax Juiciness
    {
        get => _juiciness;
        set => _juiciness = value;
    }

    public MinMax AmountOfPeople
    {
        get => _amountOfPeople;
        set => _amountOfPeople = value;
    }
    
}
