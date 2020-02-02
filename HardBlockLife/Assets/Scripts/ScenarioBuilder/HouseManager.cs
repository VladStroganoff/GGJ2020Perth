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
    public GameObject Prefab2;
    public GameObject Prefab3;
    public GameObject HouseHolder;
    public GameObject[] comps;
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
        float rand = Random.Range(0,3);
        if (rand < 1)
        {
        var newHouse = Instantiate(Prefab);
        newHouse.transform.parent = HouseHolder.transform;
        }else if(rand == 2){
            var newHouse = Instantiate(Prefab2);
        newHouse.transform.parent = HouseHolder.transform;
        }else {
            var newHouse = Instantiate(Prefab3);
        newHouse.transform.parent = HouseHolder.transform;
        }
    }

    public void ClearAwayHouse()
    {
        for(var i = 0; i < HouseHolder.transform.childCount; i++)
            Destroy(HouseHolder.transform.GetChild(i).gameObject);
        comps = GameObject.FindGameObjectsWithTag("components");
        foreach (GameObject gameObject in comps)
        {
            Destroy(gameObject);
        }
    }
}
