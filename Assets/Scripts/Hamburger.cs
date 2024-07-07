using System.Collections;
using UnityEngine;

public class Hamburger : MonoBehaviour
    // Seasoned Meat
{
    public float spinSpeed = 360f; // Spin speed in degrees per second

    private bool isSpinning = false;
    private Transform wieldShot1; // Reference to the right hand slot

    void Start()
    {
        // Find the right hand slot by tag
        wieldShot1 = GameObject.FindGameObjectWithTag("WieldShot1").transform;
        // Attach the weapon to the right hand slot
        transform.SetParent(wieldShot1);
        transform.localPosition = Vector3.zero; // Reset local position
        transform.localRotation = Quaternion.identity; // Reset local rotation
    }

    // spinning the weapon
    public void StartSpinning()
    {
        if (!isSpinning)
        {
            isSpinning = true;
            // Start spinning the weapon
            StartCoroutine(Spin());
            
        }
    }

    // the spinning motion
    private IEnumerator Spin()
    {
        while (true)
        {
            // Rotate the weapon around its local up axis
            transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);
            yield return null;
        }
    }

    // stop spinning the weapon
    public void StopSpinning()
    {
        if (isSpinning)
        {
            isSpinning = false;
            // Stop the spinning coroutine
            StopAllCoroutines();
        }
    }
}







//{private float WieldShot1;

//// Start is called before the first frame update
//void Start()
//{
//    // Set Skill == 0;
//    WieldSlot1 == MetalFork(); // Left Hand spin it once
//    // research positioning in left hand
//    // research rotating the weapon
//    // 
//}

//// Update is called once per frame
//void Update()
//{
//    // Add Skill
//    // stuck
//}