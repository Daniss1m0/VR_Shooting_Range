using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToLevel5Scene : MonoBehaviour
{
    public void MoveToScene()
    {
        SceneManager.LoadScene("Level5");
    }
}
