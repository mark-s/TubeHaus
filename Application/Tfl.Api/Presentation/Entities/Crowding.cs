using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class Crowding
    {
        /// <summary>Busiest times at a station (static information)</summary>
        [JsonProperty("passengerFlows")]
        public ICollection<PassengerFlow> PassengerFlows { get; }

        /// <summary>Train Loading on a scale 1-6, 1 being "Very quiet" and 6 being "Exceptionally busy" (static information)</summary>
        [JsonProperty("trainLoadings")]
        public ICollection<TrainLoading> TrainLoadings { get; }

        public Crowding(ICollection<PassengerFlow> passengerFlows, ICollection<TrainLoading> trainLoadings)
        {
            PassengerFlows = passengerFlows;
            TrainLoadings = trainLoadings;
        }
    }
}