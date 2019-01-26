using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    PlayerAbilities,
    MonsterAbilities,
    MonsterTypes,
    WorldPhysics,
    HazardTypes,
}

public class HomeThing
{
    public string Title;
    public Letter Letter;
    public WhatItModifies Modifying;

    public HomeThing(string title, Letter letter, WhatItModifies modifying)
    {
        Title = title;
        Letter = letter;
        Modifying = modifying;
    }
}

public static class HomeThings
{
    public static List<HomeThing> Things = new List<HomeThing>
    {
        //new HomeThing("Hippo", Letter.H, WhatItModifies.PlayerAbilities),
        //new HomeThing("Hornets", Letter.H, WhatItModifies.MonsterTypes),
        //new HomeThing("Orange", Letter.O, WhatItModifies.WorldPhysics),
        //new HomeThing("Orangatangs", Letter.O, WhatItModifies.MonsterTypes),
        //new HomeThing("Messy", Letter.M, WhatItModifies.WorldPhysics),
        //new HomeThing("Mucus", Letter.M, WhatItModifies.WorldPhysics),
        //new HomeThing("Elastic", Letter.E, WhatItModifies.PlayerAbilities),
        //new HomeThing("Elephants", Letter.E, WhatItModifies.MonsterTypes),
        new HomeThing("Honey buns", Letter.H, WhatItModifies.PlayerAbilities),
        new HomeThing("Heart", Letter.H, WhatItModifies.MonsterTypes),
        new HomeThing("Office", Letter.O, WhatItModifies.WorldPhysics),
        new HomeThing("Obstacles", Letter.O, WhatItModifies.MonsterTypes),
        new HomeThing("Orange tabby cat", Letter.O, WhatItModifies.MonsterTypes),
        new HomeThing("Memories", Letter.M, WhatItModifies.WorldPhysics),
        new HomeThing("Mess", Letter.M, WhatItModifies.WorldPhysics),
        new HomeThing("Mortgage", Letter.M, WhatItModifies.WorldPhysics),
        new HomeThing("Money goes", Letter.M, WhatItModifies.WorldPhysics),
        new HomeThing("Eating", Letter.E, WhatItModifies.PlayerAbilities),
        new HomeThing("Electric bills", Letter.E, WhatItModifies.MonsterTypes),
        new HomeThing("End of the day", Letter.E, WhatItModifies.MonsterTypes),
    };
}