using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public static TimerController instance;

    public Text timeCounter;

    private TimeSpan timePlaying;
    private bool timerGoing;

    private float elapsedTime;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        timeCounter.text = "Time : 0:0";
        timerGoing = false;
    }

    public void BeginTimer()
    {
        timerGoing = true;
        elapsedTime = 0f;

        StartCoroutine(UpdateTimer());
    }
    // Start is called before the first frame update
    public void EndTimer()
    {
        timerGoing = false;
    }

    private IEnumerator UpdateTimer()
    {
        while (timerGoing)
        {
            elapsedTime += Time.deltaTime;      //����ð� ���ϱ� ��Ÿ �ð�
            timePlaying = TimeSpan.FromSeconds(elapsedTime);
            string timePlayingStr = "Time : " + timePlaying.ToString("mm' : 'ss");
            timeCounter.text = timePlayingStr;

            yield return null;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
