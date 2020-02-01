using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Collection of blocks as a level, can be saved and loaded
/// </summary>
public class House : MonoBehaviour
{
    private BlockTileModel[,,] _theBlockWorld = TileMapController.instance.WorldModel.TheWorld;
    private string _jsonSerialised;

    public void LoadLevel(string loadedJson)
    {
        _jsonSerialised = loadedJson;
        _theBlockWorld = JsonUtility.FromJson<BlockTileModel[,,]>(_jsonSerialised);
    }

    public void SaveLevel()
    {
        _jsonSerialised = JsonUtility.ToJson(_theBlockWorld);
    }
}
