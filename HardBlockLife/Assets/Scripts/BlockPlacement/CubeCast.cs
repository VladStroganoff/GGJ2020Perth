using UnityEngine;

public class CubeCast : MonoBehaviour
{

    public LayerMask targetLayer;
    public Vector3 currentHitNormal;

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
            currentHitNormal = hit.normal;
            return hit.point;
        }
        return null;
    }
}
