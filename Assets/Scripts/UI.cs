using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    private GameManager _gameManager;
    [SerializeField] private TextMeshProUGUI _curScore, _targetScore;
    
    void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
    }
    
    void Update()
    {
        _curScore.text = "X" + _gameManager.Score;
        _targetScore.text = "Goal for next winter is " + _gameManager.NextGoal + " plants";
    }
}
