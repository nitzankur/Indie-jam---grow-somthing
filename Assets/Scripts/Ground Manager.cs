using System.Collections.Generic;
using UnityEngine;

public class GroundManager : MonoBehaviour
{
    private static List<GameObject> groundObjects;

    private static GroundManager _shared;

    private void Awake()
    {
        _shared = this;
    }

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public static void RegisterObject(GameObject item)
    {
        groundObjects.Add(item);
    }

    #region fields

    public enum Seasons
    {
        spring,
        summer,
        Autumn,
        winter
    }

    public static string year;

    #endregion
}