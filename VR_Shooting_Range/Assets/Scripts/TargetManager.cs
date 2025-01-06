using UnityEngine;

public class TargetManager : MonoBehaviour
{
    public GameObject[] targets;
    private Vector3[] initialPositions;

    private void Start()
    {
        initialPositions = new Vector3[targets.Length];
        for (int i = 0; i < targets.Length; i++)
        {
            initialPositions[i] = targets[i].transform.position;
        }
    }

    public void RestartTargets()
    {
        for (int i = 0; i < targets.Length; i++)
        {
            targets[i].SetActive(true);
            targets[i].transform.position = initialPositions[i];
        }
    }
}
