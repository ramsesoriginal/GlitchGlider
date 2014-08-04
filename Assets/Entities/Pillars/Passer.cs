using UnityEngine;
using System.Collections;

namespace Gate {
	public class Passer : MonoBehaviour {

		// Update is called once per frame
		void OnTriggerEnter (Collider other) {
			Destroy (gameObject);
		}
	}
}
