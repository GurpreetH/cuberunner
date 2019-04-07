using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameended = false;

    public float restartDelay = 1f;

    public GameObject completegameUI;

    public void CompleteLevel()
    {
        completegameUI.SetActive(true);
    }
    public void EndGame()
    {
        if (gameended == false)
        {
            gameended = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
