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
    private float timecount = 0.5f;
    private IEnumerator _coro;


    // Start is called before the first frame update
    void Start()
    {
       _originalScale = gameObject.transform.localScale;
       _moveRight = true;
       _coro = ScaleOverTime(fastScale, _originalScale, DestinationScale);
    }

    // Update is called once per frame
    void Update()
    {
        if (_moveLeftRight)
        {
            var rot = transform.rotation;
            _moveRight = _moveRight ? timecount <= 1 : timecount <= 0;
            if (_moveRight)
            {
                transform.rotation = Quaternion.Slerp(Quaternion.Euler(0, 0, -MaxRotation),Quaternion.Euler(0, 0, MaxRotation),timecount);
                timecount += Time.deltaTime;
            }

            else
            {
                transform.rotation = Quaternion.Slerp(Quaternion.Euler(0, 0, -MaxRotation),Quaternion.Euler(0, 0, MaxRotation),timecount);
                timecount -= Time.deltaTime;
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
            GameManager.Addforce = true;
            _moveLeftRight = false;
            _moveUpDown = true;
            StartCoroutine(_coro);
        }
        else if (_moveUpDown)
        {
            _moveUpDown = false;
            StopCoroutine(_coro);
            GameManager.Throw = true;
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

