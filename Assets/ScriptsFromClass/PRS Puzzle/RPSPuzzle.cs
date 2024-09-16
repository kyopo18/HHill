using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class RPSPuzzle : MonoBehaviour
{

    Outcome previousOutcome;
    Outcome currentOutcome;
    [SerializeField] Pick aiPick;
    [SerializeField] Pick playerPick;
    public UnityEvent OnPlayerWins = new UnityEvent();
    public UnityEvent OnPlayerAdv = new UnityEvent();
    public UnityEvent OnPlayerLoses = new UnityEvent();
    public UnityEvent OnPlayerDisadv = new UnityEvent();

    public UnityEvent <int> roundFinishForPlayer;
    public UnityEvent <int> roundFinishForAI;
    public UnityEvent roundBegin;

    IEnumerator WaitForPlayerResponse()
    {
        yield return new WaitForSeconds(1);
        RandomAIPick();
        roundBegin.Invoke();
        Debug.Log("Random AI picked outcome");
        yield return new WaitForSeconds(3);
        
        if (playerPick == Pick.none)
        {
            playerPick = (Pick)Random.Range(0,3);
        }

        OnPlayerPick(playerPick);
    }
    public void PuzzleReset()
    {
        previousOutcome = Outcome.Draw;
        playerPick = Pick.none;
    }

    public void OnPlayerPick(Pick playerPick)
    {
        roundFinishForPlayer.Invoke((int)playerPick);   
        roundFinishForAI.Invoke((int)aiPick);   
        StopAllCoroutines();
        currentOutcome = currentOutcomeLogic(playerPick, aiPick);
        this.playerPick = playerPick;
        checkWinCondition();

    }

    public void OnPlayerPick(int playerPick)
    {
        OnPlayerPick((Pick)playerPick);
    }

    public void checkWinCondition() 
    {
        if (currentOutcome == Outcome.LS || currentOutcome == Outcome.RS)
        {
            if(currentOutcome == Outcome.LS) 
            
            {
                OnPlayerAdv.Invoke();
            }
            else
            {
                OnPlayerDisadv.Invoke();
            }

            previousOutcome = currentOutcome;
            Debug.Log(currentOutcome);
            StartCoroutine(WaitForPlayerResponse());
        }
        else if (previousOutcome == Outcome.LS)
        {
            OnPlayerWins.Invoke();
            SoundManager.Instance.PlayHackSound(transform.position, 0);
            Debug.Log("Player won open door!");
        }

        else if (previousOutcome == Outcome.RS)
        {
            OnPlayerLoses.Invoke();
            Debug.Log("Player has lost resetting puzzle");
        }


    }

    public void RandomAIPick()
    {

        aiPick = (Pick)Random.Range(0, 3);
    }
    public Outcome currentOutcomeLogic(Pick LSPick, Pick RSPick)
    {
        if (LSPick - RSPick == 0)
        {
            return Outcome.Draw;
        }
        else if (LSPick - RSPick == -2 || LSPick - RSPick == 1)
        {
            return Outcome.LS;
        }

        return Outcome.RS;
    }

    public void StartPuzzle()
    {
        PuzzleReset();
        StartCoroutine(WaitForPlayerResponse());
        Debug.Log("checkstartPUZZLE");
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}

public enum Pick 
{
    rock, paper, scissors, none
}

public enum Outcome
{
    Draw, LS, RS
}



