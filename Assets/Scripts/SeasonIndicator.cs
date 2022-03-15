using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeasonIndicator : MonoBehaviour
{
    [SerializeField] private float minPerYear = 1f;
    private Rigidbody2D _rb;


    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        //_rb.AddTorque(360, ForceMode2D.Impulse);

    }

    // Update is called once per frame
    void Update()
    {
        
        var rot = transform.rotation;
        var degPerSec = 360 / 60;
        transform.rotation = rot * Quaternion.Euler(0, 0, -360 *Time.deltaTime);
    }
}
