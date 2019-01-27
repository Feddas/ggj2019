using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public int SecondsToBeatLevel = 60;
    public Text textTimer;
    public Image NightFade;

    public float startTime;

    void Start()
    {
        startTime = Time.time;
        setFadeAlpha(0);

        StartCoroutine(Tick());

        if (HomeThings.MyThings != null)
        {
            if (HomeThings.MyThings.Any(mt => mt.WhatItIs == WhatItIs.EndOfTheDay))
            {
                SecondsToBeatLevel -= 20;
            }
            if (HomeThings.MyThings.Any(mt => mt.WhatItIs == WhatItIs.Eating))
            {
                SecondsToBeatLevel -= 5;
            }
            if (HomeThings.MyThings.Any(mt => mt.WhatItIs == WhatItIs.Memories))
            {
                SecondsToBeatLevel += 10;
            }
        }

        System.TimeSpan timeRemaining = new System.TimeSpan(0, 0, SecondsToBeatLevel);
        textTimer.text = timeRemaining.ToString();
    }

    void Update()
    {

    }

    public IEnumerator Tick()
    {
        while (true)
        {
            int timePlaying = (int)(Time.time - startTime);
            System.TimeSpan timeRemaining = new System.TimeSpan(0, 0, SecondsToBeatLevel - timePlaying);
            textTimer.text = timeRemaining.ToString();
            yield return new WaitForSeconds(1);
            if (timeRemaining.TotalSeconds <= 1)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            else if (HomeThings.MyThings != null && HomeThings.MyThings.Any(mt => mt.WhatItIs == WhatItIs.EndOfTheDay))
            {
                setFadeAlpha(1 - (float)(timeRemaining.TotalSeconds / SecondsToBeatLevel));
            }
        }
    }

    private void setFadeAlpha(float alpha)
    {
        NightFade.color = new Color(NightFade.color.r, NightFade.color.g, NightFade.color.b, alpha);
    }
}
