using UnityEngine;
using System.Collections;

public class ExampleScript : MonoBehaviour {

    public void FixedUpdate()
    {
        Debug.Log("Testing fixedUpdate " + Time.fixedDeltaTime);
    }

    public void Update()
    {
        Debug.Log("Testing Update " + Time.deltaTime);
    }
}