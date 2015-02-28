using UnityEngine;
using System.Collections;

public class PotionGrowScript : MonoBehaviour
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
        if (C.transform.localScale.x != .5)
        {
            C.transform.localScale *= 2f;
            GameObject.Destroy(gameObject);
            AudSource.audio.Play();
        }

    }
}
