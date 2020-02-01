using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CubeCast))]
public class BlockPlacement : MonoBehaviour
{
    private CubeCast cubeCast;
    private GameManager gameManager;

    private GameObject currentBlock;

    private void Awake()
    {
        cubeCast = GetComponent<CubeCast>();
    }

    void Start()
    {
        gameManager = GameManager.instance;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            int blockToSpawn = Random.Range(0, gameManager.AvalableBlocks.Count);
            currentBlock = Instantiate(gameManager.AvalableBlocks[blockToSpawn].MyPrefab);
        }

        if(Input.GetMouseButton(0))
        {
            Vector3? hit = cubeCast.RaycastOntoCube();
            if (hit == null) return;
            Vector3Int roundedPosition = new Vector3Int((Vector3)hit);
            Vector3 raisedPosition = new Vector3(roundedPosition.x, 7, roundedPosition.z);
            currentBlock.transform.position = raisedPosition;
        }

        if (Input.GetMouseButtonUp(0))
        {
            DropBlock();
        }
    }

    void DropBlock()
    {
        //turn on gravity
        //release block
        currentBlock.AddComponent<MeshCollider>().convex = true;
        currentBlock.AddComponent<Rigidbody>();
        currentBlock = null;
    }
}