using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseclickListener : MonoBehaviour
{

    [SerializeField] private FruitMatcher _fruitMatcher;
    [SerializeField] private float _juiciness = 3f;
    [SerializeField] private float _amountOfPeople = 2f;
    [SerializeField] private float _volume = 3f;
    
    void OnMouseDown()
    {
        var matchedFruit = _fruitMatcher.GetFruit(_juiciness, _amountOfPeople, _volume);
        Debug.Log(matchedFruit.Name);
    }
    
}
