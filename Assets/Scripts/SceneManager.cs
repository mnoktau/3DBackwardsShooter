using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour {

	public void Open_Scene(string Scene_Name)
	{
		Application.LoadLevel (Scene_Name);
	}

}
