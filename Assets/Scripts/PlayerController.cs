using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float walkSpeed = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * Time.deltaTime * walkSpeed;
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right* Time.deltaTime * walkSpeed;
        }
	}
}
