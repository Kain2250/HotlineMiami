using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game.Level.00");
    }

    public void ExitGame()
    {
        Debug.Log("Game is exit");
        Application.Quit();
    }
}
