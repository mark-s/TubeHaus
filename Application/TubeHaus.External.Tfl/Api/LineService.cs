using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using Tfl.Api.Presentation.Entities;
using Tfl.Api.RequestModels;
using TubeHaus.External.Tfl.Contracts;

namespace TubeHaus.External.Tfl.Api
{
    public class LineService : ServiceBase
    {
        private readonly TflApiConfig _tflApiConfig;
        private readonly ILineContract _tflApiRestService;

        public LineService(TflApiConfig tflApiConfig)
        {
            _tflApiConfig = tflApiConfig;
            _tflApiRestService = RestService.For<ILineContract>(_tflApiConfig.BaseUri);
        }

        /// <summary>
        /// Gets a list of valid modes
        /// </summary>
        public async Task<ApiResult<IReadOnlyCollection<Mode>>> GetModes()
            => await TryCall(_tflApiRestService.GetModes(_tflApiConfig.AppId, _tflApiConfig.AppKey));

        /// <summary>
        /// Gets a list of valid severity codes
        /// </summary>
        public async Task<ApiResult<IReadOnlyCollection<StatusSeverity>>> GetSeverityCodes()
            => await TryCall(_tflApiRestService.GetSeverityCodes(_tflApiConfig.AppId, _tflApiConfig.AppKey));

        /// <summary>
        /// Gets a list of valid disruption categories
        /// </summary>
        public async Task<ApiResult<IReadOnlyCollection<string>>> GetDisruptionCategories()
            => await TryCall(_tflApiRestService.GetDisruptionCategories(_tflApiConfig.AppId, _tflApiConfig.AppKey));

        /// <summary>
        /// Gets a list of valid ServiceTypes to filter on
        /// </summary>
        public async Task<ApiResult<IReadOnlyCollection<string>>> GetServiceTypes()
            => await TryCall(_tflApiRestService.GetServiceTypes(_tflApiConfig.AppId, _tflApiConfig.AppKey));

        /// <summary>
        /// Gets lines that match the specified line ids
        /// </summary>
        /// <param name="lineIds">
        /// Line ids e.g. victoria,circle,N133. Max. approx. 20 ids.
        /// </param>
        public async Task<ApiResult<IReadOnlyCollection<Line>>> GetLines(string[] lineIds)
            => await TryCall(_tflApiRestService.GetLines(_tflApiConfig.AppId, _tflApiConfig.AppKey, lineIds.ToCsList()));

        /// <summary>
        /// Gets lines that serve the given modes
        /// </summary>
        /// <param name="modes">
        /// A list of modes e.g. tube,dlr
        /// </param>
        public async Task<ApiResult<IReadOnlyCollection<Line>>> GetLinesByMode(string[] modes)
            => await TryCall(_tflApiRestService.GetLinesByMode(_tflApiConfig.AppId, _tflApiConfig.AppKey, modes.ToCsList()));

        /// <summary>
        /// Get all valid routes for all lines, including the name and id of the originating and terminating stops for each route
        /// </summary>
        /// <param name="serviceTypes">
        /// list of service types to filter on. <br />
        /// Supported values from <see cref="LineRouteServiceTypes"/>: Regular, Night. <br />
        /// </param>
        public async Task<ApiResult<IReadOnlyCollection<Line>>> GetAllRoutesForAllLines(string[] serviceTypes)
            => await TryCall(_tflApiRestService.GetAllRoutesForAllLines(_tflApiConfig.AppId, _tflApiConfig.AppKey, serviceTypes.ToCsList()));


        /// <summary>
        /// Get all valid routes for given line ids, including the name and id of the originating and terminating stops for each route
        /// </summary>
        /// <param name="lineIds">
        /// Line ids e.g. victoria,circle,N133. Max. approx. 20 ids.
        /// </param>
        /// <param name="serviceTypes">
        /// A  list of service types to filter on. Supported values: Regular, Night. Defaulted to 'Regular' if not specified
        /// </param>
        public async Task<ApiResult<IReadOnlyCollection<Line>>> GetAllRoutesByLineId(string[] lineIds, string[] serviceTypes)
            => await TryCall(_tflApiRestService.GetAllRoutesByLineId(_tflApiConfig.AppId, _tflApiConfig.AppKey, lineIds.ToCsList(), serviceTypes.ToCsList()));



        /// <summary>
        /// Gets all lines and their valid routes for given modes, including the name and id of the originating and terminating stops for each route
        /// </summary>
        /// <param name="modes">
        /// A comma-separated list of modes e.g. tube,dlr
        /// </param>
        /// <param name="serviceTypes">
        /// A comma separated list of service types to filter on. Supported values: Regular, Night. Defaulted to 'Regular' if not specified
        /// Supported values from <see cref="LineRouteServiceTypes"/>: Regular, Night. <br />
        /// </param>
        public async Task<ApiResult<IReadOnlyCollection<Line>>> GetRoutesAndLinesForModes(string[] modes, string[] serviceTypes)
            => await TryCall(_tflApiRestService.GetRoutesAndLinesForModes(_tflApiConfig.AppId, _tflApiConfig.AppKey, modes.ToCsList(), serviceTypes.ToCsList()));


        /// <summary>
        /// Gets all valid routes for given line id, including the sequence of stops on each route
        /// </summary>
        /// <param name="id">A single line id e.g. victoria</param>
        /// <param name="direction">The direction of travel. Can be inbound or outbound</param>
        /// <param name="excludeCrowding">That excludes crowding from line disruptions. Can be true or false</param>
        /// <param name="serviceTypes"> A comma separated list of service types to filter on. Supported values: Regular, Night. Defaulted to 'Regular' if not specified </param>
        public async Task<ApiResult<RouteSequence>> GetRoutesAndSequenceForLineId(string lineId, Direction direction, bool excludeCrowding, string[] serviceTypes)
            => await TryCall(_tflApiRestService.GetRoutesAndSequenceForLineId(_tflApiConfig.AppId, _tflApiConfig.AppKey, lineId, direction.ToString(), excludeCrowding, serviceTypes.ToCsList()));


        /// <summary>
        /// Gets the line status for given line ids during the provided dates e.g Minor Delays
        /// </summary>
        /// <param name="ids"> A comma-separated list of line ids e.g. victoria,circle,N133. Max. approx. 20 ids </param>
        /// <param name="startDate">Start date</param>
        /// <param name="endDate">End date</param>
        /// <param name="detail">Include details of the disruptions that are causing the line status including the affected stops and routes</param>
        public async Task<ApiResult<IReadOnlyCollection<Line>>> GetLineStatus(string[] lineIds, DateTime startDate, DateTime endDate, bool detail)
            => await TryCall(_tflApiRestService.GetLineStatus(_tflApiConfig.AppId, _tflApiConfig.AppKey, lineIds.ToCsList(), startDate.ToTflShortDate(), endDate.ToTflShortDate(), detail));


    }
}
