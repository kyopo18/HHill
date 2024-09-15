using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    [SerializeField] AudioClip gameFinishAudio;
    [SerializeField] GameObject gameFinishCanvas; 
    
    public void GameFinish()
    {
        AudioSource.PlayClipAtPoint(gameFinishAudio, Camera.main.transform.position);
        gameFinishCanvas.SetActive(true);
        Time.timeScale = 0;
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
