using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SeedThrow : MonoBehaviour
{
    [SerializeField] private bool resetArrowPos = false;
    [Range(0, 1)] [SerializeField] private float seedSizeScaler = 1;
    [Range(1, 50)] [SerializeField] private float speedScaler = 15;
    [Range(1, 2)] [SerializeField] private float targetSpeed = 1f;
    [SerializeField] private GameObject target;
    private Vector3 _targetBasePos, _arrowBasePos;
    private bool _rotateArrow = false;
    private int _arrowDirection = 1;
    private bool _sendTarget = false;
    private int _targetDirection = 1;
    
    void Start()
    {
        _targetBasePos = target.transform.localPosition;
        _arrowBasePos = transform.position;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) ButtonPressed();

        if (_rotateArrow && !_sendTarget) RotateArrow();

        if (_sendTarget) SendTarget();
    }

    private void ButtonPressed()
    {
        if (!_rotateArrow && !_sendTarget) _rotateArrow = true;
        else if (!_sendTarget) _sendTarget = true;
        else
        {
            ResetArrow();
        }
    }

    private void RotateArrow()
    {
        var rot = transform.rotation;
        if (Math.Abs(rot.z) > 0.6f) _arrowDirection *= -1;
        transform.rotation = rot * Quaternion.Euler(0, 0, _arrowDirection * speedScaler * 10 * Time.deltaTime);
    }

    private void SendTarget()
    {
        var targetPos = target.transform.localPosition;
        if (targetPos.y > 30) _targetDirection *= -1;
        if (targetPos.y < 12) _targetDirection *= -1;
        target.transform.position += _targetDirection * transform.up * targetSpeed / 100;
    }

    private void ResetArrow()
    {
        target.transform.localPosition = _targetBasePos;
        if (resetArrowPos) transform.rotation = Quaternion.identity;
        if (Random.Range(0, 2) == 0)
            _arrowDirection = 1;
        else
            _arrowDirection = -1;
        _targetDirection = 1;
        _rotateArrow = _sendTarget = false;
    }

    private bool CheckTarget()
    {
        var pos = target.transform.position;
        RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.up / seedSizeScaler, 0f, 3);
        if (hit.collider != null)
        {
            return false;
        }

        return true;
    }
}