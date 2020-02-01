using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMapController : MonoBehaviour
{
    public static TileMapController instance;
    public TileMapModel WorldModel { get; private set; }

    public delegate void PiecePlaced(BlockModel newPiece);
    public PiecePlaced PiecePlacedEvent;


    void Awake()
    {
        instance = this;
    }

    public void StartWorld(int xSize, int ySize)
    {
        WorldModel = new TileMapModel(xSize, ySize);
    }

    public void PlacePiece(BlockModel newPiece)
    {



        foreach(BlockTileModel block in newPiece.MyTiles)
        {
            WorldModel.TheWorld[newPiece.X + block.X, newPiece.X + block.Y] = block; // so origin block will have local position of 0,0 but the other ones will add there local XY values to origin.
        }


        if (PiecePlacedEvent != null)
            PiecePlacedEvent.Invoke(newPiece);
    }
}
