using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;
using static UnityEngine.GraphicsBuffer;
using JetBrains.Annotations;
using System.Runtime.CompilerServices;

public class WaveSpawner : MonoBehaviour
{
    [SerializeField] List<Transform> newPath = new List<Transform>();
    public AIController turretEnemyPrefab;

    public Transform spawnPoint;

    public float timeBetweenWaves = 5f;

    private float countdown = 10f;

    public TextMeshProUGUI waveCountdownText;

    private int waveIndex = 0;
    private void Update()
    {
        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        }

        countdown -= Time.deltaTime;

        waveCountdownText.text = Mathf.Round(countdown).ToString();
    }

    IEnumerator SpawnWave()
    {

        waveIndex++;
        //Debug.Log("Wave Incoming!");

        for (int i = 0; i < waveIndex; i++) 
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }

        
        
    }

    

    void SpawnEnemy()
    {
        AIController controller = Instantiate(turretEnemyPrefab, spawnPoint.position, spawnPoint.rotation); 
        controller.SetPath(newPath);
    }

}
