using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Collection of blocks as a level, can be saved and loaded
/// </summary>
public class HouseManager : MonoBehaviour
{
    private BlockTileModel[,,] _theBlockWorld;
    private string _jsonSerialised;
    public GameObject Prefab;
    public GameObject HouseHolder;

    public void LoadLevel(string loadedJson)
    {
        _jsonSerialised = loadedJson;
        _theBlockWorld = JsonUtility.FromJson<BlockTileModel[,,]>(_jsonSerialised);
    }

    public void SaveLevel()
    {
        _theBlockWorld = TileMapController.instance.WorldModel.TheWorld;
        _jsonSerialised = JsonUtility.ToJson(_theBlockWorld);
    }

    public void LoadPrefabOfHouse(GameObject Prefab)
    {
        var newHouse = Instantiate(Prefab);
        newHouse.transform.parent = HouseHolder.transform;
    }

    public void ClearAwayHouse()
    {
        Debug.Log(HouseHolder.transform.childCount);
        if (HouseHolder.transform.childCount > 0)
            Destroy(HouseHolder.transform.GetChild(0).gameObject);
    }
}
