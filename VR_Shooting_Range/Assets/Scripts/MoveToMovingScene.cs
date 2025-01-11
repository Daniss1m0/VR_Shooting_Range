using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToMovingScene : MonoBehaviour
{
    public void MoveToScene()
    {
        SceneManager.LoadScene("MovingTargetsScene");
    }
}
