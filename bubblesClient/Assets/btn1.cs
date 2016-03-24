using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class btn1 : MonoBehaviour, IPointerClickHandler {

	public void OnPointerClick (PointerEventData eventData)
	{
		Debug.Log("btn1");
	}

}
