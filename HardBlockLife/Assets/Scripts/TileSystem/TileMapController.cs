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


        int i = 0; // to make local space into world space based on the blocks origin

        foreach(BlockTileModel block in newPiece.MyTiles)
        {
            WorldModel.TheWorld[newPiece.LocationX, newPiece.LocationY] = block;

        }


        if (PiecePlacedEvent != null)
            PiecePlacedEvent.Invoke(newPiece);
    }
}
