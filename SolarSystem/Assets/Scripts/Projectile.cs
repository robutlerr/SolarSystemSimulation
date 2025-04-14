using UnityEngine;

public class Projectile : MonoBehaviour
{
    [Tooltip("The distance this project will move each second in meters")]
    public float projectileSpeed = 3.0f;
    [Tooltip("How far away from the main camera before destroying the object in meters")]
    public float destroyDistance = 20.0f;
    // Update is called once per frame
    void Update()
    {
        MoveProjectile();
    }

    private void MoveProjectile() {
        transform.position += transform.forward * projectileSpeed * Time.deltaTime;
        float dist = Vector3.Distance(Camera.main.transform.position, transform.position);
        if (dist > destroyDistance) {
            Destroy(gameObject);
        }
    }
}
