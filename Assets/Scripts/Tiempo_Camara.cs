using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tiempo_Camara : MonoBehaviour
{
    public Text Tiempo;
    // Start is called before the first frame update
    void Start()
    {
        Tiempo.text = "" + (int) Time.timeSinceLevelLoad;
    }

    // Update is called once per frame
    void Update()
    {
        Tiempo.text = "" + (int)Time.timeSinceLevelLoad;
    }
}
