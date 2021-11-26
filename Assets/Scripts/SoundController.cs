using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{

    // Start is called before the first frame update

    public AudioSource jumpSound;

    public AudioSource hitSound;
    public AudioSource pickupSound; 

    public AudioSource advanceSound; 


    public void jump(){
        jumpSound.PlayOneShot(jumpSound.clip);
    }

    public void hit(){
        hitSound.PlayOneShot(hitSound.clip);
    }

    public void pickUp(){
        pickupSound.PlayOneShot(pickupSound.clip);
    }

    public void advance(){
        advanceSound.PlayOneShot(advanceSound.clip);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
