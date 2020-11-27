using UnityEngine;

public class FruitAdder : MonoBehaviour
{
    
    [SerializeField]
    private FruitMatcher _fruitMatcher;
    
    void Start()
    {
        _fruitMatcher.AddFruit(new Fruit()
        {
            Name = "Apple",
            Juiciness = new MinMax(1, 3),
            Volume = new MinMax(1, 4),
            AmountOfPeople = new MinMax(1, 1)
        });
        
        _fruitMatcher.AddFruit(new Fruit()
        {
            Name = "PineApple",
            Juiciness = new MinMax(10, 15),
            Volume = new MinMax(12, 20),
            AmountOfPeople = new MinMax(4, 8)
        });
        
        _fruitMatcher.AddFruit(new Fruit()
        {
            Name = "Pear",
            Juiciness = new MinMax(15, 20),
            Volume = new MinMax(1, 3),
            AmountOfPeople = new MinMax(1, 1)
        });
        
        _fruitMatcher.AddFruit(new Fruit()
        {
            Name = "Melon",
            Juiciness = new MinMax(12, 18),
            Volume = new MinMax(12, 20),
            AmountOfPeople = new MinMax(4, 8)
        });
        
    }

}
