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
    /// This is the "block set" or piece's world position
    /// </summary>

    public Vector3Int position { get; set; }
}
