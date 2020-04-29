using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class CambiarAjustes : MonoBehaviour, IPointerClickHandler
{
    public AudioSource sonido;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            PlayerPrefs.SetFloat("Volumen", sonido.volume);
            PlayerPrefs.SetInt("Graficos", QualitySettings.GetQualityLevel());
            SceneManager.LoadScene(0);
        }
    }
}
