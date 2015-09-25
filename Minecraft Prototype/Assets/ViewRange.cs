using UnityEngine;
using System.Collections;

public class ViewRange : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		print ("hi");
		other.gameObject.SetActive(true);
	}

	void OnTriggerExit(Collider other) {
		other.gameObject.SetActive(false);
		print ("bye");
	}
}
