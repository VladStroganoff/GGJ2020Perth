using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMapController : MonoBehaviour
{
    public static TileMapController instance;
    public TileMapModel TheWorld { get; private set; }


    void Awake()
    {
        instance = this;
    }

    public void StartWorld(int xSize, int ySize)
    {
        TheWorld = new TileMapModel(xSize, ySize);
    }
}
