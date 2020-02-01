using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMapController : MonoBehaviour
{
    public static TileMapController instance;
    public TileMapModel WorldModel { get; private set; }

    public delegate void PiecePlaced(PieceModel newPiece);
    public PiecePlaced PiecePlacedEvent;


    void Awake()
    {
        instance = this;
    }

    public void StartWorld(int xSize, int ySize, int zSize)
    {
        WorldModel = new TileMapModel(xSize, ySize, zSize);
    }

    public void PlacePiece(PieceModel newPiece)
    {
        foreach(BlockTileModel block in newPiece.MyTiles)
        {
            WorldModel.TheWorld[newPiece.position.x + block.local.x, newPiece.position.y + block.local.y, newPiece.position.z + block.local.z] = block; // so origin block will have local position of 0,0 but the other ones will add there local XY values to origin.
        }

        if (PiecePlacedEvent != null)
            PiecePlacedEvent.Invoke(newPiece);
    }
}
