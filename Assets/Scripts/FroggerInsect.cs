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
        _angle = fastParamter * Time.deltaTime;
        transform.RotateAround(_centre, Vector3.forward, _angle);
        //transform.position =_centre + transform.up * (Radius + waveSpeed * Mathf.Sin(Time.time));
    }
}
