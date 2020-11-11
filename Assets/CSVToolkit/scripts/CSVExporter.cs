using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class CSVExporter:MonoBehaviour
{
    private StreamWriter sw;
    private FileInfo fi;

    private DateTime date;
    public string rootDirname = "/data/";
    public string format = "yyyy-MM-dd-HH-mm-ss";
    public string filename = "";
    public int rowCount = 0;

    // constructor
    public CSVExporter(){}
    public CSVExporter(string _filename){
        filename = _filename;
    }

    public void Start(){
        date=DateTime.Now;
    }
    public void StartLogging(){
        
    }
    public void SetFileName(string s){
        this.filename = s;
    }
    /// <summary>
    // Just directly write any string in to the file.
    /// </summary>
    public void LogLine(string s){
        fi = new FileInfo(Application.dataPath + rootDirname+date.ToString(format)+filename+".csv");
        sw = fi.AppendText();
        sw.WriteLine(s);
        sw.Flush();
        sw.Close();
        rowCount++;
    }
    /// <summary>
    // Write data (float array) and the label in the end of the csv.
    /// </summary>
    public void LogDataLabel(float[] data, string label){
        string res = "";
        for(int i=0; i < data.Length; i++){
            res+=data[i].ToString();
            res+=",";
        }
        res += label;
        this.LogLine(res);
    }
    public void LogData(float[] data){
        string res = "";
        for(int i=0; i < data.Length; i++){
            res+=data[i].ToString();
            if(i<= data.Length-1)res+=",";
        }
        this.LogLine(res);
    }
    public void LogStrings(string[] data){
        string res = "";
        for(int i=0; i < data.Length; i++){
            res+=data[i];
            if(i<= data.Length-1)res+=",";
        }
        this.LogLine(res);
    }
}
