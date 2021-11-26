using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class exit : MonoBehaviour
{
    public Sprite unlockedSprite;

    public objectPickup key;
    private SpriteRenderer spriteRenderer;

    public UnityEvent onTouch; 
    private bool locked = true;


    void Start()
    {
        spriteRenderer =  transform.GetComponent<SpriteRenderer>();
    }

    public void Unlock(){
        Debug.Log("UNLOCKED");
        spriteRenderer.sprite = unlockedSprite;
        locked = false;
    }

    public void stageChange(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
     private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player") && !locked)
        {
           onTouch.Invoke();

        }
    }

}
