using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundObject : MonoBehaviour
{
    #region fields
    
    private enum Seasons
    {
        spring,
        summer,
        full,
        winter
    };

    private Seasons year;
    

    #endregion
    // Start is called before the first frame update
    void Start()
    {
       GroundManager.RegisterObject(gameObject); 
    }

    // Update is called once per frame
    void Update()
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
}
