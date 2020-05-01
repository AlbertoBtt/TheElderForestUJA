using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoArea : MonoBehaviour
{
    public float range=10F;
    public Transform player;
    public AudioSource[] audiosonido;
    public AudioSource enemigo;
    public GameObject fps;
    private bool primeravez;
    public AudioClip audioclip;

    void Update()
    {
        if (Vector3.Distance(player.position, transform.position) <= range)
        {

            for (int i = 0; i < audiosonido.Length; i++)
            {
                audiosonido[i].mute = true;
            }
            if (primeravez)
            {
                enemigo.Play();

                primeravez = false;
            }
            fps.GetComponent<AudioSource>().mute = true;
        }
        else
        {
            for (int i = 0; i < audiosonido.Length; i++)
            {
                audiosonido[i].mute = false;
            }
            primeravez = true;
            enemigo.Stop();
            fps.GetComponent<AudioSource>().mute = false;
        }
    }
}
