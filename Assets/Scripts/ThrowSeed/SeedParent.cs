using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedParent : MonoBehaviour
{
    [SerializeField] private Vector3 center;
    [SerializeField] private GameObject seed;

    private void Update()
    {
        if (GameManager.newSeed)
        {
            Instantiate(seed, center, Quaternion.identity, transform);
            GameManager.newSeed = false;
        }
    }
}
    

    
