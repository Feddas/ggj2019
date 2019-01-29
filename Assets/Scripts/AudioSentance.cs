using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[RequireComponent(typeof(AudioSource))]
public class AudioSentance : MonoBehaviour
{
    public AudioClip AudioPrefix;
    public AudioClip Heart;
    public AudioClip Honey;
    public AudioClip Obstacles;
    public AudioClip Office;
    public AudioClip OrangeCat;
    public AudioClip Memories;
    public AudioClip Mess;
    public AudioClip Money;
    public AudioClip Mortgage;
    public AudioClip Eating;
    public AudioClip ElectricBills;
    public AudioClip EndOfTheDay;

    private new AudioSource audio;
    private Dictionary<WhatItIs, AudioClip> ClipDictionary;
    private int activeThread;

    void Start()
    {
        audio = this.GetComponent<AudioSource>();

        ClipDictionary = new Dictionary<WhatItIs, AudioClip>()
        {
            { WhatItIs.Heart, Heart },
            { WhatItIs.Honey, Honey },
            { WhatItIs.Obstacles, Obstacles },
            { WhatItIs.Office, Office },
            { WhatItIs.OrangeCat, OrangeCat },
            { WhatItIs.Memories, Memories },
            { WhatItIs.Mess, Mess },
            { WhatItIs.Money, Money },
            { WhatItIs.Mortgage, Mortgage },
            { WhatItIs.Eating, Eating },
            { WhatItIs.ElectricBills, ElectricBills },
            { WhatItIs.EndOfTheDay, EndOfTheDay },
        };

        SayMyHome();
    }

    void Update()
    {
    }

    public void SayMyHome()
    {
        StartCoroutine(sayMyHome());
    }

    public IEnumerator sayMyHome()
    {
        // say "Home is where the"
        audio.Stop();
        yield return null;
        audio.clip = AudioPrefix;
        audio.Play();

        // prepare to say the 4 words of the acryonym
        WhatItIs[] homeThings = HomeThings.MyThings
            .Select(mt => mt.WhatItIs).ToArray();
        int myThread = ++activeThread;
        yield return new WaitForSeconds(AudioPrefix.length);

        // say the 4 works as long as a reroll hasn't interrupted
        for (int i = 0; i < 4; ++i)
        {
            if (myThread != activeThread)
                break;
            yield return playClip(homeThings[i]);
        }
    }

    private IEnumerator playClip(WhatItIs ofType)
    {
        audio.Stop();
        yield return null;
        audio.clip = ClipDictionary[ofType];
        audio.Play();
        yield return new WaitForSeconds(audio.clip.length);
    }
}
