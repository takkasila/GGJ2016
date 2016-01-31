using UnityEngine;
using System.Collections;

public class FireBall : MonoBehaviour {

    public Vector3 direction;
    public float speed = 4;
    public void Init(Transform target)
    {
        direction = Vector3.Normalize(target.position - transform.position);
        transform.LookAt(target);
    }
	
	void Update () {
        transform.Translate(direction * Time.deltaTime * speed, Space.World);
	}
}
