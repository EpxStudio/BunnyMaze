using UnityEngine;
using System.Collections;

public class InvisibleWallBehavior : MonoBehaviour
{
    public GameObject toRemove;
    public GameObject toReplace;

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
        toReplace.transform.Translate(new Vector3(0f, 2.49999f, 0f));
        GameObject.Destroy(toRemove);
    }
}
