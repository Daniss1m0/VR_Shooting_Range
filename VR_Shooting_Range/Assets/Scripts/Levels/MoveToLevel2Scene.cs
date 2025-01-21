using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToLevel2Scene : MonoBehaviour
{
    public void MoveToScene()
    {
        SceneManager.LoadScene("Level2 (Main)");
    }
}
