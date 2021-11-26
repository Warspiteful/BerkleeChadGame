using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imageHandler : MonoBehaviour
{
    // Start is called before the first frame update

    public SpriteRenderer sprite;
    void Start()
    {
        sprite.enabled = false;
    }


    public void reveal(){
        sprite.enabled = true;
    } 

    // Update is called once per frame
    void Update()
    {
        
    }
}
