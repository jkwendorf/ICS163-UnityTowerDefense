using UnityEngine;
using System.Collections;

public class myGUIScript : MonoBehaviour {

	public GUISkin guiSkin;


	private string current_location;
	private string tower_location;
	private string bomb_location;

	private string world_name;
	private string world_password;
	private	string team_name;
	private string team_password;
	private string code_command;

	private bool isExpanded = false;

	private NetworkHelper network_helper;
	private MyLocation myLocation;

	// Use this for initialization
	void Start () {

		if(guiSkin == null)
		{
			Debug.Log ("Please add a guiSkin");
			this.enabled = false;
			return;
		}

		network_helper = GameObject.Find("myNetworkHelper").GetComponentInChildren<NetworkHelper>();




		current_location = "Current Location: ";
		tower_location = "Tower Location: ";
		bomb_location = "Bomb Location: ";

		world_name = "World Name";
		world_password = "World Password";
		team_name = "Team Name";
		team_password = "Team Password";
		code_command = "Code Command";
	}
	
	// Update is called once per frame
	void Update () {
		//current_location = "Current Location: " + myLocation.getLat() + ", " + myLocation.getLng();

	}

	void OnGUI(){

		GUI.skin = guiSkin;

		if(GUI.Button(new Rect(0, 0, Screen.width/2, 100), "Fetch Status"))
		{
			// Get the status from the Network Helper
			//network_helper.refreshGameState(world_name, world_password, team_name, team_password, );

			// With the received data, update the current state of our game
		}

		isExpanded = GUI.Toggle( new Rect(Screen.width/2, 0, Screen.width/2, 100), isExpanded, "Expand");
		
		if(isExpanded)
		{
			// Draw all the other info

			current_location = GUI.TextField(new Rect(0, 100, Screen.width, 100), current_location);
			tower_location = GUI.TextField(new Rect(0, 200, Screen.width, 100), tower_location);
			bomb_location = GUI.TextField(new Rect(0, 300, Screen.width, 100), bomb_location);

			world_name = GUI.TextField(new Rect(0, 400, Screen.width/2, 100), world_name);
			world_password = GUI.TextField(new Rect(0, 500, Screen.width/2, 100), world_password);
			team_name = GUI.TextField(new Rect(0, 600, Screen.width/2, 100), team_name);
			team_password = GUI.TextField(new Rect(0, 700, Screen.width/2, 100), team_password);
			code_command = GUI.TextField(new Rect(0, 800, Screen.width/2, 100), code_command);

			if(GUI.Button(new Rect(Screen.width/2, 400, Screen.width/2, 100), "Place Tower"))
			{
				// Place a tower on the map
				//network_helper.buildTowerPoint(lat, long, alt);

				// Set the name of the tower location
				//tower_location = "Tower Location: (" + lat + "," + long + "," + alt + ")";
			}

			if(GUI.Button(new Rect(Screen.width/2, 500, Screen.width/2, 100), "Upload Tower"))
			{
				// Upload our input to the server and save the dictionary
				//network_helper.uploadTowerPoint(world_name, world_password, team_name, team_password);
			}

			if(GUI.Button(new Rect(Screen.width/2, 600, Screen.width/2, 100), "Place Bomb"))
			{
				// Place a bomb on the map at our coordinate
				//network_helper.dropBombPoint(lat, long, alt);
				
				// Set the name of the bomb location
				//tower_location = "Tower Location: (" + lat + "," + long + "," + alt + ")";
			}

			if(GUI.Button(new Rect(Screen.width/2, 700, Screen.width/2, 100), "Upload Bomb"))
			{
				// Upload our input to the server and save the dictionary
				//network_helper.uploadBombPoint (world_name, world_password, team_name, team_password);
			}

			if(GUI.Button(new Rect(Screen.width/2, 800, Screen.width/2, 100), "Store Code"))
			{
				// Save the code that the user entered

				if(!code_command.Equals ("Code Command"))
				{
					//network_helper.enterCode(code_command);

					code_command = "Code Command";
				}
			}

			if(GUI.Button(new Rect(Screen.width/2, 900, Screen.width/2, 100), "Upload Code"))
			{
				// Upload our code and save the dictionary
				//network_helper.uploadCode (world_name, world_password, team_name, team_password);
			}
		}
	}
}
