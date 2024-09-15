using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RPSHUD : MonoBehaviour
{
    [SerializeField] Image rpsImage;
    [SerializeField] Sprite[] rpsSprites;
    [SerializeField] Sprite unknownSprite;

    public void UpdateRPSUI(int spriteIndex)
    {
        rpsImage.sprite = rpsSprites[spriteIndex];

    }

    public void RemoveImage()
    {
        rpsImage.sprite = unknownSprite;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
