using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class btn2 : MonoBehaviour, IPointerClickHandler {

	public void OnPointerClick (PointerEventData eventData)
	{
		Debug.Log("btn2");
	}

}