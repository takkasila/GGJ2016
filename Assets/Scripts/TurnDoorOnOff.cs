using UnityEngine;
using System.Collections;

public class TurnDoorOnOff : MonoBehaviour {
    public Material closeMat;
    public Material openMat;

    void Start()
    {
        StartCoroutine(waitCloseDoor(17));
    }
    void Open()
    {
        StartCoroutine(waitCloseDoor(0));
    }

    IEnumerator waitCloseDoor(float delay)
    {
        yield return new WaitForSeconds(delay);
        gameObject.GetComponent<Renderer>().material = openMat;
        yield return new WaitForSeconds(3.5f);
        gameObject.GetComponent<Renderer>().material = closeMat;

        if(PlayerData.firstLaunch)
        {
            PlayerData.firstLaunch = false;
            PlayerData.z = true;
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            player.SendMessage("EnableZ");
            Debug.Log(player.name);
        }
    }
}
