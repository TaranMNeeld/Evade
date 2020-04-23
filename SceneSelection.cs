using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class SceneSelection : MonoBehaviour {

	[HideInInspector]
	public string str;
	public void selectScene() {
		str = EventSystem.current.currentSelectedGameObject.name;
		SceneManager.LoadScene (str);
	}

	public void goToMainMenu() {
		SceneManager.LoadScene ("MainMenu");
	}
	public void goToOnlinePlayArea()
	{
		SceneManager.LoadScene("Highscores");
	}
}
