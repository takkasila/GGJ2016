using UnityEngine;
using System.Collections;

public class ChangeToDM : MonoBehaviour {
    public GameObject DMChar;
    public void FinishedKeySequences()
    {
        gameObject.SendMessage("EnableX");
        PlayerData.x = true;
        PlayerData.isDM = true;
        GameObject tempPlayer = (GameObject) Instantiate(DMChar, gameObject.transform.position, Quaternion.identity);
        CamFollowPlayer camfollow = Camera.main.GetComponent<CamFollowPlayer>();
        camfollow.Player = tempPlayer.transform;
        Destroy(gameObject);
    }

}
