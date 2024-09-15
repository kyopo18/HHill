using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDieCutScene : MonoBehaviour

{
    // Drag the source and target GameObjects into the inspector
    public Transform sourceTransform;
    public Transform targetTransform;

    public void SetTransform()
    {
        // Check if both source and target are assigned
        if (sourceTransform != null && targetTransform != null)
        {
            // Copy position, rotation, and scale
            targetTransform.position = sourceTransform.position;
            targetTransform.rotation = sourceTransform.rotation;
            targetTransform.localScale = sourceTransform.localScale;
        }
    }
}

