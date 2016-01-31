using UnityEngine;
using System.Collections;

public class DrakeActionController : MonoBehaviour {

    public float speed = 3.5f;
    public GameObject player;
    public Transform boundLeft, boundRight;
    public GameObject bullet;

    public float interval = 7f;
    public float currentInterval = 0;
    public float lowerInterVal = 0.5f;
    public float growRate = 0.01f;
    float counter = 0;
    float timer = 0;
    // Update is called once per frame
	void Update () {

        UpdatePosition();
        ShootBullet();
	}

    void ShootBullet()
    {
        timer += Time.deltaTime;
        currentInterval = Mathf.Lerp(interval, lowerInterVal, timer * growRate);


        counter += Time.deltaTime;
        if (counter >= currentInterval)
        {
            counter = 0;
            GameObject fireBall = (GameObject)Instantiate(bullet, transform.position + new Vector3(0, 0, -1) * 1, Quaternion.identity);
            FireBall fireBallScript = fireBall.GetComponent<FireBall>();
            fireBallScript.Init(player.transform);
        }
    }
    void UpdatePosition()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
        if(transform.position.x >= boundRight.position.x)
        {
            speed *= -1;
            transform.position = new Vector3(boundRight.position.x, transform.position.y, transform.position.z);
        }
        else if(transform.position.x <= boundLeft.position.x)
        {
            speed *= -1;
            transform.position = new Vector3(boundLeft.position.x, transform.position.y, transform.position.z);
        }
    }
}
