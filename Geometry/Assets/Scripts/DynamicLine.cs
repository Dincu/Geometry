using UnityEngine;
using System.Collections;

public class DynamicLine : MonoBehaviour {
    public GameObject shape;
    public GameObject origin;
    public float[] segs = { 1 };
	public bool isParent;

	private float currentTime;
	private float currentWait;
	private int i;

    void Start()
    {
        i = 0;
		currentWait = segs[0];
	}
	
	void Update()
	{
		if((currentTime += Time.deltaTime) > currentWait)
		{
			currentTime -= currentWait;
			
            i = ++i % segs.Length;
			currentWait = segs[i];
			
			if(i > 0)
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
