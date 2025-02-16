using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void StartGame()
    {
        Debug.Log("Start");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
