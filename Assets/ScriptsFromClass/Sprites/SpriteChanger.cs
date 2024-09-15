using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SpriteChanger : MonoBehaviour
{
    [SerializeField] Image card;

    public void ChangeSprite(Sprite card)
    {
        this.card.sprite = card;
        this.card.enabled = true;
    }
}
