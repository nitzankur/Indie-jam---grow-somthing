using UnityEngine;

public class FroggerAnimels : MonoBehaviour
{
    [Range(0, 150)] [SerializeField] private float fastParamter;
    [SerializeField] private float Radius;
    [SerializeField] private Vector3 _centre;
    private float _angle;
    [SerializeField]
    [Range(0,1)]
    private float waveSpeed;

    // Update is called once per frame
    private void Update()
    {
      //  var rot = transform.rotation;
        _angle = fastParamter * Time.deltaTime;
        //var offset = new Vector3(Mathf.Sin(-_angle), (Mathf.Cos(-_angle)) , 0) * Radius;
        transform.RotateAround(_centre, Vector3.forward, _angle);
        waveSpeed = 0.5f;
        transform.position =_centre + transform.up * (Radius + waveSpeed * Mathf.Sin(Time.time));
        // transform.position = _centre + offset;
        //transform.rotation = rot * Quaternion.Euler(0, 0, circleSpeed *Time.deltaTime);
    }
}