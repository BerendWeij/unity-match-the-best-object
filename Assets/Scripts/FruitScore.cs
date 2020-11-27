public class FruitScore
{
    private Fruit _targetFruit;
    private float _score = 0f;
    
    public Fruit TargetFruit
    {
        get => _targetFruit;
        set => _targetFruit = value;
    }

    public float Score
    {
        get => _score;
        set => _score = value;
    }

    public FruitScore(Fruit targetFruit)
    {
        TargetFruit = targetFruit;
    }
}