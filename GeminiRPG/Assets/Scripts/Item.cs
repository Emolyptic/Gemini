using UnityEngine;
using System.Collections;

public class Item {
	public int ID;
	public string name;
	public string catagory;
	public string description;
	// Use this for initialization
	void Start () {
	
	}

	public Item(int Id, string Name, string Catagory, string Description)
	{
		ID = Id;
		name = Name;
		catagory = Catagory;
		description = Description;
	}

	// Update is called once per frame
	void Update () {
	
	}
}
