using UnityEngine;
using System.Collections;

public class learnCKey : MonoBehaviour {

    
    void OnTriggerEnter(Collider obj)
    {
        if(obj.gameObject.tag == "Player")
        {
            Debug.Log("omggggggg");
            PlayerData.c = true;
            obj.gameObject.SendMessage("EnableC");
        }
    }
}
