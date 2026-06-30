using UnityEngine;

public class FinalScene : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public innerstatue statue;
    public EgyptTransform egypt;
    public fireBallCue dino;

    public GameObject tracks;
    public GameObject jewel2;


    // Update is called once per frame
    void Update()
    {
        if(dino.visitedd && egypt.visitede && statue.visiteds)
        {
            tracks.SetActive(true);
            jewel2.SetActive(true);
            
        }
    }
}
