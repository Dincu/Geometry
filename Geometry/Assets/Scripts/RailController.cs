using UnityEngine;
using System.Collections;

public class RailController : MonoBehaviour {
    public GameObject[] shapes;
    public Transform[] origins;
    public float minSegs;
    public float maxWaitTime;
    public bool hasParent;

    private float currentTime;
    private float currentWait;
    private int i;

    void Start()
    {
        i = 0;
        currentWait = minSegs;
    }

    void Update()
    {
        if ((currentTime += Time.deltaTime) > currentWait)
        {
            currentTime -= currentWait;

            float maxSegs = Mathf.Max(minSegs, maxWaitTime - (i * minSegs));
            Debug.Log(maxSegs);
            currentWait = Random.Range(minSegs, maxSegs);
            i++;

            createNote(getRandomOrigin());
        }
    }

    Transform getRandomOrigin()
    {
        return origins[Random.Range(0, origins.Length)];
    }

    void createNote(Transform origin)
    {
        GameObject clone = Instantiate(shapes[Random.Range(0, shapes.Length)]) as GameObject;


		clone.animation.Play("Falling"); 
		clone.animation["SphereRight"].layer = 1; 
		clone.animation.Play("SphereRight"); 
		clone.animation["SphereRight"].weight = 0.4f;

        if (hasParent)
        {
            clone.transform.parent = origin;
        }
    }
}
