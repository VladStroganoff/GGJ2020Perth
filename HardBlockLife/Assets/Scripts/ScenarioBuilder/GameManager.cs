﻿using System;
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
    }

    void InitializePieces()
    {
        foreach (PieceModel piece  in AvalableBlocks)
        {
            piece.Initialize();
        }
    }
}
