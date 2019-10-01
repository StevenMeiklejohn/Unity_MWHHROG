using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Application.targetFrameRate = 60;
	}

	public void GoToGame(){
		SceneManager.LoadScene("Game");
	}
}
