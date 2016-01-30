using UnityEngine;
using System.Collections;

public class NPCTriggerKey : MonoBehaviour {

    void OnTriggerEnter(Collider some)
    {
        this.gameObject.AddComponent<KeySequence>();
    }

}
