using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Transport.ly.App.Model;

namespace Transport.ly.App.Data
{
    public class OrderFileDataProvider : IOrderDataProvider
    {
        private readonly string _filePath;

        public OrderFileDataProvider(string filePath)
        {
            _filePath = filePath;
        }

        public IReadOnlyList<Order> Load()
        {
            string content = File.ReadAllText(_filePath);
            // TODO Converter!
            var keyValuePairs = JsonConvert.DeserializeObject<Dictionary<string, OrderDestinationDto>>(content);
            var result = keyValuePairs
                .Select(x => new Order(x.Key, new IATA(x.Value.Destination)))
                .ToList();
            return result;
        }
    }

    public struct OrderDestinationDto
    {
        [JsonProperty("destination")]
        public string Destination { get; set; }
    }
}
