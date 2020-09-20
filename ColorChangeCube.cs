using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    int num = 0;
    public int speed;
    Color[] colors = new Color[5];
    Renderer cubeRend;
    // Start is called before the first frame update
    void Start()
    {
        cubeRend = GetComponent<Renderer>();

        colors[0] = Color.red;
        colors[1] = Color.green;
        colors[2] = Color.blue;
        colors[3] = Color.yellow;
        colors[4] = Color.cyan;
        StartCoroutine("DoCheck");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime * speed);
    }

    IEnumerator DoCheck()
    {
        for(; ; )
        {
            if (num >= 5)
            {
                num = 0;
            }
            cubeRend.material.SetColor("_Color", colors[num]);
            num = num + 1;
            yield return new WaitForSeconds(2.0f);
        }
    }
}
