﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{

    public int level;
    public float time;

    public PlayerData( Player player)
    {
        level = player.level;
        time = player.time;
    }

    
}
