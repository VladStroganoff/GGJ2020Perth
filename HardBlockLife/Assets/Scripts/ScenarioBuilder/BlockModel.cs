using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BlockModel
{
    public List<BlockTileModel> MyTiles = new List<BlockTileModel>();
    public GameObject MyPrefab;
    public Vector3 Location;
}
