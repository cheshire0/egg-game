using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeCounter : MonoBehaviour
{
    private static TimeCounter instance;
    [SerializeField] private TextMeshProUGUI timer;
    [SerializeField] private GameObject player;

    private float seconds, minutes;
    private float time;
    public bool stopped = false;

    void Start()
    {
        time += Time.timeSinceLevelLoad;
    }


    private void Update()
    {
        if (!stopped)
        {
            CountTime();
        }
        else
        {
            if (PlayerPrefs.HasKey("hiTime"))
            {
                if (time < PlayerPrefs.GetFloat("hiTime"))
                {
                    PlayerPrefs.SetFloat("hiTime", time);
                    PlayerPrefs.Save();
                }
            }
            else
            {
                PlayerPrefs.SetFloat("hiTime", time);
                PlayerPrefs.Save();
            }
        }
    }



    private void CountTime()
    {
        time += Time.deltaTime;
        seconds = time % 60;
        minutes = time / 60;

        timer.text = minutes.ToString("00") + ":" + seconds.ToString("00");

    }
}