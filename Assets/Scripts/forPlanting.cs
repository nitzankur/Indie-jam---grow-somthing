using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forPlanting : MonoBehaviour
{
    [SerializeField] private  SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite Seed,WetringCan,WeedKiller;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private  Transform prefab;
    // #region Singelton
    // public static forPlanting seedShared;
    // private void Awake()
    // {
    //     seedShared = this;
    // }
    // #endregion
    
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

    public void Throw()
    {
        spriteRenderer.sprite = null;
        //Instantiate(prefab, new Vector3(xpos, ypos, 0), Quaternion.identity,transform);   
        
    }
}
