using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenScript : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene("GameScreen");
    }
    

}
