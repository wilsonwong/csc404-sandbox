using UnityEngine;
using System.Collections;

public class Controls_UI : MonoBehaviour {
	string movement_button = "movement: ";
	string action_button = "action: ";
	string other_buttons = "others: ";
	string camera_axis = "camera: ";
	string shoulder_buttons = "shoulders: ";
	void OnGUI()
	{
		GUILayout.Label("PS3 Controller:");
		GUILayout.Label(movement_button);
		GUILayout.Label(camera_axis);
		GUILayout.Label(action_button);
		GUILayout.Label(other_buttons);
		GUILayout.Label(shoulder_buttons);
	}

	void Update(){
		movement_button = "movement: ";
		action_button = "action: ";
		camera_axis = "camera: ";
		other_buttons = "others: ";
		shoulder_buttons = "shoulders: ";

		if(Input.GetButton("Triangle")){
			action_button += " Triangle ";
		}
		if(Input.GetButton("Circle")){
			action_button += " Circle ";
		}
		if(Input.GetButton("Cross")){
			action_button += " Cross ";
		}
		if(Input.GetButton("Square")){
			action_button += " Square ";
		}
		if(Input.GetButton("L1")){
			shoulder_buttons += " L1 ";
		}
		if(Input.GetButton("L2")){
			shoulder_buttons += " L2 ";
		}
		if(Input.GetButton("R1")){
			shoulder_buttons += " R1 ";
		}
		if(Input.GetButton("R2")){
			shoulder_buttons += " R2 ";
		}
		if(Input.GetButton("Start")){
			other_buttons += " Start ";
		}
		if(Input.GetButton("Select")){
			other_buttons += " Select ";
		}
		movement_button += Input.GetAxis("Horizontal") + " ";
		movement_button += Input.GetAxis("Vertical");
		camera_axis += Input.GetAxis("CamH") + " ";
		camera_axis += Input.GetAxis("CamV") + " ";
	}
}
