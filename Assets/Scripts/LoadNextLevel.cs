using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevel : MonoBehaviour
{
    public void LoadNextLevelFunction()
    {
        Debug.Log("Loading Next Level");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
