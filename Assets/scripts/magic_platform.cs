using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magic_platform : MonoBehaviour {

	float distance_multiplier = 0f;
	Vector3 initial_position;
	bool aktywowany=false;
	public Vector3 dystans;
	public int powtorzenia;

    void Start()
    {
        initial_position = transform.position;
    }

    // Update is called once per frame
    void Update ()
	{
		if (aktywowany)
		{
			distance_multiplier += (Time.deltaTime * 50f);

			if (distance_multiplier >= powtorzenia)
				distance_multiplier = powtorzenia;

			transform.position = initial_position + dystans * distance_multiplier;
		}
	}

	void OnTriggerEnter(Collider collision)
	{
		if((collision.gameObject.name=="Sphere")||(collision.gameObject.name=="left_sphere_prefab"))
		aktywowany=true;
	}
}
