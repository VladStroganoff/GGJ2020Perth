using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum GameStates { TitleScreen, InGame, Paused}

public class GameManager : MonoBehaviour // I dont know. maybe this guy will be in charge of scenarios?
{
    public List<PieceModel> AvalableBlocks = new List<PieceModel>();

    void Start()
    {
        foreach(PieceModel piece in AvalableBlocks)
        {
            TileMapController.instance.PlacePiece(piece);
        }
    }
}
