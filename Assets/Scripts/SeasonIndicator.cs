using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeasonIndicator : MonoBehaviour
{
    [SerializeField] private float minPerYear = 1f;
    private Rigidbody2D _rb;
    private float updateTime = 1f;
    private int b = 80;
    private int c = 90;
    
    
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        //_rb.AddTorque(360, ForceMode2D.Impulse);

    }

    // Update is called once per frame
    void Update()
    {
        
        var rot = transform.rotation;
        //var degPerSec = 360 / 60 * minPerYear;
        transform.rotation = rot * Quaternion.Euler(0, 0, -minPerYear*Time.deltaTime);
    }
}
