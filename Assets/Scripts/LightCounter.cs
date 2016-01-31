using UnityEngine;
using System.Collections;

public class LightCounter : MonoBehaviour {

    public GameObject kseqObj;
    KeySequence kseq;
    public GameObject light1, light2, light3;
    int score = 0;
	
    void Start()
    {
        kseq = kseqObj.GetComponent<KeySequence>();
    }
	void Update () {
        if(kseq.isFinishedSequence())
        {
            score = kseq.getMaxScore();
        }
        else
        {
            score = kseq.getScore();
        }

        light1.active = light2.active = light3.active = false;

	    switch(score)
        {
            case 3:
                light3.active = true;
                goto case 2;
            case 2:
                light2.active = true;
                goto case 1;
            case 1:
                light1.active = true;
                break;
        }
	}
}
