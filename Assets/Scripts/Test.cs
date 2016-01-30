using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

    public Animator eyeAnim;
    void FinishedKeySequences()
    {
        Debug.Log("Im here!");
        eyeAnim.SetBool("CloseEyeLid", true);
    }
}
