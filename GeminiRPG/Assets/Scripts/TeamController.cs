using UnityEngine;
using System.Collections;

public class TeamController : MonoBehaviour {

	GameObject mainHero;

	public PlayerInfo Player;
	public PlayerInfo healer;
	public PlayerInfo rangedmg;
	public PlayerInfo meleedmg;

	// Use this for initialization
	void Start () {
		Player = (PlayerInfo)GameObject.Find ("Player").GetComponent("PlayerInfo");

		healer = new PlayerInfo();
		rangedmg = new PlayerInfo();
		meleedmg = new PlayerInfo();

	
		//PLAYER START STATS
		Player.ID = 1;
		Player.active = false;
		Player.level = 0;
		Player.experience = 0;
		
		Player.HPMAX = 0;
		Player.APMAX = 0;
		Player.currentHP = 0;
		Player.currentAP = 0;
		
		Player.Strength = 0; // Physical Damage
		Player.Intellect = 0; // Magic Damage
		Player.Armor = 0; //Reduce Damage
		Player.Speed = 0;// Attack order
		
		Player.HPGrowth = 0;
		Player.APGrowth = 0;
		Player.StrengthGrowth = 0; 
		Player.IntellectGrowth = 0; 
		Player.ArmorGrowth = 0;
		Player.SpeedGrowth = 0;


		//HEALER CHARACTER START STATS
		healer.ID = 2;
		healer.active = false;
		healer.level = 0;
		healer.experience = 0;
		
		healer.HPMAX = 0;
		healer.APMAX = 0;
		healer.currentHP = 0;
		healer.currentAP = 0;
		
		healer.Strength = 0; // Physical Damage
		healer.Intellect = 0; // Magic Damage
		healer.Armor = 0; //Reduce Damage
		healer.Speed = 0;// Attack order
		
		healer.HPGrowth = 0;
		healer.APGrowth = 0;
		healer.StrengthGrowth = 0; 
		healer.IntellectGrowth = 0; 
		healer.ArmorGrowth = 0;
		healer.SpeedGrowth = 0;

		//RANGE CHARACTER START STATS
		rangedmg.ID = 3;
		rangedmg.active = false;
		rangedmg.level = 0;
		rangedmg.experience = 0;
		
		rangedmg.HPMAX = 0;
		rangedmg.APMAX = 0;
		rangedmg.currentHP = 0;
		rangedmg.currentAP = 0;
		
		rangedmg.Strength = 0; // Physical Damage
		rangedmg.Intellect = 0; // Magic Damage
		rangedmg.Armor = 0; //Reduce Damage
		rangedmg.Speed = 0;// Attack order
		
		rangedmg.HPGrowth = 0;
		rangedmg.APGrowth = 0;
		rangedmg.StrengthGrowth = 0; 
		rangedmg.IntellectGrowth = 0; 
		rangedmg.ArmorGrowth = 0;
		rangedmg.SpeedGrowth = 0;

		//MELEE CHARACTER START STATS
		meleedmg.ID = 4;
		meleedmg.active = false;
		meleedmg.level = 0;
		meleedmg.experience = 0;
		
		meleedmg.HPMAX = 0;
		meleedmg.APMAX = 0;
		meleedmg.currentHP = 0;
		meleedmg.currentAP = 0;
		
		meleedmg.Strength = 0; // Physical Damage
		meleedmg.Intellect = 0; // Magic Damage
		meleedmg.Armor = 0; //Reduce Damage
		meleedmg.Speed = 0;// Attack order
		
		meleedmg.HPGrowth = 0;
		meleedmg.APGrowth = 0;
		meleedmg.StrengthGrowth = 0; 
		meleedmg.IntellectGrowth = 0; 
		meleedmg.ArmorGrowth = 0;
		meleedmg.SpeedGrowth = 0;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
