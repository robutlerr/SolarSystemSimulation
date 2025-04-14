using UnityEngine;
public class LookAtTarget : MonoBehaviour {
    public static GameObject target; // the target that the camera should look at
    void Start () {
        if (target == null) 
        {
            target = this.gameObject;
        }
    }
    void Update () {
        if (target) transform.LookAt(target.transform);
    }
}