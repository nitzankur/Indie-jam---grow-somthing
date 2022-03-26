using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSeason : MonoBehaviour
{
    private GameManager _gameManager;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite Spring, Summer, Winter, Autumn;


    // Update is called once per frame
    private void Update()
    {
         Changeseason();
    }

    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
    }

    private void ChangeSprite(Sprite newSprite)
    {
        spriteRenderer.sprite = newSprite;
    }

    private void Changeseason()
    {
        if (_gameManager.CurrentSeason == "Spring") ChangeSprite(Spring);
        if (_gameManager.CurrentSeason == "Summer") ChangeSprite(Summer);
        if (_gameManager.CurrentSeason == "Winter") ChangeSprite(Winter);
        if (_gameManager.CurrentSeason == "Autumn") ChangeSprite(Autumn);
    }
}
