using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _shared;
    public static bool AddPower, Throw, newSeed;
    public static float power;

    // Start is called before the first frame update
    private void Awake()
    {
        _shared = this;
    }


    // Update is called once per frame
    private void Update()
    {
        if (AddPower) power += 0.1f;
    }
}