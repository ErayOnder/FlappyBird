using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore = 0;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource scoreSound;
    public AudioSource dieSound;
    
    public void addScore(int score)
    {
        playerScore += score;
        scoreText.text = playerScore.ToString();
        scoreSound.Play();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        Debug.Log("Game Over");
        gameOverScreen.SetActive(true);
        dieSound.Play();
    }

}
