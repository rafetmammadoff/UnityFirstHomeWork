using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    [SerializeField] SphereScript SphereScript;
    [SerializeField] GameObject Sphere;
    public string PlayerName = "Nurlan";
    public int Health=300;
    public float Speed = 22f;
    public Vector3 Location = new(10, 22, 11);
    
    void Start()
    {
        Debug.Log(SphereScript.PlayerName);
        Debug.Log(SphereScript.Health);
        Debug.Log(SphereScript.Speed);
        Debug.Log(SphereScript.Location);
        Sphere.GetComponent<Renderer>().material.color = Color.green;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
