using System;

public class Product
{
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }
    public string Category { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public double Price { get; set; }
    public string ImagePath { get; set; }
}