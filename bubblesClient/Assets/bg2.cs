using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class bg2 : MonoBehaviour, IPointerClickHandler {

	public void OnPointerClick (PointerEventData eventData)
	{
		Debug.Log("bg2");
	}

}
