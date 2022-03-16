using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeasonIndicator : MonoBehaviour
{
    [Range(0.1f, 30)] [SerializeField] private float minPerYear = 15f;

    // Update is called once per frame
    void Update()
    {
        var degPerSec = 6 / minPerYear;
        var rot = transform.rotation;
        transform.rotation = rot * Quaternion.Euler(0, 0, -degPerSec * Time.deltaTime);
    }

    public string GetSeason()
    {
        var season = transform.eulerAngles.z;
        if (season <= 360 && season > 270) return "Spring";
        if (season <= 270 && season > 180) return "Summer";
        if (season <= 180 && season > 90) return "Autumn";
        return "Winter";
    }
}