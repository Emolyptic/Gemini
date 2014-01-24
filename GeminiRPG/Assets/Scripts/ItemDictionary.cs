using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemDictionary : MonoBehaviour {

	List<Item> items;

	// Use this for initialization
	void Start () {
		items  = new List<Item>();
		FillDictionary();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void InitializeItemDictionary()
	{
	}

	void FillDictionary()
	{
		items.Add(new Item(0	,"Medical"		, "Energy Drink"      	 	, "Heals 20 HP"));
		items.Add(new Item(1	,"Head"   		, "Baseball Cap"    		, "+2 Def"));
		items.Add(new Item(2	,"Chest"  		, "T-Shirt"    				, "+3 Def"));
		items.Add(new Item(3	,"Legs"   		, "Jeans"    				, "+2 Def"));
		items.Add(new Item(4	,"Hands"  		, "Leather Gloves"  		, "+2 Def"));
		items.Add(new Item(5	,"Medical"	 	, "Aspirin"    				, "Restore 10 AP"));
	}
	Item GetItem(int ID)
	{
		return items.Find(x => x.ID == ID);
	}
}
