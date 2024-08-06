
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public int lastLevelIndex;

    public void LoadNextLevel()
    {
        // if (SceneManager.GetActiveScene().buildIndex == lastLevelIndex)
        // {
            // SceneManager.LoadScene(0);
            // return;
        // }

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
