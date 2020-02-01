using UnityEngine;
using System.Collections.Generic;

public class LukeTest : MonoBehaviour
{
    TileMapController _tileController;
    // Use this for initialization
    List<BrickPlacement> _bricks;
    private GameObject _fullBrickPrefab;
    public GameObject HouseOrigin;

    void Start()
    {
        _fullBrickPrefab = gameObject.GetComponent<GameManager>().AvalableBlocks[0].MyPrefab;

        var y = 0.5f;
        _bricks = new List<BrickPlacement>
        {
            new BrickPlacement(2, y, 1, 0, 0, 0),
            new BrickPlacement(4, y, 1, 0, 0, 0),
            new BrickPlacement(5, y, 1, 0, 90, 0),
            new BrickPlacement(5, y, 3, 0, 90, 0),
            new BrickPlacement(5, y, 5, 0, 0, 0),
            new BrickPlacement(3, y, 5, 0, 0, 0),
            new BrickPlacement(1, y, 5, 0, -90, 0),
            new BrickPlacement(1, y, 3, 0, -90, 0)
        };

        _tileController = TileMapController.instance;
        foreach (var brickPosition in _bricks)
        {
            var newPieceGameObject = Instantiate(_fullBrickPrefab) as GameObject;
            newPieceGameObject.transform.position = brickPosition.GetPostion();
            newPieceGameObject.transform.Rotate(brickPosition.GetRotationEuler(), Space.World);
            newPieceGameObject.transform.parent = HouseOrigin.transform;
            _tileController.AddPiece(newPieceGameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
