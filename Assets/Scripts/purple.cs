using UnityEngine;

public class purple : MonoBehaviour
{
    private Renderer blockRenderer;
    void Start()
    {
        blockRenderer = GetComponent<Renderer>();
        blockRenderer.material.color = Color.purple;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand") || other.CompareTag("Controller"))
        {
            blockRenderer.enabled = false;
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Hand") || other.CompareTag("Controller"))
        {
            blockRenderer.enabled = true;
        }
    }
    
}
