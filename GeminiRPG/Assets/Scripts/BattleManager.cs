using UnityEngine;
using System.Collections;

public class BattleManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void StartBattle(GameObject[] Enemies)
	{
		//Load Battle Scene

	}

	void BattleEnd()
	{
		//Unload Battle Scene

	}

	void Awake() {
		DontDestroyOnLoad(transform.gameObject);
	}
}
