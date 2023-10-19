using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Playlist
{
    public ObjectId _id { get; set; }
    [BsonElement("username")]
    public required string user { get; set; }
    public List<string>? items { get; set; }

    public Playlist(string username, List<string> movieIds)
    {
        this.user = username;
        this.items = movieIds;
    }
}