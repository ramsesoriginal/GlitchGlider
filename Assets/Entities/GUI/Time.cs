using UnityEngine;
using System.Collections;

namespace IngameGUI {
	public class Time : MonoBehaviour {

		public Course.CourseCounter course;

		private TextMesh text;

		// Use this for initialization
		void Start () {
			text = (TextMesh) GetComponent<TextMesh> ();
		}
		
		// Update is called once per frame
		void Update () {
			text.text = course.time.ToString ("F3");
		}
}
}