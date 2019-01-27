using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ApplyThings : MonoBehaviour
{
    public Player PlayerController;

    void Start()
    {
        if (HomeThings.MyThings == null)
        {
            return;
        }

        PlayerController.canDoubleJump = HomeThings.MyThings.Any(mt => mt.WhatItIs == WhatItIs.OrangeCat);

        if (HomeThings.MyThings.Any(mt => mt.WhatItIs == WhatItIs.Heart))
        {
            PlayerController.wallJumpClimb = new Vector2(7.5f, 16);
        }
        if (HomeThings.MyThings.Any(mt => mt.WhatItIs == WhatItIs.Obstacles))
        {
            PlayerController.wallSlideSpeedMax = 3;
        }
    }

    void Update()
    {
    }
}
