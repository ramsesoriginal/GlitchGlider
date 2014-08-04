using UnityEngine;
using System.Collections;

namespace Glider {
	public class Roll : MonoBehaviour {
		public float turnSpeed;

		// Update is called once per frame
		void Update () {
			var h = Input.GetAxis("Horizontal");
			transform.RotateAround(transform.forward, -h * turnSpeed * Time.deltaTime);
		
		}
	}
}