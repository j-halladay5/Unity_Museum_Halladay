using UnityEngine;

public class EndingScripts : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject bone;
    public bool GoodEnding = false;
    public GameObject endDino;
    public GameObject startDino;
    public GameObject clock;
    public Animator animator;
    public Animator rdoor;
    public Animator ldoor;
    public Light endLight;
    public Light Direction;
    public GameObject gem;
    public GameObject alarm;
    // Update is called once per frame
    void Update()
    {
        if(bone.activeInHierarchy == true)
        {
            GoodEnding = true;
        }
    }

    public void End()
    {
        startDino.SetActive(false); 
        endDino.SetActive(true);
        gem.SetActive(false);


        if (GoodEnding)
        {
            animator.Play("New State", 0, 0f);
            animator.SetTrigger("Call");
            animator.SetTrigger("Hit");
            //animator.Play("call", 0, 0f);
           // animator.Play("Hit3", 0, 0f);
            clock.GetComponent<AudioSource>().Play();
            animator.SetTrigger("hitIdle");
            rdoor.Play("bigRightOpen", 0, 0f);
            ldoor.Play("bigLeftopen", 0, 0f);
            endLight.enabled = true;
            endLight.color = Color.yellow;
        }
        else
        {
            animator.Play("New State", 0, 0f);
            animator.SetTrigger("roar");
            
           // animator.Play("run", 0, 0f);
            alarm.GetComponent<AudioSource>().Play();
            Direction.color = Color.red;
            Direction.intensity = 10;
            rdoor.Play("bigRightOpen", 0, 0f);
            ldoor.Play("bigLeftopen", 0, 0f);
            endLight.enabled = true;
            endLight.color = Color.blue;
            animator.SetTrigger("Run");
            animator.SetTrigger("RunIdle");
        }
    }

   
}
