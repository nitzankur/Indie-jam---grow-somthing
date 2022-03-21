using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FroggerAnimels : MonoBehaviour
{
    [Range(0,15)][SerializeField] private float fastParamter;

    [SerializeField] private float Radius;
    [SerializeField] private Vector3 _centre;
    private float _angle;

    private float _timeCounter = 0f;
    // Update is called once per frame
    void Update()
    {
        _angle += fastParamter * Time.deltaTime;
        var offset = new Vector3(Mathf.Sin(-_angle), Mathf.Cos(-_angle),0) * Radius ;
        transform.position = _centre + offset  ;
    }
}
