using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace api.Models;

public record RegisterUser(
    [property:BsonId, BsonRepresentation(BsonType.ObjectId)] string? Id,
    [EmailAddress] string Email,
    [MinLength(3), MaxLength(15)] string UserName,
    [MinLength(8), MaxLength(16)] string Password,
    [Range(18,99)] int Age
    );