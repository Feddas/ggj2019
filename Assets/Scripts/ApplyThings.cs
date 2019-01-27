using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ApplyThings : MonoBehaviour
{
    public Player PlayerController;
    public InventoryEvent ExitInvEvent;
    public Inventory ExitInv;

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

        int additionalCoins = coinCountDelta();
        // Debug.Log("delta is " + additionalCoins);
        ExitInv.DictMyInventory[CollectableItems.Coin] -= additionalCoins;
        ExitInv.UpdateInspectorInventory();
        for (int i = 0; i < additionalCoins; i++)
        {
            ExitInvEvent.EventByInventoryMatch[1].FlagsRequiredToPlay.Add(CollectableItems.Coin);
        }
    }

    void Update()
    {
    }

    private int coinCountDelta()
    {
        int result = 0;

        if (HomeThings.MyThings.Any(mt => mt.WhatItIs == WhatItIs.Honey))
        {
            result += 1;
        }
        if (HomeThings.MyThings.Any(mt => mt.WhatItIs == WhatItIs.Mortgage))
        {
            result += 4;
        }
        if (HomeThings.MyThings.Any(mt => mt.WhatItIs == WhatItIs.Money))
        {
            result -= 1;
        }
        if (HomeThings.MyThings.Any(mt => mt.WhatItIs == WhatItIs.ElectricBills))
        {
            result += 1;
        }

        return result;
    }
}
