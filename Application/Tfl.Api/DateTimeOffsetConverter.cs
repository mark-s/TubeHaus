using System;
using Newtonsoft.Json;

namespace Tfl.Api
{
    public class DateTimeOffsetConverter : JsonConverter<DateTimeOffset>
    {

        public override void WriteJson(JsonWriter writer, DateTimeOffset value, JsonSerializer serializer) 
            => throw new NotImplementedException();

        public override DateTimeOffset ReadJson(JsonReader reader, Type objectType, DateTimeOffset existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            // handle the lack of offset in TFL response when date is 'missing'
            var readerValue = (DateTime)reader.Value;
            return readerValue == DateTime.MinValue ? DateTimeOffset.MinValue : new DateTimeOffset(readerValue);
        }
    }
}
