using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HitManager : MonoBehaviour
{
    public TMP_Text txttmp;

    private int totalHits = 0;

    public void IncreaseHitCount()
    {
        totalHits++;
        UpdateHitText();
    }

    private void UpdateHitText()
    {
        txttmp.text = "Total Hits: " + totalHits.ToString();
    }
}
