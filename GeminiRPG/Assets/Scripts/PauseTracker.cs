using UnityEngine;
using System.Collections;

public class PauseTracker : MonoBehaviour {

	public Material normal;
	public Material selected;
	GameObject pauseMenu;
	GameObject[] menuItems;
	PlayerMovement playerMovementScript;

	int currentselected;
	bool active;

	// Use this for initialization
	void Start () {
		pauseMenu = GameObject.Find("PauseMenu");
		menuItems = new GameObject[5]{GameObject.Find("Resume"),GameObject.Find("Inventory"),GameObject.Find("Party"),GameObject.Find("Options"),GameObject.Find("Quit")};
		playerMovementScript = GameObject.Find("Player").GetComponent<PlayerMovement>();
		active = false;
		currentselected = 0;
		pauseMenu.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.P))
		{
			currentselected = 0;//selector starts on Resume
			playerMovementScript.StopKeyPressesonMainScreen = true; //Stop movement on game
			pauseMenu.SetActive(true); //Show pause screen
			active = true; //Activate Movement on pause screen
			menuItems[currentselected].renderer.material = selected; //highlight selected item
		}
		if(active == true)
		{
			if(Input.GetKeyDown(KeyCode.W))
			{
				menuItems[currentselected].renderer.material = normal;
				if(currentselected == 0) currentselected = 4;
				else{currentselected--;}
				menuItems[currentselected].renderer.material = selected;
			}
			if(Input.GetKeyDown(KeyCode.S))
			{
				menuItems[currentselected].renderer.material = normal;
				if(currentselected == 4) currentselected = 0;
				else{currentselected++;}
				menuItems[currentselected].renderer.material = selected;
			}
			if(Input.GetKeyDown(KeyCode.Return))
			{
				switch (currentselected)
				{
				case 0:
					break;
				case 1:
					break;
				case 2:
					break;
				case 3: 
					break;
				case 4: 
					pauseMenu.SetActive(false);
					active = false;
					playerMovementScript.StopKeyPressesonMainScreen = false;
					menuItems[currentselected].renderer.material = normal;
					break;
				}
			}
		}
	
	}
}
