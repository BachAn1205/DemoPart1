using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 1. In ra vị trí chuột (tọa độ màn hình)
        Debug.Log(Input.mousePosition);

        // 2. Di chuyển Player đến vị trí chuột (tọa độ thế giới)
        var worldPoint =
        Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldPoint.z = 0;
        transform.position = worldPoint;
    }
}   
