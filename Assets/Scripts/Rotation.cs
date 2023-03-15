using UnityEngine;

public class Rotation : MonoBehaviour
{

    Vector3 prevPosition = Vector3.zero;
    Vector3 deltaPosition = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            deltaPosition = Input.mousePosition - prevPosition;
            if (Vector3.Dot(transform.up, Vector3.up) >= 0)
            {
                transform.Rotate(transform.up, -Vector3.Dot(deltaPosition, Camera.main.transform.right), Space.World);
            }
            else
            {
                transform.Rotate(transform.up, Vector3.Dot(deltaPosition, Camera.main.transform.right), Space.World);
            }

            transform.Rotate(Camera.main.transform.right, -Vector3.Dot(deltaPosition, Camera.main.transform.up), Space.World);

        }
        prevPosition = Input.mousePosition;
    }
}
