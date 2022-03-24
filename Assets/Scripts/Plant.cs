using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Rigidbody2D rb, Arrow;
    [SerializeField] private Vector3 yParmeter;
    private Sprite tmpSprite;
    private bool parnetPos;
    
    [SerializeField] private float waitTimeDestroy;
    
    private void Start()
    {
        tmpSprite = spriteRenderer.sprite;
        rb.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Throw) ThrowBall();
    }

    void ThrowBall()
    {
        Arrow.GetComponent<FixedJoint2D>().enabled = false;
        rb.velocity = Vector2.one;
        GameManager.Throw = false;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            rb.velocity = Vector2.zero;
            rb.transform.SetParent(other.transform);
            GameManager.AddPower = false;
            GameManager.power = 0;
        }
        
        else if (other.CompareTag("Frogger"))
        {
            StartCoroutine(Die()) ; 
        }
    }
    
    private IEnumerator Die()
    {
        yield return new WaitForSeconds(waitTimeDestroy);
        Destroy(gameObject);
    }
}
