using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToSpeakWithWorld : MonoBehaviour
{
    void Start()
    {
        BlockTileModel TheBlockFromTheSpot = TileMapController.instance.WorldModel.TheWorld[1, 2, 3]; // how to find a block

        TileMapController.instance.PlacePiece(new PieceModel()); // how to submit new piece

        TileMapController.instance.PiecePlacedEvent += Whatever; // how to know what pieces are beeing placed in the world

    }

    void Whatever(PieceModel thePieceThatWasPlaced)
    {
        // whatever man.
    }

}
