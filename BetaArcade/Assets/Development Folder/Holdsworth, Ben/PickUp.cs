﻿using UnityEngine;

public class PickUp : MonoBehaviour {

    public string objectToCollide;

	// Update is called once per frame
	void Update () {
		


	}

    private void OnTriggerEnter(Collider collider) {

        if (collider.CompareTag(objectToCollide)) {

            Destroy(gameObject);

        }

    }

}
