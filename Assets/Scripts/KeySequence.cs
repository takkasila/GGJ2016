using UnityEngine;
using System.Collections;

public class KeySequence : MonoBehaviour {

    public string keySequences;
    public GameObject listenerObject;

    int waitKeyIndex  = 0;

    KeySequence(string keySequences)
    {
        this.keySequences = keySequences;
    }

	void Update () {
        if(Input.anyKeyDown)
        {
            if (string.IsNullOrEmpty(Input.inputString))
                return;
            
            char key = Input.inputString[0];
            if (key == keySequences[waitKeyIndex])
            {
                waitKeyIndex++;
            }
            else
            {
                waitKeyIndex = 0;
            }

        }

        if(waitKeyIndex == keySequences.Length)
        {
            listenerObject.SendMessage("FinishedKeySequences");
            this.enabled = false;
        }
	}
}
