using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoMata : MonoBehaviour
{
    public AudioClip muerte = null;


    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Enemigo")
        {
            AudioSource.PlayClipAtPoint(muerte, transform.position, PlayerPrefs.GetFloat("Volumen"));
            Time.timeScale = 0; 
        }
    }

}
