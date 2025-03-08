using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdateVitalsData : MonoBehaviour
{
    public TextMeshPro heartRate;
    public TextMeshPro bloodO2;

    public void UpdateVitalData()
    {
        StartCoroutine(DataUpdater());
    }
    public void StopDataUpdation()
    {
        StopCoroutine(DataUpdater());
    }
    public IEnumerator DataUpdater()
    {
        while (true)
        {
            int random = Random.Range(72, 90);
            heartRate.text = random.ToString() + " " +"bpm"; 
            yield return new WaitForSeconds(1.2f);
        }
    }
}
