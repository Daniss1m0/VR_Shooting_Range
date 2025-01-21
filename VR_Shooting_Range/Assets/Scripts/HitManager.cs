using UnityEngine;
using TMPro;

public class HitManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI hitsText;

    private void Start()
    {
        if (hitsText == null)
        {
            hitsText = FindObjectOfType<TextMeshProUGUI>();
        }
    }

    private void Update()
    {
        if (hitsText != null)
        {
            hitsText.text = $"Total Hits in targets: {HitCounter.TotalHits}";
        }
    }
}
