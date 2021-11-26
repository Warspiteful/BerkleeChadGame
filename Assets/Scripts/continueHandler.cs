using UnityEngine;
using Yarn.Unity;

public class continueHandler : MonoBehaviour
{
    // Start is called before the first frame update

     public DialogueUI dialogueUI;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetButtonDown("Submit")) {
            dialogueUI.MarkLineComplete();
        
     }
    }
}
