using UnityEngine;
using System.Collections;

public class cubeBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
        print("Hi there.");

        var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

        cube.AddComponent<Rigidbody>();

        cube.transform.position = new Vector3(3,0,0);

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
