using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class EnterNameScript : MonoBehaviour
{
     private string playerName;
     private GameManager _gameManager;
    [SerializeField] private GameObject textDisplay,inputField;
    
    // Start is called before the first frame update
    void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            playerName =  inputField.GetComponent<Text>().text;
            _gameManager.PlayerName = name;
            textDisplay.GetComponent<Text>().text = "Welcome" + playerName + "toTheGame";
        }
        print(_gameManager.PlayerName);
    }
  

}
