using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PatientInteractor : MonoBehaviour, IInteractable
{
    public GameObject patientDialogue;
    public PlayerInteractionManager playerInteractionManager;
    public void Interact()
    {
        
        StartCoroutine(Typing());
    }
    public IEnumerator Typing()
    {
        patientDialogue.SetActive(true);
        yield return new WaitForSeconds(20.0f);
        patientDialogue.SetActive(false);
        playerInteractionManager.isInteractionRunning = false;
    }
}
