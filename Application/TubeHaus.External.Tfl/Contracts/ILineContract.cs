using System.Collections.Generic;
using Tfl.Api.Presentation.Entities;
using System.Threading.Tasks;
using Refit;

namespace TubeHaus.External.Tfl.Contracts
{
    internal interface ILineContract
    {
        /// <summary>
        /// Gets a list of valid modes
        /// </summary>
        [Get("/line/meta/modes?app_id={appId}&app_key={appKey}")]
        Task<IReadOnlyCollection<Mode>> GetModes(string appId, string appKey);

        /// <summary>
        /// Gets a list of valid severity codes
        /// </summary>
        [Get("/line/meta/severity?app_id={appId}&app_key={appKey}")]
        Task<IReadOnlyCollection<StatusSeverity>> GetSeverityCodes(string appId, string appKey);

        /// <summary>
        /// Gets a list of valid disruption categories
        /// </summary>
        [Get("/line/meta/DisruptionCategories?app_id={appId}&app_key={appKey}")]
        Task<IReadOnlyCollection<string>> GetDisruptionCategories(string appId, string appKey);

        /// <summary>
        /// Gets a list of valid ServiceTypes to filter on
        /// </summary>
        [Get("/line/meta/ServiceTypes?app_id={appId}&app_key={appKey}")]
        Task<IReadOnlyCollection<string>> GetServiceTypes(string appId, string appKey);

        /// <summary>
        /// Gets lines that match the specified line ids
        /// </summary>
        /// <param name="ids"> A comma-separated list of line ids e.g. victoria,circle,N133. Max. approx. 20 ids</param>
        [Get("/Line/{ids}?app_id={appId}&app_key={appKey}")]
        Task<IReadOnlyCollection<Line>> GetLines(string appId, string appKey, string ids);

        /// <summary>
        /// Gets lines that serve the given modes
        /// </summary>
        /// <param name="modes"> A comma-separated list of modes e.g. tube,dlr </param>
        [Get("/Line/Mode/{modes}?app_id={appId}&app_key={appKey}")]
        Task<IReadOnlyCollection<Line>> GetLinesByMode(string appId, string appKey, string modes);

        /// <summary>
        /// Get all valid routes for all lines, including the name and id of the originating and terminating stops for each route
        /// </summary>
        /// <param name="serviceTypes"> A comma separated list of service types to filter on. Supported values: Regular, Night. Defaulted to 'Regular' if not specified </param>
        [Get("/Line/Route?app_id={appId}&app_key={appKey}&serviceTypes={serviceTypes}")]
        Task<IReadOnlyCollection<Line>> GetAllRoutesForAllLines(string appId, string appKey, string serviceTypes);

        /// <summary>
        /// Get all valid routes for given line ids, including the name and id of the originating and terminating stops for each route
        /// </summary>
        /// <param name="ids"> A comma-separated list of line ids e.g. victoria,circle,N133. Max. approx. 20 ids </param>
        /// <param name="serviceTypes"> A comma separated list of service types to filter on. Supported values: Regular, Night. Defaulted to 'Regular' if not specified </param>
        [Get("/Line/{ids}/Route?app_id={appId}&app_key={appKey}&serviceTypes={serviceTypes}")]
        Task<IReadOnlyCollection<Line>> GetAllRoutesByLineId(string appId, string appKey, string ids, string serviceTypes);

        /// <summary>
        /// Gets all lines and their valid routes for given modes, including the name and id of the originating and terminating stops for each route
        /// </summary>
        /// <param name="modes"> A comma-separated list of modes e.g. tube,dlr </param>
        /// <param name="serviceTypes"> A comma separated list of service types to filter on. Supported values: Regular, Night. Defaulted to 'Regular' if not specified </param>
        [Get("/Line/Mode/{modes}/Route?app_id={appId}&app_key={appKey}&serviceTypes={serviceTypes}")]
        Task<IReadOnlyCollection<Line>> GetRoutesAndLinesForModes(string appId, string appKey, string modes, string serviceTypes);


        /// <summary>
        /// Gets all valid routes for given line id, including the sequence of stops on each route
        /// </summary>
        /// <param name="id">A single line id e.g. victoria</param>
        /// <param name="direction">The direction of travel. Can be inbound or outbound</param>
        /// <param name="excludeCrowding">That excludes crowding from line disruptions. Can be true or false</param>
        /// <param name="serviceTypes"> A comma separated list of service types to filter on. Supported values: Regular, Night. Defaulted to 'Regular' if not specified </param>
        [Get("/Line/{id}/Route/Sequence/{direction}?app_id={appId}&app_key={appKey}&excludeCrowding={excludeCrowding}&serviceTypes={serviceTypes}")]
        Task<RouteSequence> GetRoutesAndSequenceForLineId(string appId, string appKey, string id, string direction, bool excludeCrowding, string serviceTypes);


        /// <summary>
        /// Gets the line status for given line ids during the provided dates e.g Minor Delays
        /// </summary>
        /// <param name="ids"> A comma-separated list of line ids e.g. victoria,circle,N133. Max. approx. 20 ids </param>
        /// <param name="startDate">Start date</param>
        /// <param name="detail">Include details of the disruptions that are causing the line status including the affected stops and routes</param>
        /// <param name="endDate">End date</param>
        [Get("/Line/{ids}/Status/{startDate}/to/{endDate}?app_id={appId}&app_key={appKey}&detail={detail}")]
        Task<IReadOnlyCollection<Line>> GetLineStatus(string appId, string appKey, string ids, string startDate, string endDate, bool detail);




    }
}
