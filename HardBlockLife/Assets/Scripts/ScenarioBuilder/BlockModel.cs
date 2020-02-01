using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BlockModel
{
    List<BlockTileModel> MyTiles = new List<BlockTileModel>();
    public GameObject MyPrefab;
}
