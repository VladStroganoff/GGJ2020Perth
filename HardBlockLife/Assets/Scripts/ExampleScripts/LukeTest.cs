using UnityEngine;
using System.Collections.Generic;

public class LukeTest : MonoBehaviour
{
    TileMapController _tileController;
    // Use this for initialization
    List<Vector3Int> _bricks;

    void Start()
    {
        var y = 1;
        var prefab = Resources.Load("redbrick_full");

        _bricks.Add( new Vector3Int(2, y, 1) );
        _bricks.Add( new Vector3Int(4, y, 1) );
        _bricks.Add( new Vector3Int(6, y, 1) );
        _bricks.Add( new Vector3Int(6, y, 3) );
        _bricks.Add( new Vector3Int(6, y, 5) );
        _bricks.Add( new Vector3Int(4, y, 5) );
        _bricks.Add( new Vector3Int(2, y, 5) );
        _bricks.Add( new Vector3Int(3, y, 2) );

        _tileController = TileMapController.instance;
        foreach (var brick in _bricks)
        {
            PieceModel newPiece = new PieceModel(TileType.brick)
            {
                position = brick,
                MyPrefab = Instantiate(prefab) as GameObject
            };
            _tileController.PlacePiece(newPiece);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
