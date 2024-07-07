using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeySlotOpener : MonoBehaviour
{
    [SerializeField] private List<KeyColor> keyColors;
    public UnityEvent OnComplete = new UnityEvent();
    
    
    public void RemoveKeyColor(int keyColorIndex)
    {
        keyColors.Remove((KeyColor)keyColorIndex);
        CheckIfEmpty();
    }

    private void CheckIfEmpty()
    {
        if (keyColors.Count <= 0)
        {
            OnComplete.Invoke();
        }
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
