using System;
using System.Collections;
using UnityEngine;

public class Throw : MonoBehaviour
{
     [Tooltip("this is curve!!")] public AnimationCurve curve;
     [SerializeField] private Vector3 endScale;
     private float _radius;
     
     private void Update()
     { 
         ThrowBall();
     }

     private void ThrowBall()
     {
         print(GameManager.power);
         var startScale = transform.localScale;
         StartCoroutine(ScaleOverTime(GameManager.power, startScale, endScale));
     
     }
     
     private IEnumerator ScaleOverTime(float time, Vector3 start, Vector3 destination)
     {
         print("ScaleOverTime");
         var currentTime = 0.0f;
         do
         {
             gameObject.transform.localScale = Vector3.Lerp(start, destination, currentTime / time)* curve.Evaluate(Time.deltaTime);
             currentTime += Time.deltaTime;
             yield return null;
         } while (currentTime <= time);
     }

   
}