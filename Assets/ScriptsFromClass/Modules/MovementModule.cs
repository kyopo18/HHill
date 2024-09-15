using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementModule : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] CharacterController controller;
    [SerializeField] private Transform headUpDown;
    [SerializeField] private float movementSpeed;
    private Vector3 moveDirection = new Vector3(0,0,0);
    private Vector3 aimDirection;
    private bool canlookWithMouse;

    private void Start()
    {
        Invoke("EnableMouseInput", 1f);
    }

    private void EnableMouseInput()
    {
        canlookWithMouse = true;
    }

    public void MoveCharacter(Vector3 direction)
    {
        moveDirection.x = direction.x;
        moveDirection.z = direction.z;

        float tempMultiplier = 1;

        controller.Move(((transform.right * moveDirection.x) + (transform.forward * moveDirection.z)) * Time.deltaTime * movementSpeed * tempMultiplier);
    }

    public void RotateCharacter(Vector3 direction)
    {
        aimDirection.x = direction.x; 
        aimDirection.y += direction.y * Time.deltaTime;

        aimDirection.y = Mathf.Clamp(aimDirection.y, -85f, 85f);

        //IN CASE OF USING A NPC, NO NEED TO ROTATE HEAD UP AND DOWN
        //ONLY THE PLAYER CAN ROTATE UP AND DOWN
        //(assing camera to the HeadUpDown variable)
        //if (headUpDown) headUpDown.localEulerAngles = new Vector3(aimDirection.y, 0, 0);
        cam.transform.localEulerAngles = new Vector3(aimDirection.y, 0, 0);

        //ROTATE THIS CHARACTER LEFT OR RIGHT (ON Y AXIS)
        transform.Rotate(Vector3.up, aimDirection.x * Time.deltaTime);
    }

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
}
