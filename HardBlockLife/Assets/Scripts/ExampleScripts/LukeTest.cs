using UnityEngine;
using System.Collections.Generic;

public class LukeTest : MonoBehaviour
{
    TileMapController _tileController;
    // Use this for initialization
    List<Vector3> _bricks;
    private GameObject _fullBrickPrefab;

    void Start()
    {
        _fullBrickPrefab = gameObject.GetComponent<GameManager>().AvalableBlocks[0].MyPrefab;

        Debug.Log("test");
        var y = 1;
        _bricks = new List<Vector3>
        {
            new Vector3(2, y, 1),
            new Vector3(4, y, 1),
            new Vector3(6, y, 1),
            new Vector3(6, y, 3),
            new Vector3(6, y, 5),
            new Vector3(4, y, 5),
            new Vector3(2, y, 5),
            new Vector3(3, y, 2)
        };

        _tileController = TileMapController.instance;
        foreach (var brickPosition in _bricks)
        {
            var newPieceGameObject = Instantiate(_fullBrickPrefab) as GameObject;
            newPieceGameObject.transform.position = brickPosition;

            _tileController.AddPiece(newPieceGameObject);
        }

        Debug.Log(_tileController.WorldModel);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
