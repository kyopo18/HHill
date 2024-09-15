using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CutSceneManager1 : MonoBehaviour
{
    [SerializeField] CutsceneStartType startType;
    [SerializeField] private PlayableDirector director;
    void Start()
    {
        switch(startType)
        {
            case CutsceneStartType.OnLevelStart : GameManager.Singleton.OnLevelStart.AddListener(StartCutScene);
            
                break;

            case CutsceneStartType.OnLevelFinish:
                GameManager.Singleton.OnLevelFinish.AddListener(StartCutScene);

                break;

            case CutsceneStartType.OnDoorOpen:
                GameManager.Singleton.OnDoorOpen.AddListener(StartCutScene);

                break;

            case CutsceneStartType.OnDie:
                GameManager.Singleton.OnDie.AddListener(StartCutScene);

                break;

        }

    }

    public void StartCutScene()
    {
        GameManager.Singleton.LockPlayerInput();
        director.Play();
    }
    public void OnCutSceneEnd()
    {
        GameManager.Singleton.UnlockPlayerInput();
        GameManager.Singleton.OnLevelStart.RemoveListener(StartCutScene);
        GameManager.Singleton.OnLevelFinish.RemoveListener(StartCutScene);
        GameManager.Singleton.OnDoorOpen.RemoveListener(StartCutScene);
        GameManager.Singleton.OnDie.RemoveListener(StartCutScene);

        if (startType == CutsceneStartType.OnDie)
        {
            Debug.Log("IM IS WORKING NOW");
            GameManager.Singleton.RestartGame();
        }

        Destroy(gameObject);
    }
}
public enum CutsceneStartType
{
    OnLevelStart, OnLevelFinish, OnDoorOpen, OnDie
}
