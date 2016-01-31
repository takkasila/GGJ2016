using UnityEngine;
using System.Collections;

public class MainSceneManager : MonoBehaviour {

    public GameObject regular, DM;
    public GameObject monDadIntro, monSonIntro;
	// Use this for initialization
	void Start () {
        if(PlayerData.firstLaunch)
        {
            Instantiate(monDadIntro);
            Instantiate(monSonIntro);
        }
        GameObject tempPlayer;
        if(PlayerData.isDM)
        {
            tempPlayer = (GameObject) Instantiate(DM);
        }
        else
        {
            tempPlayer = (GameObject) Instantiate(regular);
        }

        Camera.main.GetComponent<CamFollowPlayer>().Player = tempPlayer.transform;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
