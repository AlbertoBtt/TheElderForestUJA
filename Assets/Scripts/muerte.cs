using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class muerte : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(continuar());
    }
    IEnumerator continuar()
    {
        yield return new WaitForSeconds(11);
        SceneManager.LoadScene(0);
    }
}
