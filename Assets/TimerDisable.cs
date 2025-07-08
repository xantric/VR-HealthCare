using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerDisable : MonoBehaviour
{
    private void OnEnable()
    {
        StartCoroutine(Disable());
    }
    IEnumerator Disable()
    {
        yield return new WaitForSeconds(5.0f);
        gameObject.SetActive(false);
    }
}
