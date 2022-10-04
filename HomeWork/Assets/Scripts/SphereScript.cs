using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] CubeScript CubeScript;
    [SerializeField] GameObject Cube;
    public string PlayerName = "Rafet";
    public int Health = 100;
    public float Speed = 2f;
    public Vector3 Location = new(1, 2, 1);
    void Start()
    {
        Debug.Log(CubeScript.PlayerName);
        Debug.Log(CubeScript.Health);
        Debug.Log(CubeScript.Speed);
        Debug.Log(CubeScript.Location);
        Cube.GetComponent<Renderer>().material.color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
