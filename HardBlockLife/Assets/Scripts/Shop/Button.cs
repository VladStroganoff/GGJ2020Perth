using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Button : MonoBehaviour, IPointerDownHandler
{
    public string MyName;
    AudioSource audioData;
    public GameObject MyPrefab;

    public void OnPointerDown(PointerEventData data)
    {
        BlockPlacement.instance.SpawnNewBlock(MyPrefab);
        
        audioData = gameObject.GetComponentInParent(typeof(AudioSource)) as AudioSource;
        audioData.Play(0);
    }
}
