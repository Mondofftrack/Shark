using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");  // Имя твоей игровой сцены
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
