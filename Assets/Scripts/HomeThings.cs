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

public enum WhatItModifies
{
    None,
    PlayerAbilities, // modify player controller
    MonsterAbilities,
    MonsterTypes,
    WorldPhysics,
    HazardTypes,
    Distraction,
    SceneType,
    TimeToFinish,
    CoinCount,
}

public class HomeThing
{
    public string Title;
    public Letter Letter;
    public WhatItModifies Modifying;
    public int GroupId; // Everything with the same WhatItModifies value should have a different GroupId value

    public HomeThing(string title, Letter letter, WhatItModifies modifying, int groupId = 0)
    {
        Title = title;
        Letter = letter;
        Modifying = modifying;
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
        new HomeThing("Honey buns", Letter.H, WhatItModifies.Distraction),
        new HomeThing("Heart", Letter.H, WhatItModifies.PlayerAbilities),
//        new HomeThing("Office", Letter.O, WhatItModifies.SceneType, 1),
        new HomeThing("Obstacles", Letter.O, WhatItModifies.MonsterTypes),
        new HomeThing("Orange tabby cat", Letter.O, WhatItModifies.PlayerAbilities),
        new HomeThing("Memories", Letter.M, WhatItModifies.WorldPhysics),
//        new HomeThing("Mess", Letter.M, WhatItModifies.SceneType, 2),
        new HomeThing("Mortgage", Letter.M, WhatItModifies.WorldPhysics),
        new HomeThing("Money goes", Letter.M, WhatItModifies.WorldPhysics),
        new HomeThing("Eating", Letter.E, WhatItModifies.PlayerAbilities),
        new HomeThing("Electric bills", Letter.E, WhatItModifies.MonsterTypes),
        new HomeThing("End of the day", Letter.E, WhatItModifies.WorldPhysics),
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
// Money goes - WorldPhysics),           must collect -1 coin
// Eating - PlayerAbilities),            you're hungry, -10 seconds to beat level
// Electric bills - MonsterTypes),       must collect +2 coins
// End of the day - WorldPhysics),       you're hungry, -20 seconds to beat level, entire scene fades to black over time

