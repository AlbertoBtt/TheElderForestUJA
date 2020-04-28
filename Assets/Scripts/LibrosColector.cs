using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LibrosColector : MonoBehaviour
{
    public static int puntos = 0;
    public Text score;

    void OnTriggerEnter(Collider collision) 
    {
        if(collision.gameObject.tag == "Libro")
        {
            puntos += 1;
            Destroy(collision.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Libros: " + puntos + " de 10";
    }

}
