using UnityEngine;
using System.Collections;

namespace Glider {
	public class cameraPositioner : MonoBehaviour {
		public Transform target;
		public Transform player;
		
		// Update is called once per frame
		void Update () {
			GameObject temp;
			if (target == null) {
				temp =  GameObject.FindWithTag("CameraTarget");
				if (temp != null)
					target =  temp.transform;
			}
			if (player == null) {
				temp = GameObject.FindWithTag("CameraLookAtTarget");
				if (temp != null)
					player = temp.transform;
			}

			if (target != null && player != null) {
				var targetPos = target.position;
				RaycastHit hit;
				if (Physics.Raycast (targetPos, Vector3.down, out hit)) {
						if (Vector3.Distance (hit.point, targetPos) < 4.0f) {
								targetPos.y += 4.0f;
						}
				} else if (Physics.Raycast (targetPos, Vector3.up, out hit)) {
						targetPos.y += 4.0f + Vector3.Distance (hit.point, targetPos);
				}
				transform.position = Vector3.Slerp (transform.position, targetPos, Time.deltaTime);
				transform.LookAt (player);
			}
		}
	}
}
