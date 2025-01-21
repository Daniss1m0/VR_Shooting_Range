using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartManager : MonoBehaviour
{
    public void RestartScene()
    {
        //SceneManager.LoadScene("MainScene");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
