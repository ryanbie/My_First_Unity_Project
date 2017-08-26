using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour {

    public void Awake()
    {
        Debug.Log("Testing Awake");
    }
    public void OnEnable()
    {
        Debug.Log("Testing Enable");   
    }
    public void Start()
    {
        Debug.Log("Testing Start");
    }
    public void OnDisable()
    {
        Debug.Log("Testing Disable");
    }
}
