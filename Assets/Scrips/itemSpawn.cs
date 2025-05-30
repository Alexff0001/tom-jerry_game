using UnityEngine;

public class itemSpawn : MonoBehaviour
{
    public GameObject Jerry;
    public GameObject RightSide;
    public GameObject[] items;
    public GameObject obj;

    public float startDelay, repeatRate;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("Spawn", startDelay, repeatRate);   
    }

    void Spawn()
    {
        Vector3 pos = new Vector3(Jerry.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        // Instantiate(obj, pos, gameObject.transform.rotation);
        Instantiate(items[Random.Range(0, items.Length)], pos, gameObject.transform.rotation);
    }
    // Update is called once per frame
    
}
