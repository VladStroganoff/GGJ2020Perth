using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PieceModel
{
    public string name;
    public List<BlockTileModel> MyTiles = new List<BlockTileModel>();
    public GameObject MyPrefab;

    /// <summary>
    /// This is the "block set" or piece's origin in world space so where it resides on the world grid;
    /// </summary>

    public Vector3Int local;
}
