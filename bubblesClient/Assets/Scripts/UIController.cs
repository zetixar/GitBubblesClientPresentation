using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class UIController : MonoBehaviour {

	Camera mainCam;
	public Camera miniCam;
	public Button camLockBtn;
	public Button blessingModeBtn;
	public Button pushLinkBtn;

	private Color activeColor = new Color(73,41,198,255);//#BFC6A6FF;
	private Color disableColor = new Color(44,22,198,255);
	// Use this for initialization
	void Start () {
		mainCam = Camera.main;
	}

	public void MoveCamToWhereIClickOnMiniMap ()
	{
		
		Debug.Log("minimapclicked");
		RaycastHit hit;
		Ray ray = miniCam.ScreenPointToRay(Input.mousePosition);
		if(Physics.Raycast(ray,out hit))
		{
//			Debug.Log(hit.collider.tag + hit.collider.name);
//			if(hit.collider.tag == "minimapImage")
			mainCam.transform.position = new Vector3 (hit.point.x, hit.point.y, mainCam.transform.position.z);// Vector3.Lerp(mainCam.transform.position, hit.point, 0.1f);
		}
	}

	public void CamLock()
	{
		netClientMgr.GOspinner.cameraFollowMynode = !netClientMgr.GOspinner.cameraFollowMynode;
		camLockBtn.image.color = netClientMgr.GOspinner.cameraFollowMynode ? activeColor : disableColor;
	}

	public void BlessingMode(int ZeroOffOneOn)
	{
		netClientMgr.GOspinner.blessingMode = (ZeroOffOneOn == 0) ? false : true;
		blessingModeBtn.image.color = netClientMgr.GOspinner.blessingMode ? Color.blue : Color.grey;
		
	}
	public void blessMyGoal()
	{
		netClientMgr.GOspinner.blessMyGoal();
	}

	public void PushLinkMode(int ZeroOffOneOn)
	{
		netClientMgr.GOspinner.pushLinkMode = (ZeroOffOneOn == 0) ? false : true;
		pushLinkBtn.image.color = netClientMgr.GOspinner.pushLinkMode ? Color.blue : Color.grey;
	}

}
