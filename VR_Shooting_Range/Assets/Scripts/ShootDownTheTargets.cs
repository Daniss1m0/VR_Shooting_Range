using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShootDownTheTargets : MonoBehaviour
{
    public TMP_Text txttmp;
    public int totalTargets = 9;

    private int totalHits = 0;

    public void IncreaseHitCount()
    {
        totalHits++;
        UpdateHitText();
    }

    private void UpdateHitText()
    {
        txttmp.text = $"Shoot down the targets: {totalHits}/{totalTargets}";
    }
}
