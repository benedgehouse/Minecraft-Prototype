using UnityEngine;
using System.Collections;

[System.Serializable]
public class Item 
{
	public string name;
	public int id;
	public string desc;
	public Texture2D icon;
	public int power;
	public int speed;
	public ItemType itemType;
		
		public enum ItemType 
		{
		Sword, Shovel, Pickaxe, Block
		}
	
}
