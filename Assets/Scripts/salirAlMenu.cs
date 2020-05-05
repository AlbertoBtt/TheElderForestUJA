using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;


public class salirAlMenu : MonoBehaviour
{
    public GameObject menu;
    public GameObject UI;
    public GameObject camara;
    private bool activado;
    // Start is called before the first frame update
    void Start()
    {
        activado = false;
        menu.gameObject.SetActive(false);
        UI.gameObject.SetActive(true);
        Time.timeScale = 1;
        camara.GetComponent<FirstPersonController>().libre = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (!activado)
            {
                Time.timeScale = 0;
                activado = true;
                UI.gameObject.SetActive(false);
                menu.gameObject.SetActive(true);
                camara.GetComponent<FirstPersonController>().libre = false;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }
    }

    public void retomar()
    {
        activado = false;
        menu.gameObject.SetActive(false);
        UI.gameObject.SetActive(true);
        Time.timeScale = 1;
        camara.GetComponent<FirstPersonController>().libre = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
