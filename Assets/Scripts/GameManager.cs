using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _shared;

    public static float force;
    // Start is called before the first frame update
    private void Awake()
    {
        _shared = this;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
