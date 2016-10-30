using UnityEngine;
using System.Collections;

public class pathmaker : MonoBehaviour {
	//int counter=0;
	public Transform floorPrefab;
	public Transform pathmakerSpherePrefab;
	public static int numberOfTiles;
	public static int numberOfPathMakers=0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (numberOfTiles<1000) {
					float number = Random.value;
					if (number < .15f) {
						transform.Rotate (0, 90f, 0);
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
		} else if(numberOfTiles==1000) {
			Destroy(gameObject);
		}

	}
}

