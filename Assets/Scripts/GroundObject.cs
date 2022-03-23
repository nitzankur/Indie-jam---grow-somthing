using UnityEngine;

public class GroundObject : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        GroundManager.RegisterObject(gameObject);
    }

    // Update is called once per frame
    private void Update()
    {
        switch (year)
        {
            case Seasons.full:
                break;
            case Seasons.spring:
                break;
            case Seasons.winter:
                break;
            case Seasons.summer:
                break;
        }
    }

    #region fields

    private enum Seasons
    {
        spring,
        summer,
        full,
        winter
    }

    private Seasons year;

    #endregion
}