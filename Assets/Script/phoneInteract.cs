using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phoneInteract : MonoBehaviour
{
    public GameObject Smartphone;
    public AudioSource Appel;
    public AudioSource Voix;
    bool Appelé;
    // Start is called before the first frame update
    void Start()
    {
        Appel = Smartphone.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interaction()
    {
        if (Appelé == false)
        {
            Appel.Play();
            Voix.Play();
            Appelé = true;
        }
    }
}
