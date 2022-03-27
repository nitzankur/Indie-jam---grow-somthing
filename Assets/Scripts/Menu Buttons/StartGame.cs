using UnityEngine;

public class StartGame : MonoBehaviour
{
    private GameManager _gameManager;

    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        _gameManager.AudioManager.PlaySound("Theme");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) _gameManager.StartGame();
        if (Input.GetKeyDown(KeyCode.R)) _gameManager.LoadRules();
    }
}