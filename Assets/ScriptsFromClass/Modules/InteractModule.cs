using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractModule : MonoBehaviour
{
    //Makes a header in inspector for interactions.
    [Header("Interactions")]
    [SerializeField] private Camera cam;
    //Creates an interactableLayer in the inspector for interactable objects.
    [SerializeField] private LayerMask interactableLayer;
    [SerializeField] private Transform holdPoint;
    // stores interactable objects
    private IInteractable targetInteractable;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckInteraction();
    }

    public void InteractWithObject()
    {
        if(targetInteractable != null) 
        {
            targetInteractable.OnInteract(this);
        }
         //06/05/2024 moved into if targetinteractable == null
                                             // Pressing the 'E' key does: 
                                             // Debug.Log(Input.mousePosition);
                                             // this means calling the monobehaviors call.

        // Ray now follows mousePosition is not suitable for a 3D game because change in screen sizes.

        // draws a ray from start to direction with the color and the duration, used to interact with objects in game.
        //Debug.DrawRay(shootingPoint.transform.position, camera.transform.forward, Color.red, 3f);
        // draws a ray from start to direction with the color and the duration, used to interact with objects in game.
        // ray is called from the Screen point to ray.
        // a red line shoot now shoot out of the Player where the mouse is pointing.
        // Debug.DrawRay(ray.origin, ray.direction, Color.red, 3f);
        // Debug.Log(hit.collider.gameObject.name);  
    }

    private void CheckInteraction() //06/04/24 Tues Drawing a Ray for Interactions
    {
        // ScreenPointToRay() can trace a ray from the point to another point in the world space.
        // Vector3 is a better function to use.
        // Screen.width / 2 gets the center on the x axis divided by 2 to divide the screen in the middle.
        // Screen.height / 2 gets the center on the y axis divided by 2 to divide the screen in the middle.
        // Ray shoots out from camera and goes to the x and y axis but doesnt extend past 0 on Z.
        Ray ray = cam.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        // Checking the distance of the raycast outward Raycast hit is the ray, Physics.Raycast
        //determines the physics of the ray in this case it goes out a distance of 10f
        RaycastHit hit;

        // Used to debug the name of the object the ray collides with in the inspector.
        // If you don't collide with an object you return an error null reference.
        // Set into an if statement so that the name only returns on objects and gets rid of null error.
        // interactableLayer calls the interactable layer
        if (Physics.Raycast(ray, out hit, 3f, interactableLayer)) // SAYS THAT THE RAY COLLIDED WITH SOMETHING
        {
            if (targetInteractable == null)
            {
                // Gets the interface Interactable hit access.collider accesses GetComponent IInteractable to interact.
                targetInteractable = hit.collider.GetComponent<IInteractable>();
                //interactable calls OnHoverEnter 
                targetInteractable.OnHoverEnter(); //06/05/2024 moved into if targetinteractable == null
                                                   // interactable calls the OnInteract. 
            }
        }
        // if the target interactable is not equal to null
        // then the target method accesses on hoverexit and target interactable = null.
        else if (targetInteractable != null)
        {
            targetInteractable.OnHoverExit();
            targetInteractable = null;
        }
    }

    public Transform GetHoldTransform()
    {
        return holdPoint;
    }
}
