using UnityEngine;

public class fireBallCue : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public ParticleSystem meteor;
    public Animator animator;

    public bool visitedd = false;

    

    private void OnTriggerEnter(Collider collision)
    {
       if(visitedd) return;

        if (collision.CompareTag("MainCamera"))
        {
            meteor.Play();
            animator.Play("meteormove", 0, 0f);
            visitedd = true;

        }


    }

    // Update is called once per frame
  
}
