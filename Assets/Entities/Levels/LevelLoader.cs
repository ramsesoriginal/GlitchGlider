using UnityEngine;
using System.Collections;

namespace Course {
	public class LevelLoader : MonoBehaviour {

		public GameObject[] levels;
		private CourseCounter counter;

		public int currentLevel;
		public GameObject currentLevelInstantited;

		// Use this for initialization
		void Start () {
			currentLevel = 0;
			counter = (CourseCounter) GetComponent<CourseCounter>();
		}
		
		// Update is called once per frame
		void Update () {
			if (counter.count == 0) {
				if (Input.GetAxis("Horizontal")>0.1)
				{
					currentLevel = (currentLevel + 1 ) % levels.Length;
				}
				if (Input.GetButtonDown("Fire1"))
				{
					loadLevel();
				}
			}
			if (GameObject.FindWithTag ("PlayerDead") != null) {
				if (Input.GetAxis("Horizontal")>0.1)
				{
					currentLevel = (currentLevel + 1 ) % levels.Length;
				}
				if (Input.GetButtonDown("Fire1"))
				{
					Destroy (GameObject.FindWithTag("Player"));
					foreach (Transform  child in transform)
					{
						Destroy (child.gameObject);
					}
					loadLevel();
				}
			}
			if (counter.count != 0 && counter.missing == 0) {
				if (Input.GetButtonDown("Fire1"))
				{
					currentLevel = (currentLevel + 1 ) % levels.Length;
					Destroy (GameObject.FindWithTag("Player"));
					foreach (Transform  child in transform)
					{
						Destroy (child.gameObject);
					}
					loadLevel();
				}
			}
		}

		public void loadLevel() {
			currentLevelInstantited = (GameObject) Instantiate (levels [currentLevel], transform.position, transform.rotation);
			currentLevelInstantited.transform.parent = transform;
			counter.InitilizeCounter ();
			var glitch = (GlitchEffect)GameObject.FindWithTag("MainCamera").GetComponent<GlitchEffect>();
			glitch.intensity = 0.3f;
		}
	}
}
