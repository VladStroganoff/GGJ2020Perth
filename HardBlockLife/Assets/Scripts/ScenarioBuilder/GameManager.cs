using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum GameStates { TitleScreen, InGame, Paused}

public class GameManager : MonoBehaviour // I dont know. maybe this guy will be in charge of scenarios?
{
    public static GameManager instance;

    public List<PieceModel> AvalableBlocks = new List<PieceModel>();

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        InitializePieces();
        TestAllBricks();

    }

    void InitializePieces()
    {
        foreach (PieceModel piece  in AvalableBlocks)
        {
            piece.Initialize();
        }
    }

    void TestAllBricks()
    {
        int j = 0;
        for (int i = 0; i < TileMapController.instance.WorldModel.TheWorld.Length; i++)
        {
            if (CheckIfPieceIsPlaced(new Vector3Int(i, 0,0)))
            {
                    AvalableBlocks[j].position = new Vector3Int(i, 0, 0);
                    TileMapController.instance.PlacePiece(AvalableBlocks[j]);
                j++;
            }
        }
    }

    private bool CheckIfPieceIsPlaced(Vector3Int pos)
    {
        if (TileMapController.instance.WorldModel.TheWorld[pos.x, pos.y, pos.z] == null)
            return true;
        else
            return false;
    }


}
