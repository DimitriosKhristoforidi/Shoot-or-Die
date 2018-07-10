using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

	private string MainScene = "MainScene";
	private string CreditsScene = "CreditsScene";

	public void StartGame() 
	{
		SceneManager.LoadScene(MainScene);
		Time.timeScale = 1f;
	}

	public void LoadCredits()
	{
		SceneManager.LoadScene(CreditsScene);
	}

	public void QuitGame()
	{
		Application.Quit();
	}
}
