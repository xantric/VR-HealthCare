using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionSound : MonoBehaviour
{
    public AudioSource collisionAudioSource;
    public AudioClip collisionClip;

    private void OnCollisionEnter(Collision collision)
    {
        PlayCollisionSound(collision.contacts[0].point);
    }

    private void PlayCollisionSound(Vector3 collisionPoint = default(Vector3))
    {
        if (collisionAudioSource != null && collisionClip != null)
        {
            collisionAudioSource.transform.position = collisionPoint != default(Vector3) ? collisionPoint : transform.position;
            collisionAudioSource.PlayOneShot(collisionClip);
            Debug.Log("Collision sound played at: " + collisionAudioSource.transform.position);
        }
    }
}
