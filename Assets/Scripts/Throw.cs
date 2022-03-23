using System;
using System.Collections;
using UnityEngine;

public class Throw : MonoBehaviour
{
//     [Tooltip("this is curve!!")] public AnimationCurve curve;
//
//     [SerializeField] private float JumpHeight;
//
//     [SerializeField] private Vector3 WorldStart;
//
//     [SerializeField] private Vector3 WorldEnd;
//
//     private float _radius;
//
//     // Start is called before the first frame update
//     private void Start()
//     {
//         //  Debug.Log($"scale: {curve.Evaluate(0.5f)}");
//         _radius = WorldEnd.y - WorldStart.y;
//     }
//
//     // Update is called once per frame
//     private void Update()
//     {
//         if (GameManager.Throw) ThrowBall();
//     }
//
//     private void ThrowBall()
//     {
//         var roadend = _radius * GameManager.power;
//         var pos = transform.position;
//         var scale = transform.localScale;
//         var jumpHeigt = CalcultaeJump(WorldStart.x, roadend, pos.x);
//         StartCoroutine(MoveOverTime(GameManager.power, WorldStart, WorldEnd));
//         transform.localScale = new Vector3(scale.x * jumpHeigt, scale.y * jumpHeigt, scale.z);
//         GameManager.Throw = false;
//     }
//
//     private float CalcultaeJump(float x1, float x2, float x)
//     {
//         return -(x - x1) * (x - x2) * JumpHeight;
//     }
//
//     private IEnumerator MoveOverTime(float time, Vector3 start, Vector3 destination)
//     {
//         print(time);
//         var currentTime = 0.0f;
//         do
//         {
//             gameObject.transform.position = Vector3.Lerp(start, destination, currentTime / time);
//             currentTime += Time.deltaTime;
//             yield return null;
//         } while (currentTime <= time);
//
//         //Todo: understand i am move the ball fowrowrd with lerp - the time is limtiation or the position?
//     }

   
}