using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script should only get input from the INPUT class
// and send to our module
public class InputController : MonoBehaviour //06/07/24 friday REFACTORED
{
    [SerializeField] private AmmoStorage ammoStorage;
    [SerializeField] private Camera cam;
    [SerializeField] private float mouseSensitivity;

    [Header("Modules")]
    [SerializeField] private ShootingModule grenadeShootingModule;
    [SerializeField] private ShootingModule shootingModule;
    [SerializeField] private InteractModule interactModule;
    [SerializeField] private MovementModule walkingModule;
    [SerializeField] private JumpModule jumpingModule;

    private bool jumping;
    private bool canLookWithMouse;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Start()
    {
        cam.transform.localEulerAngles = transform.localEulerAngles;
        //This is only to fix an Unity bug in the current version
        Invoke("EnableMouseInput", 1f);
    }

    private void EnableMouseInput()
    {
        canLookWithMouse = true;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDirection = Vector2.zero;
        moveDirection.x = Input.GetAxisRaw("Horizontal");
        moveDirection.z = Input.GetAxisRaw("Vertical");

        Vector2 aimDirection = Vector2.zero;
        aimDirection.x = Input.GetAxisRaw("Mouse X") * mouseSensitivity;
        aimDirection.y = -Input.GetAxisRaw("Mouse Y") * mouseSensitivity;

        if (shootingModule != null && Input.GetMouseButtonDown(0))
        {
            if (ammoStorage.checkAmmo())
            {
                shootingModule.Shoot();
            }
        }

        if (grenadeShootingModule != null && Input.GetMouseButtonDown(1))
        {
            if (ammoStorage.checkGrenades())
            {
                grenadeShootingModule.Shoot();
            }
        }

        if (interactModule != null && Input.GetKeyDown(KeyCode.E))
        {
            interactModule.InteractWithObject();
        }

        if (walkingModule != null)
        {
            walkingModule.MoveCharacter(moveDirection);
            walkingModule.RotateCharacter(aimDirection);
        }

        if (jumpingModule != null && Input.GetKeyDown(KeyCode.Space))
        {
            jumpingModule.Jump();
        }


    }
}
