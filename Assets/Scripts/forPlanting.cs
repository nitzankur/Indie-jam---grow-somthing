using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forPlanting : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite Seed,WetringCan,WeedKiller;
    [SerializeField] private Rigidbody2D rb;
    #region Singelton
    public static forPlanting seedShared;
    private void Awake()
    {
        seedShared= this;
    }
    #endregion
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeTool()
    {
        
    }

    public static void Throw()
    {
        
    }
}
