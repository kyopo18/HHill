using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class OnPlayerDieModule : MonoBehaviour
{
    HealthModule healthModule;
    [SerializeField] public PlayableDirector cutSceneEndDoor;
    

    private void Start()
    {
        healthModule = GetComponent<HealthModule>();
        
        healthModule.OnDie += OnPlayerDie;
    }

    public void OnPlayerDie()
    {
        gameObject.SetActive(false); // Disable the player

        // Play the cutscene
        if (cutSceneEndDoor != null)
        {
            cutSceneEndDoor.gameObject.SetActive(true); // Ensure the cutscene object is active
            cutSceneEndDoor.Play(); // Play the cutscene
        }

        // Set player to be active again after the cutscene (example: wait for cutscene duration)
        StartCoroutine(ActivatePlayerAfterCutscene(cutSceneEndDoor.duration));
    }

    private IEnumerator ActivatePlayerAfterCutscene(double duration)
    {
        yield return new WaitForSeconds((float)duration); // Wait for the cutscene to finish

        // Activate the player again
        gameObject.SetActive(true);

        // Call game manager (replace GameManager with your actual game manager script)
        GameManager.Instance.RestartGame(); // Example function in GameManager
    }


}
