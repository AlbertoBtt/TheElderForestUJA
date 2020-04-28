using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class graficosSubir : MonoBehaviour, IPointerClickHandler
{
    public Text texto;

    public void OnPointerClick(PointerEventData eventData)
    {
        int calidad = QualitySettings.GetQualityLevel();
        if (calidad != 6)
        {
            calidad++;
            texto.text = getCalidad(calidad);
            QualitySettings.SetQualityLevel(calidad);
        }
    }

    private string getCalidad(int escena)
    {
        string frase = "";
        switch (escena)
        {
            case 0:
                frase = "Retro";
                break;
            case 1:
                frase = "Muy Bajos";
                break;
            case 2:
                frase = "Bajos";
                break;
            case 3:
                frase = "Medios";
                break;
            case 4:
                frase = "Altos";
                break;
            case 5:
                frase = "Muy Altos";
                break;
            case 6:
                frase = "Ultra";
                break;
        }
        return frase;
    }
}
