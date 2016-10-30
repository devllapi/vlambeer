using UnityEngine;
using System.Collections;

public class pathmaker : MonoBehaviour {
	//int counter=0;
	public Transform floorPrefab;
	public Transform pathmakerSpherePrefab;
	public static int numberOfTiles;
	public static int numberOfPathMakers=0;
	int capNumber;
	int rotateNumber;
	// Use this for initialization
	void Start () {
		capNumber = Random.Range (500, 750);
		rotateNumber = Random.Range (0, 4) * 90;
		floorPrefab.GetComponent<Renderer> ().sharedMaterial.color = Random.ColorHSV();
	}
	
	// Update is called once per frame
	void Update () {
		if (numberOfTiles<capNumber) {
					float number = Random.value;
					if (number < .15f) {
				transform.Rotate (0, rotateNumber, 0);
					} else if (number > .25f && number < .5f) {
						transform.Rotate (0, 90f, 0);
			} else if (number > .95f && number<1f&&numberOfPathMakers<5) {
				Instantiate (pathmakerSpherePrefab, transform.position, transform.rotation);
				numberOfPathMakers++;

			}
					Instantiate (floorPrefab, transform.position, transform.rotation);
					transform.Translate(0,0,5f);

			numberOfTiles++;
			Debug.Log (numberOfTiles);
		} else if(numberOfTiles==capNumber) {
			Destroy(gameObject);
		}
		if(Input.GetKeyDown(KeyCode.R)){
			Application.LoadLevel("vlam");
			numberOfTiles = 0;
		}
	}
}

