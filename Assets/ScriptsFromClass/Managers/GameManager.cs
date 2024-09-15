using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    private InputController player;
    public UnityEvent OnLevelStart = new UnityEvent();
    public UnityEvent OnAction = new UnityEvent();
    public UnityEvent OnLevelFinish = new UnityEvent();
    public UnityEvent OnDie = new UnityEvent();
    public UnityEvent OnDoorOpen = new UnityEvent();
    public static GameManager Singleton { get; private set; }
    private void Awake()
    {
        if (Singleton == null)
        {
            Singleton = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        Invoke("StartLevel", Time.deltaTime);
    }
    public void StartLevel()
    {
        player = FindObjectOfType<InputController>();
        //start cutscene
        // start countdown
        OnLevelStart?.Invoke();
    }
    public void FinishLevel()
    {
        OnLevelFinish?.Invoke();
    }

    public void DoorOpen()
    {
        OnDoorOpen?.Invoke();
    }

    public void PlayerDie()
    {
        OnDie?.Invoke();
    }

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
            }
            return instance;
        }
    }

    public void PlayerRespawn()
    {

    }
    public void LockPlayerInput()
    {
        player.enabled = false;
    }
    public void UnlockPlayerInput()
    {
        player.enabled = true;
    }

    public void RestartGame()

    {
        // Reset game state, reload scene, etc.
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}
