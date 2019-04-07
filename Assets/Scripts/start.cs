using UnityEngine.SceneManagement;
using UnityEngine;

public class start : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
