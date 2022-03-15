using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{
    [SerializeField] private float fastParamter;
    private bool _worldMove = true;

    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (!_worldMove)
            {
                fastParamter = 0;
            }
            var rot = transform.rotation;
            transform.rotation = rot * Quaternion.Euler(0, 0, -fastParamter*Time.deltaTime); 
        }
    }
}
