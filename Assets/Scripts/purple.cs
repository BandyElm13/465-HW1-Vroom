using UnityEngine;

public class purple : MonoBehaviour
{
     private Renderer rend;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = Color.purple;
    }

    // Update is called once per frame

    public void OnTriggerEnter(Collider other)
    {
        rend.enabled = false;
    }

    public void OnTriggerExit(Collider other)
    {
        rend.enabled = true;
    }
}
