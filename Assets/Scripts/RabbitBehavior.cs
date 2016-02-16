using UnityEngine;
using System.Collections;

public class RabbitBehavior : MonoBehaviour
{
    public GameObject AudSource;

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
        Global.Bunnies++;
        GameObject.Destroy(gameObject);
        AudSource.GetComponent<AudioSource>().Play();
    }
}
