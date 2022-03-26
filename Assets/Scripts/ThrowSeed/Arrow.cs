using System.Collections;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    #region Fileds

    [Range(0, 20)] [SerializeField] private float fastScale;
    [SerializeField] private float yLimit,xLimit;
    [Range(30, 150)] [SerializeField] private int MaxRotation;
    [SerializeField] private Vector3 DestinationScale;
    private IEnumerator _coro;
    private bool _moveLeftRight, _moveUpDown, _moveRight, _moveLeft;
    private Vector3 _originalScale;
    private float timecount = 0.5f;
    [Range(0, 1)] [SerializeField] private float movementSpeed;
    #endregion
    


    // Start is called before the first frame update
    private void Start()
    {
        _originalScale = gameObject.transform.localScale;
        _moveRight = true;
        // this IEnumerator take care of the Arrow scale effect - but move this instead.  
        _coro = MoveOverTime(fastScale, _originalScale, DestinationScale);
    }

    // Update is called once per frame
    private void Update()
    {
        // this part take care of the arrow right and left movement , the movement is in loop
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
        //this part is the conditions of the 3 clicks on the arrow: 1. move right and left 2. move up and down 3. throw the ball 
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

    // private void MoveOverTime(float time, Vector3 start, Vector3 destination)
    // {
    //     var startPos = transform.position;
    //     var currentTime = 0.0f;
    //     var startTime = Time.time;
    // }
    private IEnumerator MoveOverTime(float time, Vector3 start, Vector3 destination)
    {
        var startPos = transform.position;
        var currentTime = 0.0f;
        //var startTime = Time.time;
        //var timeParameter = 0.5f;
        var _goUp = true;
        do
        {
            
            // print((Mathf.Abs(transform.position.x)));
            // if ((Mathf.Abs(transform.position.x)  < xLimit || transform.position.y < yLimit) && _goUp)
            // {
            //     print("transform up");
            //     transform.position += transform.up * (currentTime) * movementSpeed;
            // }
            // else
            // {
            //     _goUp = false;
            //     print("transform down");
            //     transform.position = Vector3.Lerp(transform.position, startPos, currentTime/timeParameter);
            // }
            if (_goUp)
            {
                transform.position += transform.up * (currentTime) * movementSpeed;
            }
            else
            {
                transform.position = Vector3.Lerp(transform.position, startPos, currentTime);
            }

            if ((Mathf.Abs(transform.position.x) < xLimit || transform.position.y < yLimit) && _goUp)
            {
                
            }
            else
            {
                _goUp = false;
                if (transform.position == startPos)
                    _goUp = true;
            }
            
            currentTime += Time.deltaTime;
            yield return null;
        } while (true);
    }

    private IEnumerator ScaleOverTime(float time, Vector3 start, Vector3 destination)
    {
        var currentTime = 0.0f;
        do
        {
            float test = Mathf.Sin(currentTime) * 0.5f + 0.5f;
            gameObject.transform.localScale = Vector3.Lerp(start, destination, test);
            currentTime += Time.deltaTime;
            yield return null;
        } while (currentTime <= time);
    }
}