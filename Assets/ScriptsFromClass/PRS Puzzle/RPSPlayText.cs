using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RPSPlayText : MonoBehaviour
{
    
    [SerializeField] TextMeshProUGUI rpsPlayText;

    public void UpdatePlayHUD(string stringValue)
    {
        rpsPlayText.text = stringValue;

    }

    // Start is called before the first frame update
    void Start()
    {
        rpsPlayText.text = "Press Button to Play.";
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
