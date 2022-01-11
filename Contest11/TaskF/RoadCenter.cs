using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;

public class RoadCenter : ITrackingCenter
{
    public List<Camera> camerasField = new List<Camera>();

    public List<Camera> cameras
    {
        get => camerasField;
    }

    public void AddCamera(int id, int maxSpeed)
    {
        camerasField.Add(new Camera(id, maxSpeed));
    }

    public void CheckCarSpeed(int forCameraId, int carNumber, int carSpeed)
    {
        for (int i = 0; i < camerasField.Count; i++)
        {
            if (camerasField[i].id == forCameraId)
                camerasField[i].AddPenalty(carNumber, carSpeed);
        }
    }

    public void GetData(string inFilePath)
    {
        string jsonString = JsonSerializer.Serialize(this);
        Console.WriteLine(jsonString);
        File.WriteAllText(inFilePath, jsonString);
    }
}