using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SetWinSentance : MonoBehaviour
{
    public UnityEngine.UI.Text sentance;
    public string sentancePrefix = "Enjoy your ";
    public string sentanceSuffix = ".";

    void Start()
    {
        if (HomeThings.MyThings == null)
            return;

        var titles = HomeThings.MyThings.Select(mt => mt.Title);
        string concatedTitles = string.Join(", ", titles);
        concatedTitles = concatedTitles.Replace(", " + titles.Last(), ", and " + titles.Last());
        concatedTitles = concatedTitles.ToLower();
        sentance.text = sentancePrefix + concatedTitles + sentanceSuffix;
    }

    void Update()
    {
        
    }
}
