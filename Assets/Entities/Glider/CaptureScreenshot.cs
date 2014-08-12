using UnityEngine;
using System.Collections;

public class CaptureScreenshot : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.J)) {
			Application.CaptureScreenshot("Screenshot"+System.DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss")+".png");
		}
		if (Input.GetKeyDown (KeyCode.K)) {
			Application.CaptureScreenshot("Screenshot"+System.DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss")+".png",3);
		}
	}
}
