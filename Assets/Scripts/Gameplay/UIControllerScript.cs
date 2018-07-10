using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIControllerScript : MonoBehaviour {

	public Button pauseButton;
	public Button shootButton;
	public GameObject pauseMenu;
	public GameObject gameOverMenu;
	public GameObject winMenu;

	private string MainMenuScene = "MainMenuScene";

	void Start () {
		pauseMenu.SetActive(false);
		gameOverMenu.SetActive(false);
		winMenu.SetActive(false);
	}

	public void PauseGame()
	{
		Time.timeScale = 0f;
		pauseMenu.SetActive(true);
		shootButton.interactable = false;
	}

	public void ResumeGame()
	{
		Time.timeScale = 1f;
		pauseMenu.SetActive(false);
		shootButton.interactable = true;
	}

	public void QuitGame() 
	{
		Time.timeScale = 0f;
		SceneManager.LoadScene(MainMenuScene);
	}

	public void Win() 
	{
		Time.timeScale = 0f;
		winMenu.SetActive(true);
		shootButton.interactable = false;
		pauseButton.interactable = false;
	}

	public void GameOver()
	{
		Time.timeScale = 0f;
		gameOverMenu.SetActive(true);
		shootButton.interactable = false;
		pauseButton.interactable = false;
	}
}
