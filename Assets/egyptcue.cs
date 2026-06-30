using UnityEngine;

public class egyptcue : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Light cuelight;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            cuelight.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            cuelight.enabled = false;
        }
    }
}
