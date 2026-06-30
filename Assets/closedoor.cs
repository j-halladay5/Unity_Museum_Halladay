using UnityEngine;

public class closedoor : MonoBehaviour
{
    public Animator animator; 
    public string animationStateName = "close"; 

  
    // Update is called once per frame
    
    private void OnTriggerExit(Collider collision)
    {
        animator.SetTrigger("cls");

    }
}
