using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SubirVolumen : MonoBehaviour, IPointerClickHandler
{
	public AudioSource sonido;

	public void OnPointerClick(PointerEventData eventData)
	{
		if (sonido.volume < 1)
		{
			sonido.volume = sonido.volume + (float)0.01;
		}
	}
}
