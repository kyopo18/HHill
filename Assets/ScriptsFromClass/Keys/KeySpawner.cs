using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySpawner : MonoBehaviour
{
    private Transform selectedCanSpawnKey;
    [SerializeField] private KeyOpen keyToSpawn;
    [SerializeField] private List<CanSpawnKey> canSpawnKeys = new List<CanSpawnKey>();

    // Start is called before the first frame update
    void Start()
    {
        int randomIndex = Random.Range(0, canSpawnKeys.Count);
        canSpawnKeys[randomIndex].onSpawnKey.AddListener(SpawnKey);
        selectedCanSpawnKey = canSpawnKeys[randomIndex].transform;
        Debug.Log (randomIndex);
    }

    private void SpawnKey(Vector3 position)
    {
        Instantiate(keyToSpawn, position, Quaternion.identity);
        //Debug.Log("I'm spaaaawning");
    }
}
