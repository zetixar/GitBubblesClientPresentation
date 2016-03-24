using UnityEngine;
using System.Collections;

public class testRay : MonoBehaviour {

	public LayerMask mask;
	// Use this for initialization
	void Start () {
	
	}

	public void clickMask()
	{
		Debug.Log("CLICKED!");
	}
	
	// Update is called once per frame
	void Update () 
	{

		if(Input.GetMouseButtonDown(0))
		
		{
			
			Vector3 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);    
			RaycastHit2D[] hit = Physics2D.RaycastAll(mousePos, Vector3.forward, 100f, mask);//, Vector2.up, mask);

			if (hit.Length > 0)
			{
				for (int i = 0; i < hit.Length; i++)// (RaycastHit2D hitt in hit)
				{
//					if(hit[i].collider != null)
					{
						//				Debug.DrawLine(, hit.point);
						if (hit[i].transform.gameObject.name == "Quad")
							Debug.Log("Quad hit: " + hit[i].point);
						else
							Debug.Log("Btn hit: " + hit[i].point);
						//				hit.collider.gameObject.layer
					}

				}

			}
		}

		//		Vector3 point = aScreenPosition + new Vector3(Camera.main.transform.position.x,Camera.main.transform.position.y, 0);
	}
}
