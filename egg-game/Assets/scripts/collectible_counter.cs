using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class collectible_counter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timer;

    public void UpdateText(int collected)
    {
        timer.text = collected.ToString() + "/8";

    }
}
