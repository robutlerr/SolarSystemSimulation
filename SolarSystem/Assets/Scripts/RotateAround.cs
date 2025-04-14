using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public Transform target;        // target to rotate around
    public int speed;               // speed to rotate at
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   
        if (target == null) {
            target = gameObject.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround (target.position, Vector3.up, speed*Time.deltaTime);
    }
}
