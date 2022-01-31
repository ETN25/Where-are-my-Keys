using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smartphone : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3[] Position = new Vector3[6];
    int Choix;
    AudioSource Voixchoisie;
    void Start()
    {
        Choix = Random.Range(0, Position.Length);
        transform.position = Position[Choix];

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interaction()
    {
        gameObject.SetActive(false);

    }
}
