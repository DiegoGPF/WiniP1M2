using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Photon.Pun;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private CharacterController controller;
    [SerializeField] private PhotonView view;
    [SerializeField] private float speed = 10f;
    [SerializeField] private float gravity = -9.81f;
    [SerializeField] private float jumpHeight = 3f;

    [SerializeField] private float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    [SerializeField] private Transform groundCheck;
    [SerializeField] private float groundDistance = 0.4f;
    [SerializeField] private LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;
    private void Update()
    {
        if (view.IsMine)
        {
            isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

            if (isGrounded && velocity.y < 0)
            {
                velocity.y = -2f;
            }

            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

            if (direction.magnitude >= 0.1f)
            { 
                float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
                float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
                transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);

                

                controller.Move(direction * speed * Time.deltaTime);

                if(Input.GetButtonDown("Jump") && isGrounded)
                {
                    velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
                }

                velocity.y += gravity * Time.deltaTime;

                controller.Move(velocity * Time.deltaTime);
            }
        }
        
    }
}
