using UnityEngine;

public class ChangeSeason : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite Spring, Summer, Winter, Autumn;


    // Update is called once per frame
    private void Update()
    {
        Changeseason();
    }

    private void ChangeSprite(Sprite newSprite)
    {
        spriteRenderer.sprite = newSprite;
    }

    private void Changeseason()
    {
        if (GroundManager.year == "Spring") ChangeSprite(Spring);
        if (GroundManager.year == "Summer") ChangeSprite(Summer);
        if (GroundManager.year == "Winter") ChangeSprite(Winter);
        if (GroundManager.year == "Autumn") ChangeSprite(Autumn);
    }
}