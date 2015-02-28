using UnityEngine;
using System.Collections;

public class CarrotScript : MonoBehaviour
{

	// Use this for initialization
	void Start()
    {
	
	}
	
	// Update is called once per frame
	void Update()
    {
	}

    void OnTriggerEnter(Collider C)
    {
        Global.CarrotCount++;
        GameObject.Destroy(gameObject);
    }
}