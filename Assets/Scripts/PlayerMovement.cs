using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController controller;
    [SerializeField] private float speed;
    [SerializeField] private PhotonView view;

    private void Update()
    {
       if (view.IsMine)
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

            if (direction.magnitude >= 0.1f)
            {
                controller.Move(direction * speed * Time.deltaTime);
            }
            //if (Input.GetKey("d")) transform.position += Vector3.right * speed * Time.deltaTime;
            //if (Input.GetKey("a")) transform.position += Vector3.left * speed * Time.deltaTime;
            //if (Input.GetKey("w")) transform.position += Vector3.forward * speed * Time.deltaTime;
            //if (Input.GetKey("s")) transform.position += Vector3.back * speed * Time.deltaTime;
        }
    }
}
