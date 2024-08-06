
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;

    public GameObject LevelCompleteUI;

    public PlayerMovement movement;

    public void CompleteLevel()
    {
        movement.enabled = false;
        LevelCompleteUI.SetActive(true);

    }

    public void EndGame(float restartDelay)
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            FindObjectOfType<Score>().stopScore = true;
            Invoke("Restart", restartDelay);           
        }
    }

    void Update()
    {
        if (Input.GetKey("r"))
        {
            Restart();
        }
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
