using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BlockTileModel
{
    public BlockTileModel NeighbourNorth; // I dont know what to do in here but maybe we whant to know who out neighbours are?
    public BlockTileModel NeighbourSouth;
    public BlockTileModel NeighbourEast;
    public BlockTileModel NeighbourWest;
    public BlockTileModel NeighbourUp;
    public BlockTileModel NeighbourDown;

    public TileType TileType { get; set; }

    /// <summary>
    /// This is the local position of this tile piece if it is in a set of many. If its alone it will just be 0, 0;
    /// </summary>

    public Vector3Int local;
}
