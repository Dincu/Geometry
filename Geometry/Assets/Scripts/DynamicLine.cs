using UnityEngine;
using System.Collections;

public class DynamicLine : MonoBehaviour {
    public GameObject shape;
    public GameObject origin;
    public float minSegs;
    public float maxWaitTime;
	public bool isParent;

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
		if((currentTime += Time.deltaTime) > currentWait)
		{
			currentTime -= currentWait;
			
            float maxSegs = Mathf.Max(minSegs*1.5f, maxWaitTime-(i*minSegs));
			currentWait = Random.Range(minSegs, maxSegs);
			
            createNote();
		}
	}
	
	void createNote () {
        GameObject clone = Instantiate(shape) as GameObject;

		if(isParent)
		{
            clone.transform.parent = origin.transform;
		}
	}
}
