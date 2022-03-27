using System;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _shared;
    [SerializeField] private List<int> winterTargets = new List<int>();
    private int _yearsPassed;

    public bool IsTrowingSeed { get; set; }
    public string CurrentSeason { get; set; }
    public int Score { get; set; }
    public int NextGoal { get; set; }
    public float CurrentDeg { get; set; }

    private void Awake()
    {
        _shared = this;
        DontDestroyOnLoad(gameObject);
        SetDefaultVariables();
        UpdateTargetGoal();
    }

    private void SetDefaultVariables()
    {
        IsTrowingSeed = false;
        CurrentSeason = "Spring";
        Score = 0;
        _yearsPassed = 0;
        NextGoal = 0;
    }

    private void UpdateTargetGoal()
    {
        if (_yearsPassed >= winterTargets.Count)
            NextGoal += (_yearsPassed - winterTargets.Count + 1) * 10;
        else
            NextGoal = winterTargets[_yearsPassed];
    }

    public void YearPassed()
    {
        //if(NextGoal > Score) return; // end game
        _yearsPassed += 1;
        UpdateTargetGoal();
    }
}