using UnityEngine;
using System.Collections;

namespace Glider {
	public class cameraPositioner : MonoBehaviour {
		public Transform target;
		public Transform player;
		
		// Update is called once per frame
		void Update () {
			if (target == null) {
				target = GameObject.FindWithTag("CameraTarget").transform;
			}
			if (player == null) {
				player = GameObject.FindWithTag("CameraLookAtTarget").transform;
			}
			var targetPos = target.position;
			RaycastHit hit;
			if (Physics.Raycast(targetPos, Vector3.down, out hit)) {
				if (Vector3.Distance(hit.point, targetPos) < 4.0f) {
					targetPos.y += 4.0f;
				}
			} else if (Physics.Raycast(targetPos, Vector3.up, out hit)) {
				targetPos.y += 4.0f + Vector3.Distance(hit.point, targetPos);
			}
			transform.position = Vector3.Slerp(transform.position, targetPos,  Time.deltaTime);
			transform.LookAt (player);
		}
	}
}
