using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderControl : MonoBehaviour
{
    public Transform Origin;

    void Start()
    {
        TileMapController.instance.PiecePlacedEvent += RenderPiece;
    }

    void RenderPiece(PieceModel onePiece) 
    {
        //Instantiate(onePiece.MyPrefab, new Vector3(onePiece.position.x, onePiece.position.y, onePiece.position.z), Quaternion.identity, Origin);
    }
}
