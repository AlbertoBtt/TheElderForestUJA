using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LibrosColector : MonoBehaviour
{
    public static int puntos = 0;
    public Text score;
    public AudioClip sonidopagina = null;
    public Text notificacion;
    public AudioSource audiosonido;

    private void Start()
    {
        notificacion.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider collision) 
    {
        if(collision.gameObject.tag == "Libro")
        {
            puntos += 1;
            audiosonido.PlayOneShot(sonidopagina, PlayerPrefs.GetFloat("Volumen"));
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
        if (Input.GetKeyDown(KeyCode.C))
        {
            puntos = 10;
        }
        if (puntos == 10)
        {
            puntos = 0;
            SceneManager.LoadScene(4);
        }
    }

}
