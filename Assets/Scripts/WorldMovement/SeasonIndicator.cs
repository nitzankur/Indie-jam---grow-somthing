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
        print(GetSeason());
    }

    public string GetSeason()
    {
        var deg = transform.localEulerAngles.z;
        if (360 >= deg && deg > 243) return "Spring";
        if (243 >= deg && deg > 132) return "Summer";
        if (132 >= deg && deg > 42) return "Fall";
        return "Winter";
    }
}