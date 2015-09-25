using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

	public float speed = 0.0f;
	public Vector3 rotationVector = new Vector3 (0,0,0);

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate (rotationVector * speed * Time.deltaTime);
	}
}
