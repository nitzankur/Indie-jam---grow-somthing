using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class Plant : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    private bool parnetPos;
    [SerializeField] private float waitTimeDestroy;
    private bool _ground,_throw;

    private void Start()
    {
        rb.gravityScale = 0;
        _throw = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Throw & _throw) ThrowBall();
    }

    void ThrowBall()
    {
        rb.velocity = transform.up;
        GameManager.Throw = false;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            GameManager.newSeed = true;
            rb.velocity = Vector2.zero;
            rb.transform.SetParent(other.transform);
            GameManager.AddPower = false;
            GameManager.power = 0;
            _ground = true;
            _throw = false;
        }
        
        else if (other.CompareTag("Frogger"))
        {
            if (!_ground) StartCoroutine(Die());
        }
        
        else if (other.CompareTag("River"))
        {
           //
        }
        
        else if (other.CompareTag("Mountain"))
        {
            if (!_ground) StartCoroutine(Die()); 
        }
        
    }
    private IEnumerator Die()
    {
        yield return new WaitForSeconds(waitTimeDestroy);
        gameObject.SetActive(false); 
    }
}
