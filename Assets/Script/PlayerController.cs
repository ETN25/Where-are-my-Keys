using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 10f;
    public float Vx = 0f;
    public float Vz = 0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.W))
        {
            Vz = 1;
        }
        else
        {
            if (Input.GetKey(KeyCode.S))
            {
                Vz = -1;
            }
            else
            {
                Vz = 0;
            }
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.Q))
        {
            Vx = -1;
        }
        else
        {
            if (Input.GetKey(KeyCode.D))
            {
                Vx = 1;
            }
            else
            {
                Vx = 0;
            }
        }

        Vector3 move = transform.right * Vx + transform.forward * Vz;

        controller.Move(move * speed * Time.deltaTime);
    }
}
