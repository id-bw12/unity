using UnityEngine;
using System.Collections;

public class cubeBehavior : MonoBehaviour {


    // Use this for initialization
    void Start () {

        print("Hi there.");

        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);


        GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere); 

        cube.AddComponent<Rigidbody>();

        cube.transform.position = new Vector3(3,0,0);

        cylinder.AddComponent<Rigidbody>();

        cylinder.transform.position = new Vector3(1, 0, 5);

        sphere.AddComponent<Rigidbody>();

        sphere.transform.position = new Vector3(5, 0, 0);

        


    }
	
	// Update is called once per frame
	void Update () {

    }
}
