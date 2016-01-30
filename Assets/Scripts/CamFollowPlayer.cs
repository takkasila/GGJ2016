using UnityEngine;
using System.Collections;

public class CamFollowPlayer : MonoBehaviour {

    public Transform Player;
    public Transform sceneBoundLeft, sceneBoundRight;
    public Transform testBox;
    float camBlockWidth;

    void Start()
    {
        calCamBlockWidth_fromPerspective();
        Debug.Log(camBlockWidth);
        testBox.position = new Vector3(camBlockWidth / 2, testBox.position.y, testBox.position.z);
        
    }

    void calCamBlockWidth_fromPerspective()
    {
        Vector3 p = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, -transform.position.z));
        camBlockWidth = Mathf.Abs(p.x * 2);
    }
	void Update () {
        // Will change to LERP
        transform.position = new Vector3(Player.transform.position.x, transform.position.y, transform.position.z);

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
