using UnityEngine;
using System.Collections.Generic;

public class LukeTest : MonoBehaviour
{
    TileMapController _tileController;
    // Use this for initialization
    List<Vector3Int> _bricks;
    private GameObject _prefab;

    void Start()
    {
        _prefab = gameObject.GetComponent<GameManager>().AvalableBlocks[0].MyPrefab;

        Debug.Log("test");
        var y = 1;
        _bricks = new List<Vector3Int>
        {
            new Vector3Int(2, y, 1),
            new Vector3Int(4, y, 1),
            new Vector3Int(6, y, 1),
            new Vector3Int(6, y, 3),
            new Vector3Int(6, y, 5),
            new Vector3Int(4, y, 5),
            new Vector3Int(2, y, 5),
            new Vector3Int(3, y, 2)
        };

        _tileController = TileMapController.instance;
        foreach (var brick in _bricks)
        {
            var newPiece = new PieceModel(TileType.brick)
            {
                position = brick,
                MyPrefab = _prefab
            };
            _tileController.PlacePiece(newPiece);
        }

        Debug.Log(_tileController.WorldModel);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
