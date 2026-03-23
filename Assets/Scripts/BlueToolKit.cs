using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class BlueToolKit : MonoBehaviour
{
    private Renderer rend;
    private Color originalColor;

    void Start()
    {
        rend = GetComponent<Renderer>();
        originalColor = rend.material.color;
    }

    void OnTriggerEnter(Collider other)
    {
        //if (other.CompareTag("XRController"))
            rend.material.color = Color.white;
    }

    void OnTriggerExit(Collider other)
    {
        //if (other.CompareTag("XRController"))
            rend.material.color = originalColor;
    }
}