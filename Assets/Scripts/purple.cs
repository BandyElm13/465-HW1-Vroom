using UnityEngine;

public class purple : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         GetComponent<Renderer>().material.color = Color.purple;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
