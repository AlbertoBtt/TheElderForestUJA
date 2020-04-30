using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Linterna : MonoBehaviour
{
    public bool regenerarBateria;
    float bateria;
    public float bateriaMaxima;
    public GameObject luz;
    public GameObject jugador;
    //public Text texto;
    public Slider slider;
    public AudioClip Sonido = null;
    public AudioSource audiosonido;

    private void Start()
    {
        //bateria = Mathf.Abs(bateriaMaxima);
        slider.value = slider.maxValue;
        luz.SetActive(false);
    }

    void Update()
    {
        //slider.value = bateria;
        //texto.text = "Bateria: " + bateria.ToString("0") + "%";
        if (luz.activeSelf)
            slider.value -= 1;
        //else if (!luz.activeSelf && bateria < Mathf.Abs(bateriaMaxima) && regenerarBateria)
        //    bateria += Time.deltaTime;

        //if (bateria <= 0)
        //    luz.SetActive(false);

        if(Input.GetKeyDown(KeyCode.F) && slider.value > slider.minValue)
        {
            audiosonido.PlayOneShot(Sonido, PlayerPrefs.GetFloat("Volumen"));
            if (luz.activeSelf)
            {
                luz.SetActive(false);
            }
            else {
                luz.SetActive(true);
            }
            //GetComponent<AudioSource>().Play();
        }
    }

    public void AgregarBateria (float bateriaRegenerada)
    {
        bateria += bateriaRegenerada;
        if (bateria >= bateriaMaxima)
            bateria = bateriaMaxima;
    }
}
