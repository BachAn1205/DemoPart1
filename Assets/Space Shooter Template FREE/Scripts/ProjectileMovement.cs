using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    // Tốc độ di chuyển của đạn
    public float speed = 10f; 

    // Hàm Update được gọi mỗi khung hình
    void Update()
    {
        // Di chuyển đạn theo trục Y (hướng lên)
        // Time.deltaTime giúp việc di chuyển mượt mà và độc lập với tốc độ khung hình
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        // (Tùy chọn) Thêm logic tự hủy đạn khi đi ra khỏi màn hình
        // Ví dụ: nếu Y > 10, hủy đối tượng
        if (transform.position.y > 10f)
        {
            Destroy(gameObject);
        }
    }
}