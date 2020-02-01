using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class TestBlockButton : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData data)
    {
        Debug.Log("POINTER DOWN AHHH");
    }
    public void BlockButtonPressed()
    {
        Debug.Log("BlockButtonPressed");
        BlockPlacement.instance.SpawnNewBlock(GameManager.instance.AvalableBlocks[0].MyPrefab);
    }
}
