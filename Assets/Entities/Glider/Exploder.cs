using UnityEngine;
using System.Collections;

namespace Glider {
	public class Exploder : MonoBehaviour {

		public GameObject explosion;
		public GlitchEffect glitch;
		public GameObject CameraPosition;
		public GameObject CameraTarget;
		
		// Update is called once per frame
		void OnCollisionEnter () {
			if (CameraPosition == null) {
				CameraPosition = GameObject.FindWithTag("CameraTarget");
			}
			if (CameraTarget == null) {
				CameraTarget = GameObject.FindWithTag("CameraLookAtTarget");
			}
			if (glitch == null) {
				glitch = (GlitchEffect)GameObject.FindWithTag("MainCamera").GetComponent<GlitchEffect>();
			}
			var exPlayer = new GameObject ();
			exPlayer.transform.position = transform.position;
			exPlayer.transform.rotation = transform.rotation;
			exPlayer.transform.parent = transform.parent;
			var explosionClone = (GameObject)Instantiate (explosion, exPlayer.transform.position, exPlayer.transform.rotation);
			explosionClone.transform.parent = exPlayer.transform;
			CameraPosition.transform.parent = exPlayer.transform;
			CameraTarget.transform.parent = exPlayer.transform;
			glitch.intensity = 2;
			Destroy (gameObject);

		}
	}
}
