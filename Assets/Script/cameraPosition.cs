using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.position = new Vector3(transform.position.x, 3f, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, 7f, transform.position.z);
        }
    }
}
