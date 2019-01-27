using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// crossStitch https://i.pinimg.com/originals/d5/36/bc/d536bcf63ebccfbac3a342c51594781f.jpg
// red 552116 blue 0000a4
public enum Letter
{
    None,
    H,
    O,
    M,
    E,
}

public enum WhatItIs
{
    None,
    Honey, // modify player controller
    Heart,
    Office,
    Obstacles,
    OrangeCat,
    Memories,
    Mess,
    Mortgate,
    Money,
    Eating,
    ElectricBills,
    EndOfTheDay,
}

public class HomeThing
{
    public string Title;
    public Letter Letter;
    public WhatItIs WhatItIs;
    public int GroupId; // Everything with the same WhatItModifies value should have a different GroupId value
    public string Tooltip;

    public HomeThing(string title, Letter letter, WhatItIs modifying, string tooltip, int groupId = 0)
    {
        Title = title;
        Letter = letter;
        WhatItIs = modifying;
        Tooltip = tooltip;
        GroupId = groupId;
    }
}

public static class HomeThings
{
    public static List<HomeThing> MyThings;
    public static List<HomeThing> AllThings = new List<HomeThing>
    {
        //new HomeThing("Hippo", Letter.H, WhatItModifies.PlayerAbilities),
        //new HomeThing("Hornets", Letter.H, WhatItModifies.MonsterTypes),
        //new HomeThing("Orange", Letter.O, WhatItModifies.WorldPhysics),
        //new HomeThing("Orangatangs", Letter.O, WhatItModifies.MonsterTypes),
        //new HomeThing("Messy", Letter.M, WhatItModifies.WorldPhysics),
        //new HomeThing("Mucus", Letter.M, WhatItModifies.WorldPhysics),
        //new HomeThing("Elastic", Letter.E, WhatItModifies.PlayerAbilities),
        //new HomeThing("Elephants", Letter.E, WhatItModifies.MonsterTypes),
        new HomeThing("Honey buns", Letter.H, WhatItIs.Honey, "TODO must collect +4 coins"),
        new HomeThing("Heart", Letter.H, WhatItIs.Heart, "wall jump"),
//        new HomeThing("Office", Letter.O, WhatItModifies.SceneType, "TODO office landscape", 1),
        new HomeThing("Obstacles", Letter.O, WhatItIs.Obstacles, "wall slide"),
        new HomeThing("Orange tabby cat", Letter.O, WhatItIs.OrangeCat, "double jump"),
        new HomeThing("Memories", Letter.M, WhatItIs.Memories, "+10 seconds to beat level"),
//        new HomeThing("Mess", Letter.M, WhatItModifies.SceneType, "TODO messy landscape", 2),
        new HomeThing("Mortgage", Letter.M, WhatItIs.Mortgate, "TODO must collect +8 coins"),
        new HomeThing("Money goes", Letter.M, WhatItIs.Money, "TODO must collect -2 coins"),
        new HomeThing("Eating", Letter.E, WhatItIs.Eating, "Hungry, -5 seconds to get home"),
        new HomeThing("Electric bills", Letter.E, WhatItIs.ElectricBills, "TODO must collect +2 coins"),
        new HomeThing("End of the day", Letter.E, WhatItIs.EndOfTheDay, "-20 seconds to beat level"),
    };
}
// Default home scene                    A scene 40 seconds
// Honey buns - Distraction),            must collect +4 coins
// Heart - PlayerAbilities),             PC2D Corner grabs
// Office - SceneType, 1),               A scene 50 seconds
// Obstacles - MonsterTypes),            PC2D +1 air jump
// Orange tabby cat - PlayerAbilities),  PC2D +1 change direction in air jump
// Memories - WorldPhysics),             PC2D +1 air jump
// Mess - SceneType, 2),                 A scene 60 seconds, 
// Mortgage - WorldPhysics),             must collect +10 coins
// Money goes - WorldPhysics),           must collect -2 coin
// Eating - PlayerAbilities),            you're hungry, -10 seconds to beat level
// Electric bills - MonsterTypes),       must collect +2 coins
// End of the day - WorldPhysics),       you're hungry, -20 seconds to beat level, entire scene fades to black over time

