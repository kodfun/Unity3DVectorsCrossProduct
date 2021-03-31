using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossProductScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject s1 = GameObject.Find("s1");
        GameObject s2 = GameObject.Find("s2");
        Vector3 v1 = s1.transform.position;
        Vector3 v2 = s2.transform.position;
        Vector3 v3 = Vector3.Cross(v1, v2);

        v3 = new Vector3(v3.x, v3.y / 10f, v3.z);
        transform.position = v3;
    }
}
