using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Button : MonoBehaviour, IPointerDownHandler
{
    public string MyName;
    public GameObject MyPrefab;

    public void OnPointerDown(PointerEventData data)
    {
        BlockPlacement.instance.SpawnNewBlock(MyPrefab);
    }
}
