using UnityEngine;
using System.Collections;

namespace Player {
	public class CameraStartPosition : MonoBehaviour {

		// Use this for initialization
		void Start () {
			ResetCamera ();
		}
		
		// Update is called once per frame
		void Update () {
		
		}

		public void ResetCamera() {
			GameObject.FindWithTag("MainCamera").transform.position = transform.position;
		}
	}
}