using TMPro;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    private GameManager _gameManager;

    [SerializeField] private TextMeshProUGUI score;

    // Start is called before the first frame update
    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        score.text = "" + _gameManager.Score;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) _gameManager.RestartGame();
    }
}