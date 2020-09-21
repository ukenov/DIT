using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetGazePosition : MonoBehaviour
{
    public GameObject Gaze;
    public GameObject Test;
    public GameObject hover;
    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = new Vector3(hover.transform.position.x, hover.transform.position.y, 0);
        float yRotation = Gaze.transform.eulerAngles.y;
        //Debug.Log(Gaze.transform.eulerAngles.x);
        Debug.Log(Gaze.transform.eulerAngles.y);

        if(yRotation > 26)
        {
            //Test.transform.position = hover.transform.position;
            Test.transform.position = new Vector3(hover.transform.position.x, hover.transform.position.y, hover.transform.position.z);
        }
        //Debug.Log(Gaze.transform.localRotation.y);
        //transform.parent.gameObject.transform.rotation
        //Test.transform.position = temp;
        //player.transform.rotation = Quaternion.Euler(data.Xrotation, data.Yrotation, data.Zrotation);
        
        //Test.transform.rotation = Quaternion.Euler(Gaze.transform.rotation.x, Gaze.transform.rotation.y * 100, 0);
    }
}
