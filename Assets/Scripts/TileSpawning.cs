using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawning : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    private Transform playerTransform;
    private float lenght = 10.0f;
    private float x = -10.0f;
    private float extra = 15.0f;
    private int onScreen = 10;
    private int ind;
    private Random random;
    public List<GameObject> active;
    // Start is called before the first frame update
    void Start()
    {
        active = new List<GameObject>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        Spawn();
        Spawn();
        for (int i = 2; i < onScreen; ++i)
        {
            ind = Random.Range(0, 11);
            Spawn(ind);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform.position.x - extra > (x - (onScreen * lenght)))
        {
            ind = Random.Range(0, 11);
            Spawn(ind);
           // Delete();
        }        
    }
    private void Spawn(int index = 0)
    {
        GameObject gobj;
        gobj = Instantiate(tilePrefabs[index]) as GameObject;
        gobj.transform.SetParent(transform);
        gobj.transform.position = Vector3.right * x;
        x = x + lenght;
        active.Add(gobj);
    }
   /* private void Delete()
    {
        Destroy(active[0]);
        active.RemoveAt(0);
    }
    */
}
