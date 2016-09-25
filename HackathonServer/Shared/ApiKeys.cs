using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackathonServer.Shared
{
    public static class ApiKeys
    {
        public static string ApiKey = "48612c5b-45f9-415c-a7b2-33b6ee6015e9";
        public static string ApiKeyParam = $"&apikey={ApiKey}";

        public static string GoogleMapsApiKey = "AIzaSyDFxZWwXQnfF4ar4ZpFC186UAv9y6yJrI8";
        public static string GoogleMapsApiKeyParam = $"&key={GoogleMapsApiKey}";

        public static string googleMapsUrl => "https://maps.googleapis.com/maps/api/geocode/json?address=";
    }
}
