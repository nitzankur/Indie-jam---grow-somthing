using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeasonIndicator : MonoBehaviour
{
    [Range(0.1f, 30)] [SerializeField] private float minPerYear = 15f;
    private float _season;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite Spring,Summer,Winter,Autumn;

    private void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        var degPerSec = 6 / minPerYear;
        var rot = transform.rotation;
        transform.rotation = rot * Quaternion.Euler(0, 0, -degPerSec * Time.deltaTime);
        Changeseason();
    }

    public string GetSeason()
    {
         _season =  transform.eulerAngles.z;
        if (_season <= 360 && _season > 270) return "Spring";
        if (_season <= 270 && _season > 180) return "Summer";
        if (_season <= 180 && _season > 90) return "Autumn";
        return "Winter";
    }
    
    void ChangeSprite(Sprite newSprite)
    {
        spriteRenderer.sprite = newSprite;
    }

    void Changeseason()
    {
        var wichSeason = GetSeason();
        if (wichSeason == "Spring") ChangeSprite(Spring);
        if (wichSeason == "Summer") ChangeSprite(Summer);
        if (wichSeason == "Winter") ChangeSprite(Winter);
        if (wichSeason == "Autumn") ChangeSprite(Autumn);
    }
}