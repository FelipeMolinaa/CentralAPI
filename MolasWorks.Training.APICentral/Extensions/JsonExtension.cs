using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace MolasWorks.Training.APICentral.Extensions
{
    public static class JsonExtension
    {

        public static string JsonFormat(this string json) {
            var options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            var jsonElement = JsonSerializer.Deserialize<JsonElement>(json);

            return JsonSerializer.Serialize(jsonElement, options);
        }
    }
}
