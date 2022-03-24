using System.Collections;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    [Range(50, 300)] [SerializeField] private float fastParamterHorizontal;
    [Range(0, 20)] [SerializeField] private float fastScale;
    [Range(30, 150)] [SerializeField] private int MaxRotation;
    [SerializeField] private Vector3 DestinationScale;
    private IEnumerator _coro;
    private bool _moveLeftRight, _moveUpDown, _moveRight, _moveLeft;
    private Vector3 _originalScale;
    private float timecount = 0.5f;
    [Range(0, 1)] [SerializeField] private float movementSpeed;


    // Start is called before the first frame update
    private void Start()
    {
        _originalScale = gameObject.transform.localScale;
        _moveRight = true;
        _coro = MoveOverTime(fastScale, _originalScale, DestinationScale);
    }

    // Update is called once per frame
    private void Update()
    {
        if (_moveLeftRight)
        {
            var rot = transform.rotation;
            _moveRight = _moveRight ? timecount <= 1 : timecount <= 0;
            if (_moveRight)
            {
                transform.rotation = Quaternion.Slerp(Quaternion.Euler(0, 0, -MaxRotation),
                    Quaternion.Euler(0, 0, MaxRotation), timecount);
                timecount += Time.deltaTime;
            }

            else
            {
                transform.rotation = Quaternion.Slerp(Quaternion.Euler(0, 0, -MaxRotation),
                    Quaternion.Euler(0, 0, MaxRotation), timecount);
                timecount -= Time.deltaTime;
            }
        }
    }

    private void OnMouseDown()
    {
        if (!_moveLeftRight & !_moveUpDown)
        {
            _moveLeftRight = true;
        }
        else if (_moveLeftRight)
        {
            GameManager.AddPower = true;
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

    // private IEnumerator ScaleOverTime(float time, Vector3 start, Vector3 destination)
    // {
    //     var currentTime = 0.0f;
    //     do
    //     {
    //         float test = Mathf.Sin(currentTime) * 0.5f + 0.5f;
    //         gameObject.transform.localScale = Vector3.Lerp(start, destination, test);
    //         currentTime += Time.deltaTime;
    //         yield return null;
    //     } while (currentTime <= time);
    // }
    //
    private IEnumerator MoveOverTime(float time, Vector3 start, Vector3 destination)
    {
        var currentTime = 0.0f;
        do
        { 
            float test = Mathf.Sin(currentTime) * 0.5f + 0.5f;
            transform.position += transform.up * (currentTime) * movementSpeed ;
            currentTime += Time.deltaTime;
            yield return null;
        } while (currentTime <= time);
    }
}