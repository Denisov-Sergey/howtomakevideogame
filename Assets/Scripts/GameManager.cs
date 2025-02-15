using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public GameObject completeLevelUI;
    
    /**
     * Столкновение или выпадение
     */
    public void EndGame()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("RestartGame", 2f);
        }
    }

    /**
     * Выигрыш игры
     */
    public void CompleteGame()
    {
        Debug.Log("Game Complete");
        completeLevelUI.SetActive(true);
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
