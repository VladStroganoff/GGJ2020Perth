using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMapModel 
{
    public TileMapModel[,] TheWorld = null;


    public TileMapModel(int height, int width)
    {
        TheWorld = new TileMapModel[height, width];
    }
}
