using UnityEngine;

public class MoveStatue : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform focus;
    public innerstatue script;
    public bool onStatue = false;


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("focus"))
        {
            onStatue = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("focus"))
        {
            onStatue = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
   

        if (!onStatue && script.Playerin)
        {
            transform.LookAt(focus);
        }
    }
}
