using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightWoodResize : MonoBehaviour
{
    public static float rightsize;
    // Start is called before the first frame update
    void Awake()
    {
        rightsize = SawBlade.rightsidesize;
        transform.localScale = new Vector3(transform.localScale.x, rightsize, transform.localScale.z);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
