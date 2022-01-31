using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fin : MonoBehaviour
{
    public bool trouvé;
    [SerializeField] AudioSource[] Voix;
    AudioSource Joué;
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

        if (trouvé)
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
                Joué = Voix[essais];
                Joué.Play();
                essais++;
            }
        }
       
    }

    public void Trouvé()
    {
        trouvé = true;
    }
}
