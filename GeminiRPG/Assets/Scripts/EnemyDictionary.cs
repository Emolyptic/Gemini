using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyDictionary : MonoBehaviour {

	List<Enemy> enemy;
	// Use this for initialization
	void Start () {
		enemy  = new List<Enemy>();
		FillDictionary();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void FillDictionary()
	{
		enemy.Add(new Enemy(0	,"Goo"			,new string[]{"Starting", "Area1"}			,10		,2	,1	,1	,1	,1));
	}
	Enemy GetEnemy(string NAME)
	{
		return enemy.Find(x => x.name == NAME);
	}
}
