using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundObject : MonoBehaviour
{
    #region fields
    private enum seasons{spring,summer,full,winter} 
    

    #endregion
    // Start is called before the first frame update
    void Start()
    {
       GroundManager.RegisterObject(gameObject); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
