using UnityEngine;
using System.Collections;

public class PlayerData : MonoBehaviour {

    public static bool firstLaunch = true;
    public static bool z = false;
    public static bool x = false;
    public static bool c = false;
    public static bool isDM = false;

    public GameObject KeyZ, KeyX, KeyC;
    public void EnableZ()
    {
        Instantiate(KeyZ, gameObject.transform.position + Vector3.up * 4, Quaternion.identity);
    }
    public void EnableX()
    {
        Instantiate(KeyX, gameObject.transform.position + Vector3.up * 4, Quaternion.identity);
    }
    public void EnableC()
    {
        Instantiate(KeyC, gameObject.transform.position + Vector3.up * 4, Quaternion.identity);
    }

}
