using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpModule : MonoBehaviour //06/07/24
{
    [Header("Jumping")]
    //force of gravity //const makes constant throughout program(unadjustable)
    [SerializeField] public const float gravityAcceleration = -9.81f;
    //Jump force velocity variable
    [SerializeField] private Vector3 velocity;

    [SerializeField] CharacterController controller;
    [SerializeField] private float jumpForce;
    //Creates a floor layer to check in inspector
    [SerializeField] private LayerMask floorLayer;

    public void Jump()
    {
        if (IsGrounded() && controller)
        {
            velocity.y = jumpForce;
        }
    }

    private bool IsGrounded()
    {
        return Physics.CheckSphere(transform.position, 0.25f, floorLayer);
    }

    private void ApplyGravity()
    {
        if (!IsGrounded())
        {
            velocity.y += gravityAcceleration * Time.deltaTime;

            if (velocity.y < -9.81f)
            {
                velocity.y = -9.81f;
            }
        }
        else if (velocity.y < 0)
        {
            velocity.y = 0;
        }

        controller.Move(velocity * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        ApplyGravity();
    }
}
