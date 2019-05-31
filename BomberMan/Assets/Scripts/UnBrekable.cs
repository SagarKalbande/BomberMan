using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnBrekable : MonoBehaviour
{
    public GameObject unbreakableObject;
    public int z;

    // Start is called before the first frame update
    void Start()
    {
        var InstantiateHrz= Instantiate(unbreakableObject, new Vector3(4*z+2, 4*z+2, 0), Quaternion.Euler(0, 0, 90));
        for (int i = -z; i <=z ; i++)
        {
            for (int j = -z; j <= z; j++)
            {
                Instantiate(unbreakableObject, new Vector3(i * 4.0F, j * 4.0F, 0), Quaternion.identity);
            }
        }
        InstantiateHrz.transform.localScale = new Vector3(100, 1, 1);
        Instantiate(InstantiateHrz, new Vector3(0, -4*z-2, 0), Quaternion.identity);
        Instantiate(InstantiateHrz, new Vector3(-4*z-2, 4*z+2, 0), Quaternion.Euler(0, 0, 90));
        Instantiate(InstantiateHrz, new Vector3(0, 4*z+2, 0), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
