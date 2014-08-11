using UnityEngine;
using System.Collections;

namespace Player {
	public class ResetPlayer : MonoBehaviour {

		private GameObject player;
		private GameObject currentPlayer;
		private PlayerContainer container;
		private GameObject PlayerParent;

		// Use this for initialization
		void Start () {
			PlayerParent = GameObject.FindWithTag ("PlayerParent");
			container = (PlayerContainer)PlayerParent.GetComponent<PlayerContainer>();
			player = container.player;
			StartPlayer ();
		}

		void StartPlayer() {
			currentPlayer = (GameObject) Instantiate (player, transform.position, transform.rotation);
			currentPlayer.transform.parent = PlayerParent.transform;
		}
	}
}
