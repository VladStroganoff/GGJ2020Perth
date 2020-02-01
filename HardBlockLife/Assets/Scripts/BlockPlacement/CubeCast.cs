using UnityEngine;

public class CubeCast : MonoBehaviour
{

    public LayerMask targetLayer;

    public GameObject debugCube;

    void Start()
    {
        
    }

    void Update()
    {
    }

    public Vector3? RaycastOntoCube()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, targetLayer))
        {
            Vector3 hitPoint = ray.GetPoint(hit.distance);
            //Debug.Log(hitPoint);
            Debug.Log(hit.collider.gameObject);

            if(debugCube)
                debugCube.transform.position = hitPoint;

            return hit.point;
        }
        return null;
    }
}
