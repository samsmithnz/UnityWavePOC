using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainLoop : MonoBehaviour
{
    private List<GameObject> waterList = new List<GameObject>();
    private int i = 0;
    public Material WaterMaterial;
    private int position;

    // Start is called before the first frame update
    void Start()
    {
        position = 0;
        //GameObject oceanFloor = gameObject;
        for (int i = 0; i < 100; i++)
        {
            GameObject waterParticle = GameObject.CreatePrimitive(PrimitiveType.Cube);
            waterParticle.transform.position = new Vector3(i - 49.5f, 1.5f, 1f - 49.5f);
            //waterParticle.transform.parent = oceanFloor.transform;
            waterParticle.tag = "Water";
            waterParticle.transform.GetComponent<Renderer>().material = WaterMaterial;
            waterList.Add(waterParticle);

            GameObject waterParticle2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            waterParticle2.transform.position = new Vector3(i - 49.5f, 0.5f, 1f - 48.5f);
            //waterParticle.transform.parent = oceanFloor.transform;
            waterParticle2.tag = "Water";
            waterParticle2.transform.GetComponent<Renderer>().material = WaterMaterial;
            waterList.Add(waterParticle2);

            GameObject waterParticle3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            waterParticle3.transform.position = new Vector3(i - 49.5f, 0.5f, 1f - 50.5f);
            //waterParticle.transform.parent = oceanFloor.transform;
            waterParticle3.tag = "Water";
            waterParticle3.transform.GetComponent<Renderer>().material = WaterMaterial;
            waterList.Add(waterParticle3);
        }
        position = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (position < 100)
        {
            i++;
            if (i % 30 == 0)
            {
                position++;
                foreach (GameObject item in waterList)
                {
                    item.transform.position = new Vector3(item.transform.position.x, item.transform.position.y, item.transform.position.z + 1f);
                }
            }
        }
    }
}
