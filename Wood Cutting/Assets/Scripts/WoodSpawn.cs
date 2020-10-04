using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class WoodSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject wood;
    public int cooldown;
    public float randomx;
    public Vector3 spawnpos;
    public bool isAlive = true;
    
    
    async void Start()
    {
        while (isAlive != false)
        {
            cooldown = Random.Range(1000, 2500);
            await Task.Delay(cooldown);
            randomx = Random.Range(-2.5f, 2.5f);
            spawnpos = new Vector3(randomx, 14f, 13.35f);
            Instantiate(wood, spawnpos,transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
