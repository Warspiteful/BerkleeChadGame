using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Patrol : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;
    
    public Transform groundDetection;
    public float distance;

    public UnityEvent kill;
    private bool movingRight = true;

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);   

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
        RaycastHit2D wallInfo = Physics2D.Raycast(groundDetection.position, Vector2.one, distance);

        if(groundInfo.collider == false || wallInfo.collider == true){
            if(movingRight == true){
            transform.eulerAngles = new Vector3(0,-180, 0);
            movingRight = false;
        } else {
            transform.eulerAngles = new Vector3(0,0, 0);
            movingRight = true;
            }
        }
    } 


     private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            kill.Invoke();
            

        }
    }
}
