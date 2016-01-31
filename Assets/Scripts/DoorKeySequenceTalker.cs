using UnityEngine;
using System.Collections;

public class DoorKeySequenceTalker : MonoBehaviour {

    public GameObject mainGate;
	void FinishedKeySequences()
    {
        mainGate.SendMessage("Open");
    }
}
