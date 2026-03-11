using UnityEngine;

public class blueXRI : MonoBehaviour
{
    public Material blueMaterial;
    public Material whiteMaterial;
    public Renderer blockRenderer;
    
    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Controller"))
        {
            blockRenderer.material = whiteMaterial;
        }
    }

       public void OnTriggerExit(Collider other)
        {
            if(other.CompareTag("Controller"))
            {
                 blockRenderer.material = blueMaterial;
            }
        }
}
