using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMapModel 
{
    public BlockTileModel[,,] TheWorld = null;
    public List<GameObject> AllBlocks = new List<GameObject>();

    public TileMapModel(int height, int width, int length)
    {
        TheWorld = new BlockTileModel[length, width, height]; // fkn 3D m8
    }
}
