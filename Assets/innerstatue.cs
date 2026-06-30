using UnityEditor;
using UnityEngine;

public class innerstatue : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject statue;
    public bool Playerin = false;
    public bool visiteds = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            statue.GetComponent<AudioSource>().Pause();
            Playerin = true;
            visiteds = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            Playerin = false;
        }
    }
}
