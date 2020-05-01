using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ganar : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(continuar());
    }
    IEnumerator continuar()
    {
        yield return new WaitForSeconds(12);
        SceneManager.LoadScene(0);
    }
}
