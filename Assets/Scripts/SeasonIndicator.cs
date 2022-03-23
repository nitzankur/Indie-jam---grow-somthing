using UnityEngine;

public class SeasonIndicator : MonoBehaviour
{
    [Range(0.1f, 30)] [SerializeField] private float minPerYear = 15f;
    private float _season;

    // Update is called once per frame
    private void Update()
    {
        var degPerSec = 6 / minPerYear;
        var rot = transform.rotation;
        transform.rotation = rot * Quaternion.Euler(0, 0, -degPerSec * Time.deltaTime);
    }

    private void GetSeason()
    {
        _season = transform.eulerAngles.z;
        if (_season <= 360 && _season > 270) GroundManager.year = "Spring";
        if (_season <= 270 && _season > 180) GroundManager.year = "Summer";
        if (_season <= 180 && _season > 90) GroundManager.year = "Autumn";
        if (_season <= 90 && _season > 0) GroundManager.year = "Winter";
    }
}