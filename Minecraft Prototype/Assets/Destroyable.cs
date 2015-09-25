using UnityEngine;
using System.Collections;

public class Destroyable : MonoBehaviour {
	
	public int maxHP;
	public int currHP;
	public Texture[] textures;
	public float timeLastHit = 5;
	public GameObject explosion;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) 
		{
			onHit(1);
		}
		if (Input.GetKeyUp (KeyCode.Space)) 
		{
			currHP = maxHP;
		}

		/*
		if (currHP != maxHP && timeLastHit > 5) 
		{
			currHP = maxHP;
		}
		if (timeLastHit < 5) 
		{
			timeLastHit += Time.deltaTime;
		}
		*/
	}

	public void onHit(int damage)
	{
		currHP -= damage;
		timeLastHit = 0;



		if (currHP <= 0) 
		{
			die ();
		}
	}

	public void die()
	{
		Instantiate (explosion, transform.position, Quaternion.Euler(0,0,90));
		Destroy (gameObject);
	}
}
