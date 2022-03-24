using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb, Arrow;
    private bool parnetPos;
    [SerializeField] private float waitTimeDestroy;
    private bool _ground;

    private void Start()
    {
        rb.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Throw) ThrowBall();
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
        }
        
        else if (other.CompareTag("Frogger"))
        {
            if (!_ground) StartCoroutine(Die());
        }
    }
    private IEnumerator Die()
    {
        yield return new WaitForSeconds(waitTimeDestroy);
        Destroy(gameObject);
    }
}
