using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBlockButton : MonoBehaviour
{


    public void BlockButtonPressed()
    {
        Debug.Log("BlockButtonPressed");
        BlockPlacement.instance.SpawnNewBlock(GameManager.instance.AvalableBlocks[0].MyPrefab);
    }
}
