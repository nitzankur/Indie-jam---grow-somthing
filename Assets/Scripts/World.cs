using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{
    
    [Range(20,150)][SerializeField] private float fastParamter;
    private bool _worldMove = false;
    private float tmpParmeter;

    void Start()
    {
       tmpParmeter = fastParamter;
       fastParamter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (!_worldMove)
            {
                if (fastParamter == 0)
                {
                    fastParamter = tmpParmeter;}
                else
                {
                    fastParamter = 0;
                    _worldMove = true;
                }
               
            }
            else
            {
                fastParamter = tmpParmeter;
                _worldMove = false;
            }
        }
        var rot = transform.rotation;
        transform.rotation = rot * Quaternion.Euler(0, 0, -fastParamter*Time.deltaTime); 
    }
    public bool WorldMovement()
    {
        return _worldMove;
    }
}
