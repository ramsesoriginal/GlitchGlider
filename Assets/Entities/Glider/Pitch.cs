using UnityEngine;
using System.Collections;

namespace Glider {
	public class Pitch : MonoBehaviour {
		public float turnSpeed;

		// Update is called once per frame
		void Update () {
			var v = Input.GetAxis("Vertical");
			transform.RotateAround(transform.right, v * turnSpeed * Time.deltaTime);
		}
	}
}
