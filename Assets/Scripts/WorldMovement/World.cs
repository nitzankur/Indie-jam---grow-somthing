using UnityEngine;

public class World : MonoBehaviour
{
    [Range(20, 150)] [SerializeField] private float fastParameter = 70;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            var rot = transform.rotation;
            transform.rotation = rot * Quaternion.Euler(0, 0, -fastParameter * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            var rot = transform.rotation;
            transform.rotation = rot * Quaternion.Euler(0, 0, fastParameter * Time.deltaTime);
        }
    }
}