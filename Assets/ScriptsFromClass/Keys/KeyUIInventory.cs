using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyUIInventory : MonoBehaviour
{
    [SerializeField] List<SpriteChanger>keySpriteChanges;
    [SerializeField] List<Sprite>keyCardSprites;
    [SerializeField] List<Sprite>finishKeyCardSprites;

    public void showCard(int index)
    {
        keySpriteChanges[index].ChangeSprite(keyCardSprites[index]);    
    }

    public void showFinishedCard(int index)
    {
        keySpriteChanges[index].ChangeSprite(finishKeyCardSprites[index]);
    }
}
