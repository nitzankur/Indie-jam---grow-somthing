using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform Arrow;
    private Sprite tmpSprite;
    
    void Start()
    {
        tmpSprite = spriteRenderer.sprite;
        //spriteRenderer.sprite = null;
        rb.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Throw) ThrowBall();
    }

    void ThrowBall()
    {
        GameManager.Throw = false;
        spriteRenderer.sprite = tmpSprite;
        var veloc = rb.velocity;
        var arrowDirect = Arrow.localPosition;
        rb.velocity = new Vector2(veloc.x *arrowDirect.x, veloc.y * arrowDirect.y);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Frogger")) Destroy(gameObject);
        if (other.CompareTag("Ground"))
        {
            gameObject.transform.parent = other.transform;
            rb.velocity = new Vector2(0, 0);
            GameManager.AddPower = false;
            GameManager.power = 0;
        }
    }
}
