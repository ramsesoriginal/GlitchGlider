using UnityEngine;
using System.Collections;

namespace Glider {
	public class Accelerator : MonoBehaviour {

		public float speed = 1;
		public float minSpeed = 0.2f;
		public float maxSpeed = 5;
		public float damping = 0.9f;
		//private float currentDamping;

		// Use this for initialization
		void Start () {
		}

		// Update is called once per frame
		void Update () {
			var a = Input.GetAxis("Acceleration");
			/*if (a > -0.1f && a < 0.1f) {
				currentDamping = damping;
			} else {
				currentDamping *= damping;
			}*/
			speed += a * damping;
			if (speed < minSpeed)
				speed = minSpeed;
			if (speed > maxSpeed)
				speed = maxSpeed;
		}

		void FixedUpdate() {
			rigidbody.AddForce(transform.forward * speed * 1000,ForceMode.Acceleration);
		}
	}
}
