using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayPlayerPref : MonoBehaviour
{
    public string playerPrefKey = "hiCollected"; // The key for the PlayerPrefs

    private Text textComponent; // Reference to the Text component

    void Start()
    {
        // Get the Text component attached to this GameObject
        textComponent = GetComponent<Text>();

        // Check if the PlayerPrefs key exists
        if (PlayerPrefs.HasKey(playerPrefKey))
        {
            if(playerPrefKey.Equals("hiTime"))
            {
                var time=PlayerPrefs.GetFloat(playerPrefKey);
                var seconds = time % 60;
                var minutes = time / 60;

                textComponent.text += minutes.ToString("00") + ":" + seconds.ToString("00");
            }
            else
            {
                textComponent.text += PlayerPrefs.GetInt(playerPrefKey).ToString();
            }
        }
        else
        {
            // If the PlayerPrefs key doesn't exist, display a default message
            textComponent.text += "No data available";
        }
    }
}
