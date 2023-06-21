using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 2.5f;
        
        Material material = Renderer.material;
        
        material.color = new Color(0.2f, 2.0f, 0.7f, 0.9f);
    }
    
    void Update()
    {
        transform.Rotate(20.0f * Time.deltaTime, 0.0f, 0.0f);
    }
}
