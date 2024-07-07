using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

/// <summary> //06/02/2024
/// 1. Move player with WASD with an easy adjustable sprint multiplier = Done
/// 2. Look around with Mouse = Done
/// - Moving Y rotates the camera  = Done
/// - Moving X rotates the whole Player = Done
/// 3. The player needs to JUMP with "space bar" = DONE
/// -Add an ApplyGravity() method. = Done
/// 4. And also fall when in the air -Done //06/03/2024
/// 5. Shoot a projectile with mouse click. = Done //06/03/2024
/// </summary>
///// 
//public class PlayerInput : MonoBehaviour
//{
//    //Makes a header in inspector for movement.
//    [Header("Movement")]
//    // Assigns the component character controller added to the inspector of the Player Object.
//    // Drag and drop character controller into the object script to connect.
//    [SerializeField] CharacterController controller;
//    [SerializeField] private float mouseSensitivity;
//    // Adjustable speed variable in inspector.
//    [SerializeField] private float speed;
//    [SerializeField] private float jumpForce; // press Ctrl D to duplicate lines
//    // sprint multiplier
//    [SerializeField] private float sprintingMultiplier;
//    //Creates a floor layer to check in inspector
//    [SerializeField] private LayerMask floorLayer;
//    // Puts the moveDirection /06/03/2024
//    private Vector3 moveDirection;

//    [SerializeField] private Camera cam;

//    // aim direction of mouse
//    private Vector2 aimDirection;
//    // variable to fix look delay on mouse bug.
//    private bool canlookWithMouse;

    
    

    //[Header("Jumping")]
    ////force of gravity //const makes constant throughout program(unadjustable)
    //[SerializeField] public const float gravityAcceleration = -9.81f;
    ////Jump force velocity variable
    //[SerializeField] private Vector3 velocity;
    

    //private void Awake()
    //{
        
    //    // grabs the character controller on the first frame.
    //    //controller = GetComponent<CharacterController>();
    //    //Locks cursor in the middle of the screen. Center of screen. Enum. 0 is none 1 is locked 2 is confined.
    //    Cursor.lockState = CursorLockMode.Locked;
    //    // hides the mouse cursor
    //    Cursor.visible = false;
    //    //Starts mouse with no rotation.
    //    //camera.transform.localEulerAngles = transform.localEulerAngles;
        


        
        
    //}


    // Start is called before the first frame update
    //private void Start()
    //{
    //    //controller = GetComponent<CharacterController>()

    //    cam.transform.localEulerAngles = transform.localEulerAngles;
    //    aimDirection.y = 0;
    //    // fixes bug where player begins looking at floor on play.
    //    Invoke("EnableMouseInput", 1f);

    //    //hides game object in inspector
    //    //GameManager.singleton.gameObject.SetActive(false);
    //}
    //// fixes bug where player begins looking at floor on play.
    //private void EnableMouseInput()
    //{
    //    canlookWithMouse = true;
    //}

    // Update is called once per frame
    //private void Update()
    //{
    //    // Calls MovePlayer Method in Update.
    //    MovePlayer();

    //    if(canlookWithMouse)
    //        // Calls RotatePlayer Method in Update.
    //        RotatePlayer();
        

    //    Jump(); //Set Velocity on y to be 4f

    //    // Calls shoot method.
    //    //Shoot();

    //    //Applys downforce of gravity to player at earth levels.
    //    ApplyGravity();
        
    //    //Interact();

    //    //CheckIfGrounded();
    //}

    //private void Interact() //06/04/24 Tues Drawing a Ray for Interactions
    //{
    //    // ScreenPointToRay() can trace a ray from the point to another point in the world space.
    //    // Vector3 is a better function to use.
    //    // Screen.width / 2 gets the center on the x axis divided by 2 to divide the screen in the middle.
    //    // Screen.height / 2 gets the center on the y axis divided by 2 to divide the screen in the middle.
    //    // Ray shoots out from camera and goes to the x and y axis but doesnt extend past 0 on Z.
    //    Ray ray = cam.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
    //    // Checking the distance of the raycast outward Raycast hit is the ray, Physics.Raycast
    //    //determines the physics of the ray in this case it goes out a distance of 10f
    //    RaycastHit hit;

    //    // Used to debug the name of the object the ray collides with in the inspector.
    //    // If you don't collide with an object you return an error null reference.
    //    // Set into an if statement so that the name only returns on objects and gets rid of null error.
    //    // interactableLayer calls the interactable layer
    //    if (Physics.Raycast(ray, out hit, 3f, interactableLayer)) // SAYS THAT THE RAY COLLIDED WITH SOMETHING
    //    {
    //        if (targetInteractable == null)
    //        {
    //            // Gets the interface Interactable hit access.collider accesses GetComponent IInteractable to interact.
    //            targetInteractable = hit.collider.GetComponent<IInteractable>();
    //            //interactable calls OnHoverEnter 
    //            targetInteractable.OnHoverEnter(); //06/05/2024 moved into if targetinteractable == null
    //                                               // interactable calls the OnInteract. 
    //        }
    //        else
    //        {
    //            if (Input.GetKeyDown(KeyCode.E) && targetInteractable != null)
    //            {

    //                targetInteractable.OnInteract(this); //06/05/2024 moved into if targetinteractable == null
    //                                                     // Pressing the 'E' key does: 
    //                                                     // Debug.Log(Input.mousePosition);
    //                                                     // this means calling the monobehaviors call.

    //                // Ray now follows mousePosition is not suitable for a 3D game because change in screen sizes.

    //                // draws a ray from start to direction with the color and the duration, used to interact with objects in game.
    //                //Debug.DrawRay(shootingPoint.transform.position, camera.transform.forward, Color.red, 3f);
    //                // draws a ray from start to direction with the color and the duration, used to interact with objects in game.
    //                // ray is called from the Screen point to ray.
    //                // a red line shoot now shoot out of the Player where the mouse is pointing.
    //                // Debug.DrawRay(ray.origin, ray.direction, Color.red, 3f);
    //                // Debug.Log(hit.collider.gameObject.name);    
    //            }
    //        }
    //    }
    //    // if the target interactable is not equal to null
    //    // then the target method accesses on hoverexit and target interactable = null.
    //    else if (targetInteractable != null)
    //    {
    //        targetInteractable.OnHoverExit();
    //        targetInteractable = null;
    //    }
    //    else
    //    {

    //    }

    //}

    //private void Jump()
    //{
    //    // pressing space applies force. AND IsGrounded bool check method to prevent jumping in air.
    //    if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
    //    {
    //        // initial velocity
    //        velocity.y = jumpForce;
    //    }
    //}
    //private void Shoot()  
    //{
    //    //pressing the left click fires a projectile prefab
    //    if(Input.GetMouseButtonDown(0))
    //    {
            
    //    }
    //}
    //private void ApplyGravity() //06/03/2024 Mon
    //{
    //    if (!IsGrounded())
    //    {
    //        velocity.y += gravityAcceleration * Time.deltaTime;



    //        if (velocity.y < -9.81f)
    //        {
    //            velocity.y = -9.81f;
    //        }
    //    }
    //    else if(velocity.y < 0)
    //    {
    //        velocity.y = 0;
    //    }

    //    controller.Move(velocity * Time.deltaTime);
    //}

    //private bool IsGrounded() //returns the Checksphere.
    //{
    //    return Physics.CheckSphere(transform.position, 0.25f, floorLayer);
    //}

    //private void MovePlayer()
    //{
    //    // Gets the axis and position of the Player on x and y axis.
    //    // GetAxisRaw gives whole values and makes the moving more smooth and easier to control.
    //    // GetAxis makes the value a float and harder to control.
    //    // blue arrow is "forward"
    //    moveDirection.x = Input.GetAxisRaw("Horizontal");
    //    moveDirection.z = Input.GetAxisRaw("Vertical");

    //    // local speed multiplier
    //    float tempMultiplier = 1;

    //    // Pressing this key makes the Player sprint while pressed is set to =true.
    //    if (Input.GetKeyDown(KeyCode.LeftShift))
    //    {
    //        //Started running
    //        //tempMultiplier is used instead of a hard coded value.
    //        tempMultiplier = sprintingMultiplier;
    //    }

    //    // -controller accesses movemethod and the moveDirection variable for the position on x and y.
    //    // -Time.deltaTime moves it according to time and not frame. smooth gameplay.
    //    // * speed is to incorporate the speed variable to the working controller.
    //    // * sprintingMultiplier increases the multiplier of speed.
    //    // * tempMultiplier calls the local variable instead of hard coding a value.
    //    // -local variable makes the multiplier changeable in inspector easier to test.
    //    controller.Move(((transform.right * moveDirection.x) + (transform.forward * moveDirection.z)) * Time.deltaTime * speed * tempMultiplier);
    //}

    //private void RotatePlayer()
    //{
    //    // aim with mouse.
    //    aimDirection.x = Input.GetAxisRaw("Mouse X");
    //    aimDirection.y += -Input.GetAxisRaw("Mouse Y") * Time.deltaTime * mouseSensitivity;
    //    // Clamps the y axis so that the Player view can not go upside down.
    //    aimDirection.y = Mathf.Clamp(aimDirection.y, -85f, 85f);
    //    //keeps the aim direction rotation on the x to 0.
    //    cam.transform.localEulerAngles = new Vector3(aimDirection.y, 0, 0);
    //    // -"right" is the x axis. "up is the y axis. "forward" is the z axis.
    //    // -camera accesses the Player transform accesses the Method Rotate on a Vector 3 fill in to make work no errors.
    //    // -Time.deltaTime is by time not frame and mouseSensitivity is a multiplier of the mouseSensitivity variable.
    //    // -drag and drop the main camera to the script in the inspector of the Player Object to use.
    //    // -aimdirection removes the inversion of y. Can add a if bool to use as a setting to toggle inversion on or off.
        
    //    // -Next Line: Fixes bug when aiming with mouse to fix the moveDirection to x and z axis.
    //    //controller.Move(((transform.right * moveDirection.x) + (transform.forward * moveDirection.z)) * Time.deltaTime * speed * tempMultiplier);
    //    // -aim direction rotation to time and not frames. * by variable mouseSensitivity adjustable in inspector.
    //    transform.Rotate(Vector3.up, aimDirection.x * Time.deltaTime * mouseSensitivity);

    //    //camera.transform.Rotate(Vector3.right, -aimDirection.y * Time.deltaTime * mouseSensitivity);
    //}

    // puts the held object in a fixed position every time an object is interacted
    // with.
   
//}
