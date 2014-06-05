using UnityEngine;
using System.Collections;

public class myGUIScript : MonoBehaviour {

	public GUISkin guiSkin;

	private string world_name;
	private string world_password;
	private	string team_name;
	private string team_password;
	private string code_command;

	private NetworkHelper network_helper;

	// Use this for initialization
	void Start () {

		if(guiSkin == null)
		{
			Debug.Log ("Please add a guiSkin");
			this.enabled = false;
			return;
		}

		network_helper = GameObject.Find("myNetworkHelper").GetComponentInChildren<NetworkHelper>();

		world_name = "World Name";
		world_password = "World Password";
		team_name = "Team Name";
		team_password = "Team Password";
		code_command = "Code Command";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){

		GUI.skin = guiSkin;

		world_name = GUI.TextField(new Rect(0, 0, Screen.width, 100), world_name);
		world_password = GUI.TextField(new Rect(0, 100, Screen.width, 100), world_password);
		team_name = GUI.TextField(new Rect(0, 200, Screen.width, 100), team_name);
		team_password = GUI.TextField(new Rect(0, 300, Screen.width, 100), team_password);
		code_command = GUI.TextField(new Rect(0, 400, Screen.width, 100), code_command);

		if(GUI.Button(new Rect(0, 500, Screen.width, 100), "Place Tower"))
		{
			// Place a tower on the map
		}

		if(GUI.Button(new Rect(0, 600, Screen.width, 100), "Place Bomb"))
		{
			// Place a bomb on the map at our coordinate
		}

		if(GUI.Button(new Rect(0, Screen.height - 100, Screen.width, 100), "Upload"))
		{
			// Upload our input to the server
		}
	}
}
