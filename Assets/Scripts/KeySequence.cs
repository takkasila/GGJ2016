using UnityEngine;
using System.Collections;

public class KeySequence : MonoBehaviour {

    public string keySequences;
    public GameObject listenerObject;

    int waitKeyIndex  = 0;

    bool listenKey = false;
    bool finishedKey = false;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            listenKey = true;
            waitKeyIndex = 0;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            listenKey = false;
            waitKeyIndex = 0;
        }
    }

	void Update () 
    {
        if(listenKey && !finishedKey)
        {
            if(Input.anyKeyDown)
            {
                if (string.IsNullOrEmpty(Input.inputString))
                    return;
            
                char key = Input.inputString[0];
                if (key == keySequences[waitKeyIndex])
                {
                    if(key == 'z' && PlayerData.z)
                    {
                        waitKeyIndex++;
                    }
                    else if (key == 'x' && PlayerData.x)
                    {
                        waitKeyIndex++;
                    }
                    else if (key == 'c' && PlayerData.c)
                    {
                        waitKeyIndex++;
                    }
                }
                else
                {
                    waitKeyIndex = 0;
                }

            }

            if(waitKeyIndex == keySequences.Length)
            {
                finishedKey = true;
                listenerObject.SendMessage("FinishedKeySequences");
                //this.enabled = false;
            }
        }
	}

    public int getScore()
    {
        return waitKeyIndex;
    }
    public bool isFinishedSequence()
    {
        return finishedKey;
    }
    public int getMaxScore()
    {
        return keySequences.Length;
    }
}
