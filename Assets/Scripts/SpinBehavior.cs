using UnityEngine;
using System.Collections;

public class SpinBehavior : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(new Vector3(0f, 0.8f, 0f));
	}
}
