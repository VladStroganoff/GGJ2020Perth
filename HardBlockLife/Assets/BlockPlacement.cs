using UnityEngine;

[RequireComponent(typeof(CubeCast))]
[RequireComponent(typeof(PreviewCast))]
public class BlockPlacement : MonoBehaviour
{
    public static BlockPlacement instance;

    private CubeCast cubeCast;
    private PreviewCast previewCast;
    private GameManager gameManager;

    private GameObject currentBlock;

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
        if (Input.GetMouseButtonDown(0))
        {
          //  CreateNewBlock(); we are going to do this on a button press
        }

        if (Input.GetMouseButton(0))
        {
            if (!currentBlock) return;
            Vector3? hit = cubeCast.RaycastOntoCube();
            if (hit != null)
            {
                TrackBlockForPlacement(hit);
            }
            else
            {
                hit = previewCast.RaycastOntoPreviewPlane();
                TrackBlockForPrefab(hit);
            }
        }
        if (Input.GetMouseButtonUp(0) && currentBlock)
            DropBlock();
    }
    private void CreateNewBlock(GameObject newblock)
    {
        currentBlock = Instantiate(newblock);
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
    }

    private void TrackBlockForPrefab(Vector3? hit)
    {
        currentBlock.transform.position = (Vector3)hit;
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