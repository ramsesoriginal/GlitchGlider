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
			startTime = Time.time;
			time = 0;
			count = ((Gate.Passer[])GetComponentsInChildren<Gate.Passer> ()).Length;
			missing = count;
			done = 0;
		}
		
		// Update is called once per frame
		void Update () {
			if (missing == 0) {
				Time.timeScale = 0.1f;
			} else {
				missing = ((Gate.Passer[])GetComponentsInChildren<Gate.Passer> ()).Length;
				done = count - missing;
				time = Time.time - startTime;
			}

		}
	}
}
