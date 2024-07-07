using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class CanSpawnKey : MonoBehaviour
{
    
    public UnityEvent<Vector3> onSpawnKey = new UnityEvent<Vector3>(); 

    private void OnDestroy()
    {
        onSpawnKey?.Invoke(transform.position);
        //Debug.Log("I'm DOING ANYTHNIG NOW!!!");
    }
}
