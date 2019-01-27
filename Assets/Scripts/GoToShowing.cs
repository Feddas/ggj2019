using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class GoToShowing : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    public void Restart()
    {
        SceneManager.LoadScene("Reroll");
    }

    public void GoToScene()
    {
        var scene = HomeThings.MyThings
            .Where(mt => mt.WhatItIs == WhatItIs.Office || mt.WhatItIs == WhatItIs.Mess)
            .FirstOrDefault();

        if (scene == null)
        {
            SceneManager.LoadScene("ShowingHouse");
            return;
        }

        // Debug.Log(scene.Title + " has Group Id " + scene.GroupId);
        switch (scene.GroupId)
        {
            default:
            case 0: // default, home
                SceneManager.LoadScene("ShowingHouse");
                break;
            case 1: // office
                SceneManager.LoadScene("ShowingOffice");
                break;
            case 2: // mess
                SceneManager.LoadScene("ShowingMess");
                break;
        }
    }
}
