using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMapModel 
{
    public BlockTileModel[,] TheWorld = null;


    public TileMapModel(int height, int width)
    {
        TheWorld = new BlockTileModel[height, width];
    }
}
