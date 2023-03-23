using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeLight : MonoBehaviour
{
    public Light lt;
    void Start()
    {
        float timeUntilInvoked = 0.1f;//Seconds to pass before invoke
        Invoke("TriggerFunction", timeUntilInvoked);//Invoke certain function after 3.0f seconds
    }

    void TriggerFunction()
    {
        StartCoroutine("FadeIn");//Start a coroutine to run independent from the update function
    }

    IEnumerator FadeIn()
    {
        float duration = 3.0f;
        float interval = 0.1f;
        lt.intensity = 0.0f;
        while(duration >= 0.0f) {
            lt.intensity +=  0.02f;

            duration -= interval;
            yield return new WaitForSeconds(interval);//the coroutine will wait for 0.1 secs
        }
    }
}
