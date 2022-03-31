using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NyaaNet.Enums;

namespace NyaaNet.Enums
{
    /// <summary>
    /// Parses enums to their mapped values.
    /// </summary>
    internal class EnumParsing
    {
        public static string ParseEndpoint(RouteEndpoints route)
        {
            return route switch
            {
                RouteEndpoints.All => "/all",
                RouteEndpoints.Anime => "/anime",
                RouteEndpoints.Manga => "/manga",
                RouteEndpoints.Audio => "/audio",
                RouteEndpoints.Pictures => "/pictures",
                RouteEndpoints.LiveAction => "/live_action",
                RouteEndpoints.Software => "/software",
                RouteEndpoints.ID => "/id",
                RouteEndpoints.User => "/user",
                _ => throw new ArgumentException("The passed enum value was invalid"),
            };
        }



    }
}
