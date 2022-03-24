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
}