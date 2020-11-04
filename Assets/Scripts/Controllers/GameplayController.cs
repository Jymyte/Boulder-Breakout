using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameplayController : MonoBehaviour
{
    [SerializeField]
	private GameObject pausePanel;

	[SerializeField]
	private Button restartGameButton;

	[SerializeField]
	private Text scoreText, pauseText;

	private int score;

    void Start () {
		scoreText.text = score + "M";
		StartCoroutine (CountScore());
	}

	IEnumerator CountScore() {
		yield return new WaitForSeconds(0.6f);
		score++;
		scoreText.text = score + "M";
		StartCoroutine (CountScore());
	}

	void OnEnable() {
		PlayerDied.endGame += PlayerDiedEndTheGame;
		CollectiblePickup.pickUp += ItemPickedUpCountScore;
	}

	void OnDisable() {
		PlayerDied.endGame -= PlayerDiedEndTheGame;
		CollectiblePickup.pickUp -= ItemPickedUpCountScore;
	}

	void ItemPickedUpCountScore() {
		score += 10;
	}

	void PlayerDiedEndTheGame() {
		pauseText.text = "Game Over";
		pausePanel.SetActive (true);
		restartGameButton.onClick.RemoveAllListeners ();
		restartGameButton.onClick.AddListener (() => RestartGame());
		Time.timeScale = 0f;
	}	

    public void GoToMenu() {
		Time.timeScale = 1f;
		SceneManager.LoadScene("MainMenu");
	}

	public void ResumeGame() {
		Time.timeScale = 1f;
		pausePanel.SetActive (false);
	}

	public void RestartGame() {
		Time.timeScale = 1f;
		SceneManager.LoadScene("Gameplay");
	}
}
