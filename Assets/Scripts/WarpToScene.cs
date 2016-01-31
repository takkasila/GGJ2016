using UnityEngine;
using System.Collections;

public class WarpToScene : MonoBehaviour {

    public string sceneName;
    public float delay = 2;
    public Animator eyeLidAnim;
	void OnTriggerEnter(Collider someObj)
    {
        if (someObj.gameObject.tag == "Player")
        {
            eyeLidAnim.SetBool("CloseEyeLid", true);
            StartCoroutine(wait());
        }
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(delay);
        Application.LoadLevel(sceneName);
    }
}
