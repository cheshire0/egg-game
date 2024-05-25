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

    void Start()
    {
        time += Time.timeSinceLevelLoad;
    }


    private void Update()
    {
        CountTime();
    }



    private void CountTime()
    {
        time += Time.deltaTime;
        seconds = time % 60;
        minutes = time / 60;

        timer.text = minutes.ToString("00") + ":" + seconds.ToString("00");

    }
}