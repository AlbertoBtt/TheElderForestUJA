using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinternaEnemigo : MonoBehaviour
{
    public Camera cam;
    public GameObject luz;
    public GameObject Enemigos;
    private float velocidad_antigua;
    public AudioClip audio;
    public AudioSource source;


    // Update is called once per frame
    void Start() 
    {
        velocidad_antigua = Enemigos.GetComponent<Enemigo>().velocidad;
    }

    void Update()
    {
        if (luz.activeSelf) 
        {
            RaycastHit hit;
            if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, 5))
            {
                if (hit.collider.gameObject.tag == "Enemigo")
                {
                    Enemigos.GetComponent<Enemigo>().velocidad = 0.2f;
                }
                
            }
            else
            {
                Enemigos.GetComponent<Enemigo>().velocidad = velocidad_antigua;
            }
        }else
            {
                Enemigos.GetComponent<Enemigo>().velocidad = velocidad_antigua;
            }
    }

}
