using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManager : MonoBehaviour
{
    private static List<GameObject> groundObjects;

    private static GroundManager _shared;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    private void Awake()
    {
        _shared = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public static void RegisterObject(GameObject item)
    {
        groundObjects.Add(item);
    }
    
}
