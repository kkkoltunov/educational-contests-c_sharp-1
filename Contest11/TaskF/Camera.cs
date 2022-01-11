using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;

public class Camera
{
    public int id { get; set; }

    private int maxSpeed { get; set; }

    public List<Penalty> penalties { get; set; }

    public Camera(int id, int maxSpeed)
    {
        penalties = new List<Penalty>();
        this.id = id;
        this.maxSpeed = maxSpeed;
    }

    public void AddPenalty(int carNumber, int speed)
    {
        if (speed > maxSpeed)
            penalties.Add(new Penalty(carNumber, (speed - maxSpeed) * 100));
    }
}