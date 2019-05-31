using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public GameObject BrickRef;
    public GameObject Exit;
    bool Gate = false;
    public GameObject Bomb;
    // Start is called before the first frame update
    void Start()
    {
        int i, j;
        for (i = -4; i <= 4; i++)
        {
            for (j = -4; j <= 4; j++)
            {
                if ((i % 2 == 1 || i % 2 == -1 || !((i + j) % 2 == 0)))
                {
                    if (!(i == 0 && j == 0))
                    {
                        if (!Gate && Random.Range(0, 10) > 5)
                        {
                            Gate = true;
                            Instantiate(Exit, new Vector3(i * 2, j * 2, 0), Quaternion.identity);
                        }
                        Instantiate(BrickRef, new Vector3(i * 2, j * 2, 0), Quaternion.identity);
                    }
                }

            }
        }
        if(!Gate)
        {
            Gate = true;
            Instantiate(Exit, new Vector3((i*2-2), i * 2, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

        
    }

}
