using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public float maxTime;
    private float time;
    public GameObject pipe;
    GameObject pipeClone;
    public float dist;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (time > maxTime)
        {
            PipeSpawner();
            time = 0;
        }
        time += Time.deltaTime;
    }

    void PipeSpawner()
    {
        pipeClone = Instantiate(pipe);
        pipeClone.transform.position = transform.position + new Vector3(0, Random.Range(dist, -dist), 0);
        Destroy(pipeClone, 5f);
    }
}
