using UnityEngine;
using System.Collections;

public class CamFollowPlayer : MonoBehaviour {

    public Transform Player;
    public Transform sceneBoundLeft, sceneBoundRight;
    float camBlockWidth;

    void Start()
    {
        calCamBlockWidth_fromPerspective();
    }

    void calCamBlockWidth_fromPerspective()
    {
        Vector3 p = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, -transform.position.z));
        camBlockWidth = p.x * 2;
    }
	void Update () {
        // Will change to LERP
        transform.position = new Vector3(Mathf.Lerp(transform.position.x, Player.position.x, .18f), transform.position.y, transform.position.z);

        if(transform.position.x - camBlockWidth/2 < sceneBoundLeft.position.x)
        {
            transform.position = new Vector3(sceneBoundLeft.position.x + camBlockWidth / 2, transform.position.y, transform.position.z);
        }
        else if(transform.position.x + camBlockWidth/2 > sceneBoundRight.position.x)
        {
            transform.position = new Vector3(sceneBoundRight.position.x - camBlockWidth / 2, transform.position.y, transform.position.z);
        }
	}
}
