using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forPlanting : MonoBehaviour
{
    [SerializeField] private  SpriteRenderer spriteRenderer;
   // [SerializeField] private Sprite Seed,WetringCan,WeedKiller;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Vector3 parmeterForce;
   // [SerializeField] private  Transform prefab;

   // Start is called before the first frame update
    void Start()
    {
        spriteRenderer.sprite = null;
        rb.gravityScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeTool()
    {
        
    }

   
}
