using NyaaNet.Enums.SortingParameters;
using NyaaNet.Enums.SubCategories;

namespace NyaaNet.Enums
{
    /// <summary>
    /// Parses enums to their mapped values.
    /// </summary>
    internal class EnumParsing
    {
        /// <summary>
        /// Parses an enum parameter to its mapped value.
        /// </summary>
        /// <param name="route"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static string ParseEnumValue(Enum route)
        {
            // Determine the type of enum for the route object (Probably a cleaner way to accomplish this...)
            if (route is RouteEndpoints endpoint)
                return ParseEndpoint(endpoint);

            else if (route is AnimeSubCategories animeSubCategory)
                return ParseAnimeSubCategory(animeSubCategory);

            else if (route is MangaSubCategories mangaSubCategory)
                return ParseMangaSubCategory(mangaSubCategory);

            else if (route is AudioSubCategories audioSubCategory)
                return ParseAudioSubCategory(audioSubCategory);

            else if (route is PictureSubCategories pictureSubCategory)
                return ParsePictureSubCategory(pictureSubCategory);

            else if (route is LiveActionCategories liveActionCategory)
                return ParseLiveActionSubCategory(liveActionCategory);

            else if (route is SoftwareCategories softwareSubCategory)
                return ParseSoftwareSubCategory(softwareSubCategory);

            else if (route is OrderMethods sortingOrder)
                return ParseSortingOrder(sortingOrder);

            else if (route is SortingMethods sortingMethod)
                return ParseSortingMethod(sortingMethod);

            else
                throw new ArgumentException("The passed enum value was invalid");
        }

        private static string ParseEndpoint(RouteEndpoints route)
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

        private static string ParseAnimeSubCategory(AnimeSubCategories animeSubCategory)
        {
            return animeSubCategory switch
            {
                AnimeSubCategories.amv => "/amv",
                AnimeSubCategories.eng => "/eng",
                AnimeSubCategories.nonEng => "/non-eng",
                AnimeSubCategories.raw => "/raw",
                _ => throw new ArgumentException("The passed enum value was invalid"),
            };
        }

        private static string ParseMangaSubCategory(MangaSubCategories mangaSubCategory)
        {
            return mangaSubCategory switch
            {
                MangaSubCategories.eng => "/eng",
                MangaSubCategories.nonEng => "/non-eng",
                MangaSubCategories.raw => "/raw",
                _ => throw new ArgumentException("The passed enum value was invalid"),
            };
        }

        private static string ParseAudioSubCategory(AudioSubCategories audioSubCategory)
        {
            return audioSubCategory switch
            {
                AudioSubCategories.lossy => "/lossy",
                AudioSubCategories.lossless => "/lossless",
                _ => throw new ArgumentException("The passed enum value was invalid"),
            };
        }

        private static string ParsePictureSubCategory(PictureSubCategories pictureSubCategory)
        {
            return pictureSubCategory switch
            {
                PictureSubCategories.photos => "/photos",
                PictureSubCategories.graphics => "/graphics",
                _ => throw new ArgumentException("The passed enum value was invalid"),
            };
        }

        private static string ParseLiveActionSubCategory(LiveActionCategories liveActionCategory)
        {
            return liveActionCategory switch
            {
                LiveActionCategories.promo => "/promo",
                LiveActionCategories.eng => "/eng",
                LiveActionCategories.nonEng => "/non-eng",
                LiveActionCategories.raw => "/raw",
                _ => throw new ArgumentException("The passed enum value was invalid"),
            };
        }

        private static string ParseSoftwareSubCategory(SoftwareCategories softwareCategory)
        {
            return softwareCategory switch
            {
                SoftwareCategories.application => "/application",
                SoftwareCategories.games => "/games",
                _ => throw new ArgumentException("The passed enum value was invalid"),
            };
        }

        private static string ParseSortingOrder(OrderMethods order)
        {
            return order switch
            {
                OrderMethods.Ascending => "asc",
                OrderMethods.Descending => "desc",
                _ => throw new ArgumentException("The passed enum value was invalid"),
            };
        }

        private static string ParseSortingMethod(SortingMethods sortingMethod)
        {
            return sortingMethod switch
            {
                SortingMethods.size => "size",
                SortingMethods.seeders => "seeders",
                SortingMethods.leechers => "leechers",
                SortingMethods.date => "date",
                SortingMethods.downloads => "downloads",
                _ => throw new ArgumentException("The passed enum value was invalid"),
            };
        }


        
    }
}
