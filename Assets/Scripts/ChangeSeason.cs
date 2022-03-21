using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSeason : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite Spring,Summer,Winter,Autumn;

    private void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }


    // Update is called once per frame
    void Update()
    {
        Changeseason();
    }
    void ChangeSprite(Sprite newSprite)
    {
        spriteRenderer.sprite = newSprite;
    }
    void Changeseason()
    {
        if (GroundManager.year == "Spring") ChangeSprite(Spring);
        if (GroundManager.year == "Summer") ChangeSprite(Summer);
        if (GroundManager.year == "Winter") ChangeSprite(Winter);
        if (GroundManager.year == "Autumn") ChangeSprite(Autumn);
    }
}
