using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fin : MonoBehaviour
{
    public bool trouv�;
    [SerializeField] AudioSource[] Voix;
    AudioSource Jou�;
    [SerializeField]  int essais = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interaction()
    {

        if (trouv�)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            if (essais > 6)
            {
                SceneManager.LoadScene(0);
            }
            else
            {
                Jou� = Voix[essais];
                Jou�.Play();
                essais++;
            }
        }
       
    }

    public void Trouv�()
    {
        trouv� = true;
    }
}
