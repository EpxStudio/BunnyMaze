using UnityEngine;
using System.Collections;

public class PotionShrinkScript : MonoBehaviour
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
        if (C.transform.localScale.x != .125)
        {
            C.transform.localScale *= .5f;
            GameObject.Destroy(gameObject);
            AudSource.GetComponent<AudioSource>().Play();
        }

    }
}
