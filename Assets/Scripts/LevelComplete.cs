using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{ 
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // buildindex je index u padajucem izborniku 'build' u kojem se nalaze nasi leveli
    }
}
