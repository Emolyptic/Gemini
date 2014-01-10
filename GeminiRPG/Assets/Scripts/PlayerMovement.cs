using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed = .1f;

	//Key down booleans
	NPCScript dialogscript;
	bool up = false;
	bool down = false;
	bool left = false;
	bool right = false;

	//Checking for interactable objects
	RaycastHit2D hit;

	//Which way the character is facing
	//     1
	//    2 3
	//     4
	int forward=0;


	//Dialog Machine
	public GUIText dialog;
	public bool dialogSequence;
	GUIContent dialogContent;
	public GUIStyle guistyle;
	int dialogMarker;

	//Stop Movement Bool
	public bool StopKeyPressesonMainScreen;

	// Use this for initialization
	void Start () {
		hit    = new RaycastHit2D();
		dialogSequence = false;
		dialogMarker = -1;
	}
	
	// Update is called once per frame
	void Update () {

		//Toggle movement if Other events aren't happening. DialogSequence tells if there is dialog happening
		if(dialogSequence == false && StopKeyPressesonMainScreen == false)
		{
			//Turn on bool when key is down and off when up
			//Check which way the character is facing
			if(Input.GetKeyDown(KeyCode.W))
			{
				if( !down || !left || !right) forward = 1;
				up = true;
			}
		
			if(Input.GetKeyUp (KeyCode.W)) up = false;

			if(Input.GetKeyDown(KeyCode.A))
			{
				if( !down || !up || !right) forward = 2;
				left = true;
			}

			if(Input.GetKeyUp (KeyCode.A))	left = false;

			if(Input.GetKeyDown(KeyCode.S))
			{
				if( !left || !up || !right) forward = 4;
				down = true;
			}
			
			if(Input.GetKeyUp (KeyCode.S))	down = false;

			if(Input.GetKeyDown(KeyCode.D))
			{
				if( !left || !up || !down) forward = 3;
				right = true;
			}
			
			if(Input.GetKeyUp (KeyCode.D))	right = false;
		}

	
		//Check to move character
		//UP
		if(!Physics2D.Raycast(new Vector2(transform.position.x      ,transform.position.y   ),new Vector2(0,1),.55f) &&
		   !Physics2D.Raycast(new Vector2(transform.position.x + .4f,transform.position.y   ),new Vector2(0,1),.55f) &&
		   !Physics2D.Raycast(new Vector2(transform.position.x - .4f,transform.position.y   ),new Vector2(0,1),.55f) &&
		    up)
		{
			transform.position += new Vector3(0, .1f ,0);
		}

		 
		//LEFT
		if(!Physics2D.Raycast(new Vector2(transform.position.x      ,transform.position.y      ),new Vector2(-1,0),.55f) && 
		   !Physics2D.Raycast(new Vector2(transform.position.x      ,transform.position.y + .4f),new Vector2(-1,0),.55f) &&
		   !Physics2D.Raycast(new Vector2(transform.position.x      ,transform.position.y - .4f),new Vector2(-1,0),.55f) &&
		   left)
		{
			transform.position += new Vector3(-.1f, 0 ,0);
		}


		//DOWN
		if(!Physics2D.Raycast(new Vector2(transform.position.x      ,transform.position.y     ),new Vector3(0,-1),.55f) &&
		   !Physics2D.Raycast(new Vector2(transform.position.x + .4f,transform.position.y     ),new Vector3(0,-1),.55f) &&
		   !Physics2D.Raycast(new Vector2(transform.position.x - .4f,transform.position.y     ),new Vector3(0,-1),.55f) &&
		   down)
		{
			transform.position += new Vector3(0, -.1f ,0);
		}

		//RIGHT
		if(!Physics2D.Raycast(new Vector2(transform.position.x      ,transform.position.y      ),new Vector3(1,0),.55f) &&
		   !Physics2D.Raycast(new Vector2(transform.position.x      ,transform.position.y + .4f),new Vector3(1,0),.55f) &&
		   !Physics2D.Raycast(new Vector2(transform.position.x      ,transform.position.y - .4f),new Vector3(1,0),.55f) &&
		   right)
		{
			transform.position += new Vector3(.1f, 0 ,0);
		}

		//Check for hit in front of where the player if facing
		if(forward == 1)	hit = Physics2D.Raycast(new Vector2(transform.position.x ,transform.position.y ),new Vector2(0,1) ,.55f); //up
		if(forward == 2)	hit = Physics2D.Raycast(new Vector2(transform.position.x ,transform.position.y ),new Vector2(-1,0),.55f); //left
		if(forward == 3)	hit	= Physics2D.Raycast(new Vector2(transform.position.x ,transform.position.y ),new Vector3(1,0) ,.55f); // right
		if(forward == 4)	hit = Physics2D.Raycast(new Vector2(transform.position.x ,transform.position.y ),new Vector3(0,-1),.55f); // down

		//if(hit != null) Debug.Log (hit.collider.name);
		if(hit.collider != null)
		{
			if(hit.collider.name == "NPC" && Input.GetKeyDown(KeyCode.Space))
			{
				dialogSequence = true;
				dialogMarker++;

				//Get script on NPC
				dialogscript = (NPCScript)hit.collider.GetComponent("NPCScript");
				//Add Talking Sequence

				if(dialogMarker < dialogscript.dialog.Length)
				{
					Debug.Log(dialogscript.dialog[dialogMarker]);
					dialogContent = new GUIContent(dialogscript.dialog[dialogMarker]);
				}
				else
				{
					dialogSequence = false;
					dialogMarker = -1;
					up = false;
					down = false;
					left = false;
					right = false;
				}
			}

			if(hit.collider.name == "Door" && Input.GetKeyDown(KeyCode.Space)) 
			{
				Debug.Log("DETECTED DOOR"); //Add Transfer to new scene
			}
		}
		
	}

	void OnGUI(){
		if(dialogSequence)
		{
			GUI.Box (new Rect (25,Screen.height - 100,Screen.width - 50, 100 ), dialogContent,guistyle);
		}
	}

}
