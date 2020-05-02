using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public Transform objetivo;
    public float velocidad, distancia, daño;

    void Update()
    {
        RaycastHit raycast;
        if (Physics.Raycast(transform.position, transform.forward, out raycast, Mathf.Abs(distancia)))
        {
            if (raycast.collider.gameObject.CompareTag("Player"))
            {
            }
            else
            {
                transform.position = Vector3.Lerp(transform.position, objetivo.position, Mathf.Abs(Time.deltaTime * velocidad));
                transform.LookAt(objetivo);
            }
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, objetivo.position, Mathf.Abs(Time.deltaTime * velocidad));
            transform.LookAt(objetivo);
        }
    }
}
