using UnityEngine;
using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class bg1 : MonoBehaviour, IPointerClickHandler {

	public void OnPointerClick (PointerEventData eventData)
	{
		Debug.Log("bg1");
	}

}