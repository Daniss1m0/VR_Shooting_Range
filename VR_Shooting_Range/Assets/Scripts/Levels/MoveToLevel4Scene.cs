using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToLevel4Scene : MonoBehaviour
{
    public void MoveToScene()
    {
        SceneManager.LoadScene("Level4");
    }
}
