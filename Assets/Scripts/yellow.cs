using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private AudioSource audioSource;
    public Renderer cubeRen;
    
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.playOnAwake = false;
        audioSource.Stop();
    }
    void Start()
    {
        cubeRen = GetComponent<Renderer>();
        cubeRen.material.color = Color.yellow;
        audioSource = GetComponent<AudioSource>();

    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject){

            if(other != null)
            {
                audioSource.Play();
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if(other != null)
        {
            audioSource.Stop();
        }

    }
}
