using UnityEngine;
using System.Collections;

public class WarpToScene : MonoBehaviour {

    public string sceneName;
    public float delayBeforeCloseEye = 0;
    public float delay = 2;
    public Animator eyeLidAnim;
    public bool changeWhenTrigger = false;
	void OnTriggerEnter(Collider someObj)
    {
        if (someObj.gameObject.tag == "Player" && changeWhenTrigger)
        {
            eyeLidAnim.SetBool("CloseEyeLid", true);
            StartCoroutine(wait());
        }
    }

    void FinishedKeySequences()
    {
        StartCoroutine(wait());
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(delayBeforeCloseEye);
        eyeLidAnim.SetBool("CloseEyeLid", true);
        yield return new WaitForSeconds(delay);
        Application.LoadLevel(sceneName);
    }
}
