using UnityEngine;


public class blue : MonoBehaviour
{
    public Renderer cubeRen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //AcubeRen = GetComponent<Renderer>();
        cubeRen.material.color = Color.blue;
    }

    void OnTriggerEnter(Collider other)
    {
        //if(other.CompareTag("Hand") || other.CompareTag("Controller"))
        //{
            Debug.Log(other.name + " Coliider");
            cubeRen.material.color = Color.white;
        //}
    }

        void OnTriggerExit(Collider other)
    {
        //if(other.CompareTag("Hand") || other.CompareTag("Controller"))
        //{
            Debug.Log(other.tag + " Coliider");
            cubeRen.material.color = Color.blue;
        //}
    }

}