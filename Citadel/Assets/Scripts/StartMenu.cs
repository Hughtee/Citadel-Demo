using UnityEngine;
using System.Collections;

public class StartMenu : MonoBehaviour {

	public Texture2D background;
	int theHeight = 50;
	int theWidth = 200;
	
	void OnGUI() {
		if ( GUI.Button(new Rect(Screen.width / 2 - (theWidth / 2), Screen.height - 50, theWidth, theHeight), background)) {
			Application.LoadLevel ("Scene01");
		}
	}    

}
