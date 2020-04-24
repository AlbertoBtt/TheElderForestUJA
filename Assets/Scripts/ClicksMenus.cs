using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ClicksMenus : MonoBehaviour, IPointerClickHandler
{
	public AudioSource source;
	public AudioClip audioClick;
	public void OnPointerClick(PointerEventData eventData)
	{
		source.PlayOneShot(audioClick);
	}
}
