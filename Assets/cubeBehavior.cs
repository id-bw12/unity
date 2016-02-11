using UnityEngine;
using System.Collections;

public class cubeBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
        print("Hi there.");

        var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

        cube.AddComponent<Rigidbody>();

        cube.transform.position = new Vector3(3,0,0);

        var cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);

        cylinder.AddComponent<Rigidbody>();

        cylinder.transform.position = new Vector3(-3, 0, 0);

        var sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);

        sphere.AddComponent<Rigidbody>();

        sphere.transform.position = new Vector3(5, 0, 0);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
