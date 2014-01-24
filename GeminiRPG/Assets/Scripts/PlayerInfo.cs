using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerInfo : MonoBehaviour {

	public string name;

	public int ID;
	public bool active;

	public int level;
	public int experience;

	public int HPMAX;
	public int APMAX;
	public int currentHP;
	public int currentAP;

	public int Strength; // Physical Damage
	public int Intellect; // Magic Damage
	public int Armor; //Reduce Damage
	public int Speed;// Attack order

	public int HPGrowth;
	public int APGrowth;
	public int StrengthGrowth; 
	public int IntellectGrowth; 
	public int ArmorGrowth;
	public int SpeedGrowth;

	public int Quest;

	public List<int> MedItems;
	public List<int> Equipment;

	ItemDictionary itemDictionary;

	// Use this for initialization
	void Start () {
		itemDictionary = (ItemDictionary)GameObject.Find("MasterController").GetComponent("ItemDictionary");
		MedItems = new List<int>();
		Equipment = new List<int>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
