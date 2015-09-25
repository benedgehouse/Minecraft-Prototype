using UnityEngine;
using System.Collections;

public class WorldGenerator : MonoBehaviour {

	public GameObject[] block;
	public GameObject[,,] world = new GameObject[100,50,100];


	//PURLIN NOISE

	// Use this for initialization
	void Start () {
		
		createPlain (10);
		/*
		 (Random.Range(0,70),Random.Range(0,70));
		createMountain2 (Random.Range(0,70),Random.Range(0,70));
		createMountain2 (Random.Range(0,70),Random.Range(0,70));

		createMountain (Random.Range(0,40),Random.Range(0,40),Random.Range(10,30));
		createMountain (Random.Range(0,40),Random.Range(0,40),Random.Range(10,30));
		createMountain (Random.Range(0,40),Random.Range(30,70),Random.Range(10,30));
		createMountain (Random.Range(0,40),Random.Range(30,70),Random.Range(10,30));
		createMountain (Random.Range(30,70),Random.Range(0,40),Random.Range(10,30));
		createMountain (Random.Range(30,70),Random.Range(0,40),Random.Range(10,30));
		createMountain (Random.Range(30,70),Random.Range(30,70),Random.Range(10,30));
		createMountain (Random.Range(30,70),Random.Range(30,70),Random.Range(10,30));
		*/
		//createRiver (10);
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void createPlain(int size)
	{
		for (int y = 0; y < 10; y++) 
		{
			for (int x = 0; x < size; x++) 
			{
				for (int z = 0; z < size; z++) 
				{
					if(world[x,y,z] == null)
						world[x,y,z] = Instantiate(block[0], new Vector3(x,y,z), Quaternion.Euler(0,0,90)) as GameObject;	//GRASS
				}
			}
		}
	}
	public void createRiver(int size)
	{
		for (int y = 0; y < 2; y++) 
		{
			for (int x = 0; x < size; x++) 
			{
				for (int z = 0; z < size; z++) 
				{
					if(x==0 || x == size-1 || z == 0 || z== size-1)
						if(world[x,y,z] == null)
							world[x,y,z] = Instantiate(block[0], new Vector3(x,y,z), Quaternion.Euler(0,0,90)) as GameObject;	//GRASS

				}
			}
		}
		/*
		for (int y = 0; y < 2; y++) 
		{
			for (int x = 0; x < size; x++) 
			{
				for (int z = 0; z < size; z++) 
				{
					if(x > 3 && x < 7)
						Instantiate(block[1], new Vector3(x,y-.3f,z), new Quaternion(0,0,0,0));	//RIVER
					else
						Instantiate(block[0], new Vector3(x,y,z), new Quaternion(0,0,0,0));	//GRASS
				}
			}
		}
		*/
	}
	public void createMountain(int posx,int posz,int size)
	{
		for (int y = 0; y < size/4; y++) 
		{
			for (int x = posx+y*2; x < posx+size-y*2; x++) 
			{
				for (int z = posz+y*2; z < posz+size-y*2; z++) 
				{
					if(world[x,y,z] == null)
						world[x,y,z] = Instantiate(block[0], new Vector3(x,y,z), Quaternion.Euler(0,0,90)) as GameObject;	//GRASS
				}
			}
		}
	}
	public void createMountain2(int posx,int posz)
	{
		Instantiate(block[1], new Vector3(posx,2,posz), Quaternion.Euler(0,0,0));	//GRASS
	}
}