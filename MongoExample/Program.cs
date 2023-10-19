﻿
using MongoDB.Driver;
using MongoDB.Bson;
using Amazon.Auth.AccessControlPolicy.ActionIdentifiers;

const string connectionUri = "mongodb+srv://testonly:kpoMfnTYY45hZi3f@cluster0.itopv.mongodb.net/?retryWrites=true&w=majority";

var settings = MongoClientSettings.FromConnectionString(connectionUri);

// Set the ServerApi field of the settings object to Stable API version 1
settings.ServerApi = new ServerApi(ServerApiVersion.V1);

// Create a new client and connect to the server
var client = new MongoClient(settings);

// Send a ping to confirm a successful connection
try {
  var result = client.GetDatabase("admin").RunCommand<BsonDocument>(new BsonDocument("ping", 1));
  Console.WriteLine("Pinged your deployment. You successfully connected to MongoDB!");
} catch (Exception ex) {
  Console.WriteLine(ex);
}

List<string> databases = client.ListDatabaseNames().ToList();
foreach (var item in databases) {
    System.Console.WriteLine(item);
}
{
    
}


