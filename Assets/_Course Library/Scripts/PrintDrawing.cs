using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintDrawing : MonoBehaviour
{
    public GameObject printPedestal;
    public GameObject errorUI;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Print()
    {
        GameObject trailObj;
        TrailRenderer originalTrailRenderer;
        TrailRenderer duplicateTrailRenderer;
        trailObj = GameObject.FindGameObjectWithTag("Trail");
        originalTrailRenderer = trailObj.GetComponent<TrailRenderer>();
        if (trailObj != null)
        {
            GameObject printObj = Instantiate(trailObj);
            printObj.transform.position = new Vector3(printPedestal.transform.position.x, (float)(printPedestal.transform.position.y + .5), printPedestal.transform.position.z);
            if (printObj)
            {
                duplicateTrailRenderer = printObj.AddComponent<TrailRenderer>();
                duplicateTrailRenderer.time = originalTrailRenderer.time;
                duplicateTrailRenderer.minVertexDistance = originalTrailRenderer.minVertexDistance;
                duplicateTrailRenderer.widthMultiplier = originalTrailRenderer.widthMultiplier;
                duplicateTrailRenderer.colorGradient = originalTrailRenderer.colorGradient;
                duplicateTrailRenderer.numCornerVertices = originalTrailRenderer.numCornerVertices;
            }
            else
            {
                errorUI.SetActive(true);
            }
        }
    }
}
