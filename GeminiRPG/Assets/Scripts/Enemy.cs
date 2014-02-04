using UnityEngine;
using System.Collections;

public class Enemy {
	public int ID;
	public string name;
	public string[] area;
	public int HP;
	public int AP;
	public int strength; // Physical Damage
	public int intellect; // Magic Damage
	public int armor; //Reduce Damage
	public int speed;// Attack order

	public Enemy(int Id, string Name, string[] Area, int Health, int Action, int Strength, int Intellect, int Armor, int Speed)
	{
		ID = Id;
		name = Name;
		area = Area;
		HP = Health;
		AP = Action;
		strength = Strength;
		intellect = Intellect;
		armor = Armor;
		speed = Speed;
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
