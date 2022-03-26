using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class ChangeSeason : MonoBehaviour
{
    private GameManager _gameManager;
    [SerializeField] private SpriteRenderer spriteRendererFront,spriteRendererBack;
    [SerializeField] private Sprite Spring, Summer, Winter, Autumn;
    [SerializeField] private Animator _animator;
    private static readonly int Spring1 = Animator.StringToHash("Spring");
    private static readonly int Summer1 = Animator.StringToHash("Summer");
    private static readonly int Winter1 = Animator.StringToHash("Winter");
    private static readonly int Autumn1 = Animator.StringToHash("Autumn");
    private bool _winter, _summer, _spring, _autumn;


    // Update is called once per frame
    private void Update()
    {
<<<<<<< HEAD
        ChangeSeasonAnimation();
=======
        Changeseason();
>>>>>>> 49cfe923a1dd500aad13e380a2551776a8542ae0
    }

    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        ChangeSpriteBack(Winter);
        _spring = true;
    }

    private void ChangeSpriteFront(Sprite newSprite)
    {
        spriteRendererFront.sprite = newSprite;
    }
    private void ChangeSpriteBack(Sprite newSprite)
    {
        spriteRendererBack.sprite = newSprite;
    }
    

    private void ChangeSeasonAnimation()
    {
        if ( Mathf.Round(_gameManager.CurrentDeg) == 360 && _spring)
        {
            _animator.SetTrigger(Spring1);
            ChangeSpriteFront(Spring);
            ChangeSpriteBack(Spring);
            _spring = false;
            _summer = true; 
        }

        if (Mathf.Round(_gameManager.CurrentDeg) == 243 && _summer)
        {
            _animator.SetTrigger(Summer1);
            ChangeSpriteFront(Summer);
            ChangeSpriteBack(Summer);
            _summer = false;
            _autumn = true;
        }

        if (Mathf.Round(_gameManager.CurrentDeg) == 132&& _autumn)
        {
            _animator.SetTrigger(Autumn1);
            ChangeSpriteFront(Autumn);
            ChangeSpriteBack(Autumn);
            _autumn = false;
            _winter = true;
        }

        if (Mathf.Round(_gameManager.CurrentDeg) == 42 && _winter)
        {
            _animator.SetTrigger(Winter1);
            ChangeSpriteFront(Winter);
            ChangeSpriteBack(Winter);
            _winter = false;
            _spring = true;
        }
    }
}