using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart_button : MonoBehaviour
{
    public void RestartGame()
    {
        GameController.gameover = false;
        SceneManager.LoadScene(0);
    }
}
