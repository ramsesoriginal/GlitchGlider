using UnityEngine;
using System.Collections;
using System;

namespace Course {
	public class CourseCounter : MonoBehaviour {

		public int count;
		public float startTime;

		public int done;
		public int missing;

		public float time;

		// Use this for initialization
		void Start () {
			InitilizeCounter ();
		}
		
		// Update is called once per frame
		void Update () {
			if (missing == 0) {
				if (count > 0)
					Time.timeScale = 0.1f;
			} else {
				Time.timeScale = 1.0f;
				missing = ((Gate.Passer[])GetComponentsInChildren<Gate.Passer> ()).Length;
				done = count - missing;
				time = Time.time - startTime;
			}

		}

		public void InitilizeCounter() {
			startTime = Time.time;
			time = 0;
			count = ((Gate.Passer[])GetComponentsInChildren<Gate.Passer> ()).Length;
			missing = count;
			done = 0;
		}
	}
}
