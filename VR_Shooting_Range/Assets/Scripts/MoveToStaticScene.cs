using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToStaticScene : MonoBehaviour
{
    public void MoveToScene()
    {
        SceneManager.LoadScene("StaticTargetsScene (Main)");
    }
}
