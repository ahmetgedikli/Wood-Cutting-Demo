using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class SawBlade : MonoBehaviour
{
    // Start is called before the first frame update
    public float cylinderstartx;
    public float cylinderendx;
    public float leftsideposx;
    public float rightsideposx;
    public Vector3 leftsidepos;
    public Vector3 rightsidepos;
    public static float leftsidesize;
    public static float rightsidesize;
    GameObject silindir;
    public GameObject spawnleft;
    public GameObject spawnright;
    private Touch touch;
    public float speed=0.1f;
    public Transform talas;
    public float speed1;
    private Shake shake;
    void Start()
    {
        talas.GetComponent<ParticleSystem>().enableEmission = false;
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();

    }

    [System.Obsolete]
    void OnCollisionEnter(UnityEngine.Collision collision)
    {
        silindir = collision.gameObject;
        if (collision.gameObject.name == "Wood(Clone)")
        {
            cylinderstartx = silindir.transform.position.x - silindir.transform.localScale.x / 2;
            cylinderendx = silindir.transform.position.x + silindir.transform.localScale.x / 2;
            rightsidesize = cylinderendx - transform.position.x;
            leftsidesize = transform.position.x - cylinderstartx;
            leftsideposx = transform.position.x - leftsidesize / 2;
            rightsideposx = transform.position.x + rightsidesize / 2;
            leftsidepos = new Vector3(leftsideposx, silindir.transform.position.y, silindir.transform.position.z);
            rightsidepos = new Vector3(rightsideposx, silindir.transform.position.y, silindir.transform.position.z);
            talas.GetComponent<ParticleSystem>().enableEmission = true;
            Instantiate(spawnleft, leftsidepos, silindir.transform.rotation);
            Instantiate(spawnright, rightsidepos, silindir.transform.rotation);
            shake.CamShake();
            Destroy(silindir);
            StartCoroutine(stopSparkles());
        }
    IEnumerator stopSparkles()
        {
            yield return new WaitForSeconds(0.4f);
            talas.GetComponent<ParticleSystem>().enableEmission = false;
        }




    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(speed1, 0f,0f);
    }
}
