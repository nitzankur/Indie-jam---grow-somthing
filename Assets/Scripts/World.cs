using UnityEngine;

public class World : MonoBehaviour
{
    [Range(20, 150)] [SerializeField] private float fastParamter;
    private float _tmpParmeter;
    private bool _worldMove;

    private void Start()
    {
        _tmpParmeter = fastParamter;
        fastParamter = 0;
    }

    // Update is called once per frame
    private void Update()
    {
        var rot = transform.rotation;
        transform.rotation = rot * Quaternion.Euler(0, 0, -fastParamter * Time.deltaTime);
    }

    private void OnMouseDown()
    {
        if (!_worldMove)
        {
            fastParamter = _tmpParmeter;
            _worldMove = true;
        }
        else
        {
            fastParamter = 0f;
            _worldMove = false;
        }
    }

    public bool WorldMovement()
    {
        return _worldMove;
    }
}