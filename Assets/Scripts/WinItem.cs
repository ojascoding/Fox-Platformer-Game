using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class WinItem : MonoBehaviour
{
    public ParticleSystem gemParticles;
    public GameObject gemObject;
    public LevelManager levelManager;

    private void OnTriggerEnter2D(Collider2D col)
    {
        gemParticles.Play();
        Destroy(gemParticles, 1.5f);
        Destroy(gameObject);
        Destroy(gemObject, 1.5f);
        Win();
    }

    private void Win()
    {
        // TODO: ADD WIN CONDITIONS
        
        //levelManager.LoadLevel();
    }

    IEnumerator TwoSecondCountdown()
    {
        yield return new WaitForSeconds(2.0f);
    }
}
