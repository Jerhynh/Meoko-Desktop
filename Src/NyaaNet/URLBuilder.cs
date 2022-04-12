using NyaaNet.Enums;
using NyaaNet.Enums.SortingParameters;
using System.Web;


namespace NyaaNet
{
    public class URLBuilder
    {


        /// <summary>
        /// The base url for the Nyaa.si API server.
        /// </summary>
        public string ServerURI { get; set; }

        /// <summary>
        /// The constructor for the URLBuilder class.
        /// </summary>
        /// <param name="serverURI"></param>
        public URLBuilder(string serverURI)
        {
            ServerURI = serverURI;

            if (ServerURI.EndsWith("/")) // strip '/' from rnd of URI to prevent URI mutilation.
                ServerURI = ServerURI[..(ServerURI.Length - 1)];
        }

        // To-Do: Implement filters argument
        // Additionally take all url parameters in the ctor and build a url with a Build method.

        /// <summary>
        /// 
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="searchQuery"></param>
        /// <returns></returns>
        public string BuildSearchURL(RouteEndpoints endpoint, string searchQuery)
        {
            return $"{ServerURI}{EnumParsing.ParseEnumValue(endpoint)}?q={HttpUtility.UrlEncode(searchQuery)}";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="SubCategory"></param>
        /// <param name="searchQuery"></param>
        /// <returns></returns>
        public string BuildSearchURL(RouteEndpoints endpoint, Enum SubCategory, string searchQuery)
        {
            return $"{ServerURI}{EnumParsing.ParseEnumValue(endpoint)}{EnumParsing.ParseEnumValue(SubCategory)}?q={HttpUtility.UrlEncode(searchQuery)}";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="searchQuery"></param>
        /// <param name="sortingMethod"></param>
        /// <returns></returns>
        public string BuildSearchURL(RouteEndpoints endpoint, string searchQuery, SortingMethods sortingMethod)
        {
            return $"{ServerURI}{EnumParsing.ParseEnumValue(endpoint)}?q={HttpUtility.UrlEncode(searchQuery)}&s={EnumParsing.ParseEnumValue(sortingMethod)}";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="SubCategory"></param>
        /// <param name="searchQuery"></param>
        /// <param name="sortingMethod"></param>
        /// <returns></returns>
        public string BuildSearchURL(RouteEndpoints endpoint, Enum SubCategory, string searchQuery, SortingMethods sortingMethod)
        {
            return $"{ServerURI}{EnumParsing.ParseEnumValue(endpoint)}{EnumParsing.ParseEnumValue(SubCategory)}?q={HttpUtility.UrlEncode(searchQuery)}&s={EnumParsing.ParseEnumValue(sortingMethod)}";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="searchQuery"></param>
        /// <param name="sortingMethod"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public string BuildSearchURL(RouteEndpoints endpoint, string searchQuery, SortingMethods sortingMethod, int page)
        {
            return $"{ServerURI}{EnumParsing.ParseEnumValue(endpoint)}?q={HttpUtility.UrlEncode(searchQuery)}&s={EnumParsing.ParseEnumValue(sortingMethod)}&p={page}";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="SubCategory"></param>
        /// <param name="searchQuery"></param>
        /// <param name="sortingMethod"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public string BuildSearchURL(RouteEndpoints endpoint, Enum SubCategory, string searchQuery, SortingMethods sortingMethod, int page)
        {
            return $"{ServerURI}{EnumParsing.ParseEnumValue(endpoint)}{EnumParsing.ParseEnumValue(SubCategory)}?q={HttpUtility.UrlEncode(searchQuery)}&s={EnumParsing.ParseEnumValue(sortingMethod)}&p={page}";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="searchQuery"></param>
        /// <param name="sortingMethod"></param>
        /// <param name="page"></param>
        /// <param name="sortOrder"></param>
        /// <returns></returns>
        public string BuildSearchURL(RouteEndpoints endpoint, string searchQuery, SortingMethods sortingMethod, int page, OrderMethods sortOrder)
        {
            return $"{ServerURI}{EnumParsing.ParseEnumValue(endpoint)}?q={HttpUtility.UrlEncode(searchQuery)}&s={EnumParsing.ParseEnumValue(sortingMethod)}&p={page}&o={EnumParsing.ParseEnumValue(sortOrder)}";
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="SubCategory"></param>
        /// <param name="searchQuery"></param>
        /// <param name="sortingMethod"></param>
        /// <param name="page"></param>
        /// <param name="sortOrder"></param>
        /// <returns></returns>
        public string BuildSearchURL(RouteEndpoints endpoint, Enum SubCategory, string searchQuery, SortingMethods sortingMethod, int page, OrderMethods sortOrder)
        {
            return $"{ServerURI}{EnumParsing.ParseEnumValue(endpoint)}{EnumParsing.ParseEnumValue(SubCategory)}?q={HttpUtility.UrlEncode(searchQuery)}&s={EnumParsing.ParseEnumValue(sortingMethod)}&p={page}&o={EnumParsing.ParseEnumValue(sortOrder)}";
        }
    }
}
