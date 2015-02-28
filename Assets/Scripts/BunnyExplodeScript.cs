using UnityEngine;
using System.Collections;

public class BunnyExplodeScript : MonoBehaviour
{
    public GameObject toExplode;

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
        Global.canOpenGates = true;
        Global.ShowEatBunny = false;
        GameObject.Destroy(toExplode);
    }
}
