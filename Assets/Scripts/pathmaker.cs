using UnityEngine;
using System.Collections;

using System.Collections.Generic;
public class pathmaker : MonoBehaviour {
	//int counter=0;
	List<GameObject> floorPrefabIndex=new List<GameObject>();//creates a list for the potential prefabs
	public GameObject floorPrefab1;
	public GameObject floorPrefab2;
	public GameObject floorPrefab3;

	public Transform pathmakerSpherePrefab;
	public static int numberOfTiles;
	public static int numberOfPathMakers=0;

	int capNumber;
	int rotateNumber;
	// Use this for initialization
	void Start () {
		capNumber = Random.Range (500, 750);
		rotateNumber = Random.Range (0, 4) * 90;

		floorPrefabIndex.Add (floorPrefab1);//adds the three prefabs into the list by choosing them in the inspector
		floorPrefabIndex.Add (floorPrefab2);
		floorPrefabIndex.Add (floorPrefab3);

	}
	
	// Update is called once per frame
	void Update () {
		if (numberOfTiles<capNumber) {
			int floorPrefab=UnityEngine.Random.Range(0,3);//script picks a random prefab from the list
					float number = Random.value;
					if (number < .15f) {
				transform.Rotate (0, rotateNumber, 0);
					} else if (number > .25f && number < .5f) {
						transform.Rotate (0, 90f, 0);
			} else if (number > .95f && number<1f&&numberOfPathMakers<5) {
				Instantiate (pathmakerSpherePrefab, transform.position, transform.rotation);
				numberOfPathMakers++;

			}
			Instantiate (floorPrefabIndex[floorPrefab], transform.position, transform.rotation);//the chosen prefab is instantiated randomly
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

