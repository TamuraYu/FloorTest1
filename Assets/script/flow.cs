using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flow : MonoBehaviour
{

    private float time;
    public int offset;

    // Start is called before the first frame update
    void Start()
    {
        time = offset;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 0f, Time.deltaTime);
        time += Time.deltaTime;
        if(time > 30f)
        {
            time -= 30f;
            transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z - 30f);
        }
    }
}
