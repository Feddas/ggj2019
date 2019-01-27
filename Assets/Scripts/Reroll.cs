using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Reroll : MonoBehaviour
{
    public Text titleH;
    public Text titleO;
    public Text titleM;
    public Text titleE;
    public Text modifierH;
    public Text modifierO;
    public Text modifierM;
    public Text modifierE;

    void Start()
    {
        DoReroll();
    }

    void Update()
    {
    }

    public void DoReroll()
    {
        HomeThings.MyThings = new List<HomeThing>();
        var thingH = randomHomeThing(Letter.H);
        titleH.text = highlightFirstLetter(thingH.Title) + ",";
        modifierH.text = thingH.Tooltip;
        HomeThings.MyThings.Add(thingH);

        var thingO = randomHomeThing(Letter.O);
        titleO.text = highlightFirstLetter(thingO.Title) + ",";
        modifierO.text = thingO.Tooltip;
        HomeThings.MyThings.Add(thingO);

        HomeThing thingM;
        do // make sure there are not multiple scene things; both office and mess can't happen at the same time
        {
            thingM = randomHomeThing(Letter.M);
        } while (thingO.WhatItIs == WhatItIs.Office && thingM.WhatItIs == WhatItIs.Mess);
        titleM.text = highlightFirstLetter(thingM.Title) + ", and";
        modifierM.text = thingM.Tooltip;
        HomeThings.MyThings.Add(thingM);

        var thingE = randomHomeThing(Letter.E);
        titleE.text = highlightFirstLetter(thingE.Title) + " are.";
        modifierE.text = thingE.Tooltip;
        HomeThings.MyThings.Add(thingE);
    }

    private HomeThing randomHomeThing(Letter ofLetter)
    {
        var thingsMatchingLetter = HomeThings.AllThings.Where(ht => ht.Letter == ofLetter).ToList();
        var result = thingsMatchingLetter[Random.Range(0, thingsMatchingLetter.Count())];
        return result;
    }

    private string highlightFirstLetter(string textToHighlight)
    {
        return "<color=#b0b>" + textToHighlight.Substring(0, 1) + "</color>" + textToHighlight.Substring(1);
    }
}
