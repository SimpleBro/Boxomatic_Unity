using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;

    public GameObject completelevelUI;

    public void CompleteLevel()
    {
        completelevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER!");
            Invoke("Restart", restartDelay); // Invoke -- 1. parametar je funkcija koju zelimo pozvati, 2. parametar je vrijeme u sekundama za koje se odgadja pozivanje funkcije!
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
