using UnityEngine;

public class EgyptTransform : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public ParticleSystem fire;
    public GameObject before;
    public GameObject after;
    public bool visitede = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            fire.Play();
            before.SetActive(false);
            after.SetActive(true);
            visitede = true;
        }
    }
    // Update is called once per frame
}
