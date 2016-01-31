using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float walkSpeed = 1;
    public Animator anim;

	void Update () {

        resetAnimBool();
        if (Input.GetKeyDown(KeyCode.Z) && PlayerData.z)
        {
            anim.SetBool("z", true);
            return;
        }
        else if (Input.GetKeyDown(KeyCode.X) && PlayerData.x)
        {
            anim.SetBool("x", true);
            return;
        }
        else if (Input.GetKeyDown(KeyCode.C) && PlayerData.c)
        {
            anim.SetBool("c", true);
            return;
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            anim.SetBool("v", true);
            return;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * Time.deltaTime * walkSpeed;
            transform.rotation = Quaternion.Euler(0, 0, 0);
            anim.SetBool("Walking", true);
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right* Time.deltaTime * walkSpeed;
            transform.rotation = Quaternion.Euler(0, 180, 0);
            anim.SetBool("Walking", true);
        }
        

	}

    void resetAnimBool()
    {
        anim.SetBool("Walking", false);
        anim.SetBool("z", false);
        anim.SetBool("x", false);
        anim.SetBool("c", false);
        anim.SetBool("v", false);
    }
}
