using UnityEngine;

public class PlayerShooting1 : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform shotSpawn;
    public float fireRate = 0.5f;

    private float nextFire = 0f;

    void Update()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(projectilePrefab, shotSpawn.position, shotSpawn.rotation);
    }
}