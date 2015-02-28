using UnityEngine;
using System.Collections;

public class GateLeftScript : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    private float totalRotate = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Global.canOpenGates && totalRotate < 90)
        {
            this.transform.Rotate(0f, -0.5f, 0f);
            totalRotate += 0.5f;
        }
    }
}
