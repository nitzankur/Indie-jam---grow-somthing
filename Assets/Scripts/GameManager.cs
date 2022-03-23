using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _shared;
    public static bool Addforce, Throw;

    public static float force;

    // Start is called before the first frame update
    private void Awake()
    {
        _shared = this;
    }


    // Update is called once per frame
    private void Update()
    {
        if (Addforce) force += 0.1f;
    }
}