using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tiempo_Camara : MonoBehaviour
{
    public Text Tiempo;
    float gametimer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        //Tiempo.text = "" + (int) Time.timeSinceLevelLoad;
    }

    // Update is called once per frame
    void Update()
    {
        //Tiempo.text = "" + (int)Time.timeSinceLevelLoad;
        gametimer += Time.deltaTime;

        int segundo = (int)(gametimer % 60);
        int minuto = (int)(gametimer / 60) & 60;
        int hora = (int)(gametimer / 3600) % 24;

        string timerstring = string.Format("{0:0}:{1:00}:{2:00}", hora, minuto, segundo);

        Tiempo.text = timerstring;
    }
}
