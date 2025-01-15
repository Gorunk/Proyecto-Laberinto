using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collition : MonoBehaviour
{


    public AudioSource collectSound;
    public GameObject portal = null;
    public GameObject puerta = null;
    public GameObject llave = null;

    private void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        portal.SetActive(true);
        puerta.SetActive(false);
        llave.SetActive(false);
    }
}
    