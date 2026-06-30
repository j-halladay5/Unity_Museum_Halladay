using System.Collections;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.Playables;

public class PhoneTrig : MonoBehaviour
{
    public ParticleSystem sparks;
    public GameObject phone;
    public GameObject curtain;
    public GameObject jewel;
    public Light sLight;
    public bool ready = false;
 
    public int count = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
    
    private void OnTriggerExit(Collider other)
    {
        if (sparks != null && count == 0)
        {
            sparks.Play();
            sparks.GetComponent<AudioSource>().Play();
            count++;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (count == 1)
        {
            sparks.Pause();
            sparks.GetComponent<AudioSource>().Pause();
            curtain.SetActive(true);
            phone.GetComponent<AudioSource>().Play();
            jewel.SetActive(false);
            sLight.enabled = true;
            Invoke(nameof(LightsOn), 3f);
            ready = true;
            count++;
        }
    }
    
   
    // Update is called once per frame
    void LightsOn()
    {
        curtain.SetActive(false);
    }
    
}
