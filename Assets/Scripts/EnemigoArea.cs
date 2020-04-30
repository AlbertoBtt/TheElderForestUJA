using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoArea : MonoBehaviour
{
    public float range=10F;
    public Transform player;
    public AudioSource[] audiosonido;
    public GameObject fps;

    void Update()
    {
        if (Vector3.Distance(player.position, transform.position) <= range)
        {
            for(int i = 0; i < audiosonido.Length; i++)
            {
                audiosonido[i].mute = true;
            }
            fps.GetComponent<AudioSource>().mute = true;
        }
        else
        {
            for (int i = 0; i < audiosonido.Length; i++)
            {
                audiosonido[i].mute = false;
            }
            fps.GetComponent<AudioSource>().mute = false;
        }
    }
}
