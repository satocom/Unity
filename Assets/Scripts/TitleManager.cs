using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TitleManager : MonoBehaviour {

	void OnGUI() {
		Util.SetFontSize (32);
		Util.SetFontAlignment (TextAnchor.MiddleCenter);

		float w = 128;
		float h = 32;
		float px = Screen.width / 2;
		float py = Screen.height / 2;

		Util.GUILabel (px, py, w, h, "StainBoy Game");
			
		py += 60;
		if (GUI.Button (new Rect (px, py, w, h), "START")) {
			Application.LoadLevel ("Main");
			//SceneManager.LoadScene ("Main", LoadSceneMode.Single);
		}
	}

}
