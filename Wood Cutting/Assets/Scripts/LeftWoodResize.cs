using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftWoodResize : MonoBehaviour
{
    public static float leftsize;
    // Start is called before the first frame update
    void Awake()
    {
        leftsize = SawBlade.leftsidesize;
        transform.localScale = new Vector3(transform.localScale.x, leftsize, transform.localScale.z);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
