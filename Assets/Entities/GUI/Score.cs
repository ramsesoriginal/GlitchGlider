using UnityEngine;
using System.Collections;

namespace IngameGUI {
	public class Score : MonoBehaviour {
		
		public Course.CourseCounter course;
		
		private TextMesh text;
		
		// Use this for initialization
		void Start () {
			if (course == null) {
				course = (Course.CourseCounter)GameObject.FindWithTag("course").GetComponent<Course.CourseCounter>();
			}
			text = (TextMesh) GetComponent<TextMesh> ();
		}

		
		// Update is called once per frame
		void Update () {
			text.text = course.done.ToString() + "/" + course.count.ToString();
		}
	}
}
