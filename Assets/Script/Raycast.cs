using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Raycast : MonoBehaviour
{
    public string pointable = "pointable";
    Vector3 rayOrigin = new Vector3(Screen.width / 2, Screen.height /2, 0f);
    float rayLeght = 8f;
    public GameObject E;
    public GameObject Toaster;
    public GameObject Cam;
    public GameObject porte;
    [SerializeField] int Choix;
    [SerializeField] AudioSource V1, V2;

    private Transform Selection;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Choix = Random.Range(1, 3);
    }

    // Update is called once per frame
    void Update()
    {
        if (Selection != null)
        {
            Selection = null;
            E.SetActive(false);
        }

        Ray ray = Camera.main.ScreenPointToRay(rayOrigin); 
        RaycastHit Hit;
        if (Physics.Raycast(ray, out Hit, rayLeght))
        {
            var selection = Hit.transform;
            
            if (selection.CompareTag("pointable"))
            {
                E.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    selection.GetComponent<Animator>().SetTrigger("Interaction");
                }
                Selection = selection;
            }
            else
            {
                if (selection.CompareTag("téléphone"))
                {
                    E.SetActive(true);
                    
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        selection.GetComponent<phoneInteract>().Interaction();
                    }
                    Selection = selection;


                }
                else
                {
                    if (selection.CompareTag("Smartphone"))
                    {
                        E.SetActive(true);
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            selection.GetComponent<Smartphone>().Interaction();
                            porte.GetComponent<Fin>().Trouvé();

                            if (Choix == 1)
                            {
                                V1.Play();
                            }
                            else
                            {
                                V2.Play();
                            }
                        }
                        Selection = selection;
                    }
                    else
                    {
                        if (selection.CompareTag("sound"))
                        {
                            E.SetActive(true);
                            if (Input.GetKeyDown(KeyCode.E))
                            {
                                selection.GetComponent<Sound>().Interaction();
                            }
                            Selection = selection;
                        }
                        else
                        {
                            if (selection.CompareTag("Fin"))
                            {
                                E.SetActive(true);
                                if (Input.GetKeyDown(KeyCode.E))
                                {
                                    selection.GetComponent<Fin>().Interaction();
                                }
                                Selection = selection;
                            }
                            else
                            {
                                E.SetActive(false);
                            }
                        }
                    }
                }
            }
        }
    }
}
