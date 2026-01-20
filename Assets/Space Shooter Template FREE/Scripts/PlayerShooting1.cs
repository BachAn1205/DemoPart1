using UnityEngine;

public class PlayerShooting1 : MonoBehaviour
{
    // 1. Khai báo Prefab đạn
    // Kéo Prefab đạn (ví dụ: Plasma) vào đây từ Inspector.
    public GameObject projectilePrefab;

    // 2. Khai báo điểm xuất phát đạn
    // Kéo đối tượng con rỗng (GameObject rỗng) đặt ở đầu nòng súng vào đây.
    public Transform shotSpawn;

    // 3. Khai báo tốc độ bắn (thời gian chờ giữa các lần bắn)
    public float fireRate = 0.5f; // Bắn 2 lần/giây

    // 4. Biến theo dõi thời gian
    private float nextFire = 0f;

    // Update được gọi mỗi khung hình (tương tự như trong PlayerMovement)
    void Update()
    {
        // Kiểm tra nếu người dùng nhấn nút bắn (ví dụ: phím cách hoặc chuột trái)
        // và đã đủ thời gian chờ (cooldown)
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            // Thiết lập thời gian bắn tiếp theo
            nextFire = Time.time + fireRate;

            // Gọi hàm bắn đạn
            Shoot();
        }
    }

    void Shoot()
    {
        // Tạo một bản sao của Prefab đạn
        // Đặt bản sao đó tại vị trí và góc quay của điểm xuất phát đạn (shotSpawn)
        Instantiate(
            projectilePrefab,
            shotSpawn.position,
            shotSpawn.rotation
        );
    }
}