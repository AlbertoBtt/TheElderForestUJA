using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class graficosInicial : MonoBehaviour
{
    public Text texto;
    void Start()
    {
        texto.text = getCalidad(QualitySettings.GetQualityLevel());
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
