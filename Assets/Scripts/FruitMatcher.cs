using System.Collections.Generic;
using UnityEngine;

public class FruitMatcher : MonoBehaviour
{

    private List<Fruit> _fruits = new List<Fruit>();

    public List<Fruit> Fruits
    {
        get => _fruits;
        set => _fruits = value;
    }

    public void AddFruit(Fruit newFruit)
    {
        _fruits.Add(newFruit);
    }

    public Fruit GetFruit(float juiciness = 1f, float amountOfPeople = 1f, float volume = 1f)
    {

        var matchResult = GetSortedFruits(juiciness, amountOfPeople, volume);
        
        LogScore(matchResult);
        
        return matchResult[0].TargetFruit;
    }
    
    public List<FruitScore> GetSortedFruits(float juiciness = 1f, float amountOfPeople = 1f, float volume = 1f)
    {
        
        var matchResult = new List<FruitScore>();

        foreach (var currentFruit in Fruits)
        {
            var currentScore = new FruitScore(currentFruit);
            
            // Generic
            // Reflection
            currentScore.Score += CalculateMinMaxScore(currentFruit.Juiciness, juiciness);
            currentScore.Score += CalculateMinMaxScore(currentFruit.AmountOfPeople, amountOfPeople);
            currentScore.Score += CalculateMinMaxScore(currentFruit.Volume, volume);
            
            matchResult.Add(currentScore);
        }
        
        matchResult.Sort((a, b) => b.Score.CompareTo(a.Score));
        
        return matchResult;
    }
    
    private float CalculateMinMaxScore(MinMax spectrum, float value)
    {
        return spectrum.Contains(value) ? 1f : 0f;
    }

    private void LogScore(List<FruitScore> targetList)
    {
        foreach (var currentScore in targetList)
        {
            Debug.Log(currentScore.TargetFruit.Name + " : " + currentScore.Score);
        }
    }
}