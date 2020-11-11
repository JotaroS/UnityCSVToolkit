using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSVToolkitDemo : MonoBehaviour
{
    CSVExporter logger;
    // Start is called before the first frame update
    void Start()
    {
        logger = this.gameObject.GetComponent<CSVExporter>();
        logger.LogLine("d1,d2,d3,label");   //write header
        float[] data = new float[3]{1, 2,3}; //data
        string label = "apple"; //label 

        logger.LogDataLabel(data, label); //log data and the label
        //logger.LogData(data); //this is also an option
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
