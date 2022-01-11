using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

public class Penalty
{
    [JsonPropertyName("car_number")]
    public int carNumber { get; set; }

    public int cost { get; set; }

    public Penalty(int carNumber, int cost)
    {
        this.carNumber = carNumber;
        this.cost = cost;
    }
}