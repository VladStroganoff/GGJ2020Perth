using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CubeCast))]
[RequireComponent(typeof(PreviewCast))]
public class BlockPlacement : MonoBehaviour
{
    public static BlockPlacement instance;

    private CubeCast cubeCast;
    private PreviewCast previewCast;
    private GameManager gameManager;

    public GameObject currentBlock;
    public GameObject HouseHolder;

    List<GameObject> PlacedBlocksListInOrder = new List<GameObject>();

    public bool blockDroppable;

    private void Awake()
    {
        instance = this;
        cubeCast = GetComponent<CubeCast>();
        previewCast = GetComponent<PreviewCast>();
    }

    void Start()
    {
        gameManager = GameManager.instance;
    }

    public void SpawnNewBlock(GameObject newblock)
    {
        CreateNewBlock(newblock);
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (!currentBlock) return;
            Vector3? hit = cubeCast.RaycastOntoCube();
            if (hit != null)
            {
                PrepBlockForPlacing(hit);
            }
            else
            {
                blockDroppable = false;
                hit = previewCast.RaycastOntoPreviewPlane();
                if(hit != null)
                {
                    TrackForPreview(hit);

                    currentBlock.GetComponent<MeshRenderer>().enabled = true;
                }
                else
                {
                    currentBlock.GetComponent<MeshRenderer>().enabled = false;
                }
            }
        }

        if (Input.GetMouseButtonUp(0) && currentBlock) ReleaseBlock();
    }

    private void PrepBlockForPlacing(Vector3? hit)
    {
        currentBlock.GetComponent<MeshRenderer>().enabled = true;
        TrackBlockForPlacement(hit);
        blockDroppable = true;
    }

    private void ReleaseBlock()
    {
        if (blockDroppable) DropBlock();
        else DiscardBlock();

        blockDroppable = false;
    }

    private void DiscardBlock()
    {
        Destroy(currentBlock);
        currentBlock = null;
    }

    private void CreateNewBlock(GameObject newblock)
    {
        currentBlock = Instantiate(newblock);
        currentBlock.transform.parent = HouseHolder.transform;
        PlacedBlocksListInOrder.Add(currentBlock);
    }

    private void SpawnRandomBlock(GameObject newblock)
    {
        int blockToSpawn = Random.Range(0, gameManager.AvalableBlocks.Count);
        currentBlock = Instantiate(gameManager.AvalableBlocks[blockToSpawn].MyPrefab);
    }

    private void TrackBlockForPlacement(Vector3? hit)
    {
        Vector3Int roundedPosition = new Vector3Int((Vector3)hit);
        Vector3 raisedPosition = new Vector3(roundedPosition.x, 7, roundedPosition.z);
        currentBlock.transform.position = raisedPosition;
        //currentBlock.transform.eulerAngles = cubeCast.currentHitNormal * 90;
        //Debug.Log("Position: " + currentBlock.transform.position);
        float xNormal = cubeCast.currentHitNormal.x;
        float zNormal = cubeCast.currentHitNormal.z;
        float yRot;
        if (zNormal < 0)
            yRot = 0;
        else
            yRot = xNormal * 90 + zNormal * 180;
        currentBlock.transform.eulerAngles = new Vector3(currentBlock.transform.eulerAngles.x, yRot, currentBlock.transform.eulerAngles.z);
    }

    private void TrackForPreview(Vector3? hit)
    {
        currentBlock.transform.position = (Vector3)hit;
    }

    void DropBlock()
    {
        //turn on gravity
        //release block
        currentBlock.AddComponent<MeshCollider>().convex = true;
        var rigidBody = currentBlock.AddComponent<Rigidbody>();
        rigidBody.constraints = GameObject.Find("RigidBodyYOnly").GetComponent<Rigidbody>().constraints;

        currentBlock = null;
    }

    public void UndoLastBlock()
    {
        var lastBlock = PlacedBlocksListInOrder.Count - 1;
        Destroy(PlacedBlocksListInOrder[lastBlock]);
        PlacedBlocksListInOrder.RemoveAt(lastBlock);
    }
}