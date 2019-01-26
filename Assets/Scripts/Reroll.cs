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
        var thingH = randomHomeThing(Letter.H);
        titleH.text = highlightFirstLetter(thingH.Title) + ",";
        modifierH.text = thingH.Modifying.ToString();

        var thingO = randomHomeThing(Letter.O);
        titleO.text = highlightFirstLetter(thingO.Title) + ",";
        modifierO.text = thingO.Modifying.ToString();

        var thingM = randomHomeThing(Letter.M);
        titleM.text = highlightFirstLetter(thingM.Title) + ", and";
        modifierM.text = thingM.Modifying.ToString();

        var thingE = randomHomeThing(Letter.E);
        titleE.text = highlightFirstLetter(thingE.Title) + " are.";
        modifierE.text = thingE.Modifying.ToString();
    }

    private HomeThing randomHomeThing(Letter ofLetter)
    {
        var thingsMatchingLetter = HomeThings.Things.Where(ht => ht.Letter == ofLetter).ToList();
        var result = thingsMatchingLetter[Random.Range(0, thingsMatchingLetter.Count())];
        return result;
    }

    private string highlightFirstLetter(string textToHighlight)
    {
        return "<color=#b0b>" + textToHighlight.Substring(0, 1) + "</color>" + textToHighlight.Substring(1);
    }
}
