using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inicializar : MonoBehaviour
{
    public AudioSource[] sonido;
    // Start is called before the first frame update
    void Start()
    {
        QualitySettings.SetQualityLevel(PlayerPrefs.GetInt("Graficos"));
        for(int i = 0; i < sonido.Length; i++)
        {
            sonido[i].volume = PlayerPrefs.GetFloat("Volumen");
        }
    }
}
