using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FroggerInsect : MonoBehaviour
{
    [Range(0, 150)] [SerializeField] private float fastParamter;
    [SerializeField] private Vector3 _centre;
    private float _angle;

    // Update is called once per frame
    private void Update()
    {
        //this code make the insect circular movement
        _angle = fastParamter * Time.deltaTime;
        transform.RotateAround(_centre, Vector3.forward, _angle);
        
    }
}
