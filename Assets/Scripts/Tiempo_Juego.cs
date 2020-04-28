using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tiempo_Juego : MonoBehaviour
{
    public Text Tempo;
    // public float tiempo = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        Tempo.text = "" + (int) Time.timeSinceLevelLoad + "";
    }

    // Update is called once per frame
    void Update()
    {
        Tempo.text = "" + (int) Time.timeSinceLevelLoad + "";
    }
}
