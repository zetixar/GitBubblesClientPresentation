using UnityEngine;
using System.Collections;

public class GUIManager : MonoBehaviour {

	public RenderTexture minimapTexture;
	public Material minimapMaterial;
	public float xOffset = 100.0f;
	public float yOffset = 100.0f;
	public float width = 256;
	public float height = 256;
	public int depth = 1;
	public float wR = 1.0f;
	public float hR = 1.0f;



	void OnGUI () {
		GUI.depth = depth;
		width = Screen.width / wR;
		height = Screen.height / hR;
			Graphics.DrawTexture(new Rect(xOffset, Screen.height - height - yOffset, width,height),minimapTexture, minimapMaterial);

	}
}
