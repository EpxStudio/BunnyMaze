using UnityEngine;
using System.Collections;

public class ColliderPotionScript : MonoBehaviour
{
	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void OnTriggerEnter(Collider C)
    {
        var vector = C.transform.localScale;
        for (float i = 1; i <= 100; i++)
        {
            C.transform.localScale = vector * (.005F * i);
        }
    }
}
