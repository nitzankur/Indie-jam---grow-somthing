using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _shared;
    
    public bool IsTrowingSeed { get; set; }
    public string CurrentSeason { get; set; }
    
    private void Awake()
    {
        _shared = this;
        DontDestroyOnLoad(gameObject);
        SetDefaultVariables();
    }

    private void SetDefaultVariables()
    {
        IsTrowingSeed = false;
        CurrentSeason = "Spring";
    }
    
}