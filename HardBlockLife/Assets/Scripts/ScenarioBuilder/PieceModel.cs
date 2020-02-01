using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TileType { brick, rock, water, empty, wood, glass, lava }

[System.Serializable]   
public class PieceModel
{
    public string name;
    public List<BlockTileModel> MyTiles = new List<BlockTileModel>();
    public GameObject MyPrefab;


    public TileType type;

    public void Initialize()
    {
        foreach (BlockTileModel tile in MyTiles)
        {
            tile.TileType = type;
        }
    }


    public PieceModel(TileType _type)
    {
        type = _type;
        Initialize();
    }

}
