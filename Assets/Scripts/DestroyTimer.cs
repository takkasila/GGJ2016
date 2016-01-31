using UnityEngine;
using System.Collections;

public class DestroyTimer : MonoBehaviour {

    public float time = 1;
	void Start () {
        StartCoroutine(destroyTimer());
	}
    IEnumerator destroyTimer()
    {
        yield return new WaitForSeconds(time);
    }
	
}
