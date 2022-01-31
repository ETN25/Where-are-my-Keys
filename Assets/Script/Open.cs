using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open : MonoBehaviour
{
    public Animator Animator;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("1");
        if (collision.CompareTag("MainCamera"))
        {
            Debug.Log("2");
            if (Input.GetKeyDown(KeyCode.E))
            {
                Animator.SetTrigger("Interaction");
            }
        }
    }
}
