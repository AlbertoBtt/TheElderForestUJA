using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LibrosColector : MonoBehaviour
{
    public static int puntos = 0;
    public Text score;
    public AudioClip sonidopagina = null;
    public Text notificacion;

    private void Start()
    {
        notificacion.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider collision) 
    {
        if(collision.gameObject.tag == "Libro")
        {
            puntos += 1;
            AudioSource.PlayClipAtPoint(sonidopagina, transform.position, 1.0f);
            StartCoroutine(mostrar_texto());
            Destroy(collision.gameObject);
            
        }
    }

    IEnumerator mostrar_texto()
    {
        notificacion.gameObject.SetActive(true);
        yield return new WaitForSeconds(3);
        notificacion.gameObject.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        score.text = "Libros: " + puntos + " de 10";
    }

}
