using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonidoComponente : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("Volumen");
    }
}
