using UnityEngine;

public class FroggerInsect : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [Range(0, 150)] [SerializeField] private float fastParameter;
    [SerializeField] private Vector3 centre;
    private float _angle;
    private static readonly int Water = Animator.StringToHash("Water");

    // Update is called once per frame
    private void Update()
    {
        //this code make the insect circular movement
        _angle = fastParameter * Time.deltaTime * 0.5f;
        transform.RotateAround(centre, Vector3.forward, _angle);
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("River"))
        {
            print("col");
            _animator.SetTrigger(Water);
        }
    }
}