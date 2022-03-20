using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    private bool _moveLeftRight, _moveUpDown, _moveRight, _moveLeft;
    [Range(50, 300)] [SerializeField] private float fastParamterHorizontal;
    [Range(0, 20)] [SerializeField] private float fastScale;
    [Range(30, 150)] [SerializeField] private int MaxRotation;
    [SerializeField] private Vector3 DestinationScale;
    private Vector3 _originalScale;


    // Start is called before the first frame update
    void Start()
    {
       _originalScale = gameObject.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (_moveLeftRight)
        {
            var rot = transform.rotation;
            if (Math.Round(transform.rotation.z) == -MaxRotation)
            {
                _moveRight = false;
                _moveLeft = true;
            }
            else if (Math.Round(transform.rotation.z) == MaxRotation)
            {
                _moveRight = true;
                _moveLeft = false;
            }


            if (_moveRight)
            {
                transform.rotation = rot * Quaternion.Euler(0, 0, -fastParamterHorizontal * Time.deltaTime);
            }

            else if (_moveLeft)
            {
                transform.rotation = rot * Quaternion.Euler(0, 0, fastParamterHorizontal * Time.deltaTime);
            }
        }

    }

    private void OnMouseDown()
    {
        if ((!_moveLeftRight) & (!_moveUpDown))
        {
            _moveLeftRight = true;
        }
        else if (_moveLeftRight)
        {
            print("move Up and Down");
            _moveLeftRight = false;
            _moveUpDown = true;
           
            StartCoroutine(ScaleOverTime(fastScale,_originalScale,DestinationScale));
        }
        else
        {
            _moveUpDown = false;
            StartCoroutine(ScaleOverTime(fastScale,DestinationScale,_originalScale));
        }
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
