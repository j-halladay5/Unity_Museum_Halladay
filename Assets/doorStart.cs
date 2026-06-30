using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort;

public class doorStart : MonoBehaviour
{
    public Animator anim; // Assign in Inspector
    public string animationStateName = "open"; // Must match Animator state name
    public GameObject gem;

    // Update is called once per frame
    void Start()
    {
        anim.Play(animationStateName, 5, 0f);

        
    
    }
}
