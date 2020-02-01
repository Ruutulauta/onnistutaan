using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Camera))]
public class Raycast2D : MonoBehaviour {

    [SerializeField]
    private LayerMask hitLayers = 1 << 9;

    private const float RAYCAST_DISTANCE = 3f;
    private Camera cam;

    // Use this for initialization
    void Start () {
        cam = GetComponent<Camera>();
    }
	
	// Update is called once per frame
	void Update () {
        /*if (Input.GetKey(KeyCode.W)
        {
            DoRaycast();
        }*/
    }

   /* void IsGrounded()
    {
        if(Physics2D.Raycast(transform.position))
    }*/

    private void DoRaycast()
    {
        //Change mouse position from pixel coordinates to a ray
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit;

        if (hit = Physics2D.Raycast(ray.origin, ray.direction, RAYCAST_DISTANCE, hitLayers))
        {
            Debug.Log("seinä " + hit.transform.name);
        }
        /*else
        {
            Vector3 endPoint = ray.origin + ray.direction * RAYCAST_DISTANCE;
            //Debug.DrawLine(ray.origin, endPoint, Color.red, 0.25f);
            Debug.Log("No hit");
        }*/
    }
}
