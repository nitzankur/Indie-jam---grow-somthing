using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class Throw : MonoBehaviour
{
    [Tooltip("this is curve!!")]
    public AnimationCurve curve;

    [SerializeField] private float JumpHeight;

    [SerializeField] private Vector3 WorldStart;

    [SerializeField] private Vector3 WorldEnd;

    private float _radius;
    // Start is called before the first frame update
    void Start()
    {
      //  Debug.Log($"scale: {curve.Evaluate(0.5f)}");
      _radius = WorldEnd.y - WorldStart.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Throw) ThrowBall();
    }

    private void ThrowBall()
    {
        var roadend = _radius * GameManager.force;
        var pos = transform.localScale;
        transform.localScale = new Vector3(pos * CalcultaeJump(x1,x2,x))
    }

    private float CalcultaeJump(float x1, float x2, float x)
    {
        return (-(x - x1)(x - x2)) * JumpHeight;
    }
    
    IEnumerator ScaleOverTime(float time,Vector3 start,Vector3 destination)
    {
        float currentTime = 0.0f;
        do
        {
            gameObject.transform.localScale = Vector3.Lerp(start, destination, currentTime / time);
            currentTime += Time.deltaTime;
            yield return null;
        }while (currentTime <= time);
        
    }
    
   
}

