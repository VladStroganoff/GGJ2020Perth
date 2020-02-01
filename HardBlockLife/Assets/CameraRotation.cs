using UnityEngine;

public class CameraRotation : MonoBehaviour
{
	public float rotationSpeed = -0.05f;



	private void Update()
	{
		if (BlockPlacement.instance.currentBlock) return;
		if (!Input.GetMouseButton(0)) return;
		float XaxisRotation = Input.GetAxis("Mouse X") * rotationSpeed;
		//float YaxisRotation = Input.GetAxis("Mouse Y") * rotationSpeed;
		// select the axis by which you want to rotate the GameObject
		transform.RotateAround(Vector3.down, XaxisRotation);
		//transform.RotateAround(Vector3.right, YaxisRotation);
	}
}
