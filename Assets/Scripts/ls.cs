using UnityEngine;
using UnityEngine.SceneManagement;

public class ls : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("XR Interaction Toolkit");
    }
    
}
