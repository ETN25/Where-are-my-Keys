using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouselook : MonoBehaviour
{
 
    public float mouseSensitivity;
    public Transform Body;
    float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // Ici on récupère les mouvements de la souris selon la sensivilité
        float MouseX = (Input.GetAxis("Mouse X"));
        float MouseY = (Input.GetAxis("Mouse Y"));

        xRotation -= MouseY * mouseSensitivity;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        //Permet d'éviter de trop tourner en Y, pour ne pas avoir un torticolis meurtrié

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        Body.Rotate(Vector3.up * MouseX * mouseSensitivity);
        //on fait tourner la cam pour les mouvement de haut en bas et tout le corp pour droite à gauche
    }
}
