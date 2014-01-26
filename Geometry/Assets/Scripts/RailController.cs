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

		//clone.GetComponent<figureType>().triColor = (TriColor)Random.Range(0, 2);

		Figure figure = clone.GetComponent<figureType>().figure;
		TriColor triColor = clone.GetComponent<figureType>().triColor;
		switch(figure) {
			case Figure.Circle :
				clone.animation.Play("SphereFall"); 
				clone.animation["SphereRight"].layer = 1; 
				clone.animation.Play("SphereRight"); 
				clone.animation["SphereRight"].weight = 0.4f;
				
				break;
	
			case Figure.Cube : 
				clone.animation.Play("CubeFall");
				clone.animation["CubeRotate"].layer = 1; 
				clone.animation.Play("CubeRotate"); 
				clone.animation["CubeRotate"].weight = 0.4f;
				break;

			case Figure.Star : 
				clone.animation.Play("StarFall");
				clone.animation["star_rotation"].layer = 1; 
				clone.animation.Play("star_rotation"); 
				clone.animation["star_rotation"].weight = 0.4f;
				break;
		}

		//TODO Set Material
		switch(triColor)
		{
			case TriColor.Red:
			//clone.renderer.material.set
				break;
			case TriColor.Green:
				break;

			case TriColor.Blue:
				break;
		}

        if (hasParent)
        {
            clone.transform.parent = origin;
        }
    }
}
