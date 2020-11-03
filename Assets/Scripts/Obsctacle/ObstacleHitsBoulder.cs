using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleHitsBoulder : MonoBehaviour {

	void OnTriggerEnter(Collider target) {
		if (target.tag == "Boulder") {
			gameObject.SetActive(false);
		}
	}

}
