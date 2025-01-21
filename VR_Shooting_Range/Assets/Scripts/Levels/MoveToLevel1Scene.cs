using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToLevel1Scene : MonoBehaviour
{
    public void MoveToScene()
    {
        SceneManager.LoadScene("Level1");
    }
}
