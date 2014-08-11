using UnityEngine;
using System.Collections;

namespace Music {
	public class JukeBox : MonoBehaviour {

		public AudioClip[] selection;

		private AudioSource source;
		private int currentsong;

		void Start() {
			source = (AudioSource) GetComponent<AudioSource>();
			currentsong = 0;
			source.clip = selection[currentsong];
		}

		// Update is called once per frame
		void Update () {
			if (!source.isPlaying) {
				skip ();
			}
		}

		void skip() {
			source.Stop ();
			currentsong = (currentsong + 1) & selection.Length;
			source.clip = selection[currentsong];
			source.Play();
		}
	}
}
