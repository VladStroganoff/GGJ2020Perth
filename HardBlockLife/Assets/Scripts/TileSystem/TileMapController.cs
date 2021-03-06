﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMapController : MonoBehaviour
{
    public static TileMapController instance;
    public TileMapModel WorldModel { get; private set; }

    public delegate void PiecePlaced(PieceModel newPiece);
    public PiecePlaced PiecePlacedEvent;

    public Vector3Int WorldSize;


    void Awake()
    {
        instance = this;
        WorldModel = new TileMapModel(WorldSize.x, WorldSize.y, WorldSize.z);
    }

    public void StartWorld(int xSize, int ySize, int zSize)
    {
    }

    public void PlacePiece(PieceModel newPiece)
    {
        foreach(BlockTileModel block in newPiece.MyTiles)
        {
            //Debug.Log("Cordinate" + (newPiece.position.x + block.local.x));
            //WorldModel.TheWorld[newPiece.position.x + block.local.x, newPiece.position.y + block.local.y, newPiece.position.z + block.local.z] = block; // so origin block will have local position of 0,0 but the other ones will add there local XY values to origin.
        }

        if (PiecePlacedEvent != null)
            PiecePlacedEvent.Invoke(newPiece);
    }

    public void AddPiece(GameObject newPiece)
    {
        WorldModel.AllBlocks.Add(newPiece);
    }

}
