using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class actualizarSonido : MonoBehaviour
{
    public AudioSource volumen;
    public Text texto;
    void Update()
    {
        texto.text = (volumen.volume*100).ToString("000.");
    }
}
