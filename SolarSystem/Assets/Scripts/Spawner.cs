using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("Spawn", 1.0f, 5.0f);
    }

    // Update is called once per frame
    void Spawn()
    {
        Instantiate(target, transform.position, transform.rotation, null);
    }
}
