using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class clickContinuar : MonoBehaviour, IPointerClickHandler
{
    public GameObject objeto;
    public void OnPointerClick(PointerEventData eventData)
    {
        objeto.GetComponent<salirAlMenu>().retomar();
    }
}
