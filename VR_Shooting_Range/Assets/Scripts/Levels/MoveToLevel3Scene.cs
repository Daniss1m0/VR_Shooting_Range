using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToLevel3Scene : MonoBehaviour
{
    public void MoveToScene()
    {
        SceneManager.LoadScene("Level3");
    }
}
