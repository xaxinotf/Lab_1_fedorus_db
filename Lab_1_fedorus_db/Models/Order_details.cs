using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


public class Order_details
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("OrderId")]
    public int OrderId { get; set; }

    [BsonElement("CustomerId")]
    public int CustomerId { get; set; }

    [BsonElement("OrderDate")]
    [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
    public DateTime OrderDate { get; set; }

    [BsonElement("OrderDetails")]
    public List<OrderDetail> OrderDetails { get; set; }
}

public class OrderDetail
{
    [BsonElement("OrderDetailId")]
    public int OrderDetailId { get; set; }

    [BsonElement("BookId")]
    public int BookId { get; set; }

    [BsonElement("Quantity")]
    public int Quantity { get; set; }
    public int OrderId { get; set; }
}