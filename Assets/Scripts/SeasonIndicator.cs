using System;
using UnityEngine;

public class SeasonIndicator : MonoBehaviour
{
    private GameManager _gameManager;
    [Range(0.1f, 30)] [SerializeField] private float minPerYear = 15f;

    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        _gameManager.CurrentSeason = GetSeason();
        var degPerSec = 6 / minPerYear;
        var rot = transform.rotation;
        transform.rotation = rot * Quaternion.Euler(0, 0, -degPerSec * Time.deltaTime);
    }

    private string GetSeason()
    {
        var deg = transform.localEulerAngles.z;
        _gameManager.CurrentDeg = deg;
        if (360 >= deg && deg > 243) return "Spring";
        if (243 >= deg && deg > 132) return "Summer";
        if (132 >= deg && deg > 42) return "Fall";
        return "Winter";
    }
}