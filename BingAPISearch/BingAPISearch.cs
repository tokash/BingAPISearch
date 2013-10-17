using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Services.Client;
using Bing;
using System.Web;

namespace BingAPISearch
{
    public class BingAPISearch
    {
        private static readonly string AzureMarketplaceKey = "DoJHF6GmHhiPmHf/KZoshxdYrKCD0yqebHhuWuSa/jg";
        private static readonly string AzureMarketplaceURI = "https://api.datamarket.azure.com/Bing/Search/";


        public List<Bing.WebResult> Search(string iQuery)
        {
            //var bing = new BingSearchContainer(new Uri())
            //                { Credentials = new NetworkCredential(AzureMarketplaceKey, AzureMarketplaceKey) };
            List<Bing.WebResult> bingResults = null;
            var bingContainer = new Bing.BingSearchContainer(new Uri(AzureMarketplaceURI));

            // Replace this value with your account key.
            var accountKey = AzureMarketplaceKey;

            // Configure bingContainer to use your credentials.
            bingContainer.Credentials = new NetworkCredential(accountKey, accountKey);

            var query = bingContainer.Web(iQuery, null, null, null, null, null, null, null);

            try
            {
                var results = query.Execute();
                bingResults = results.ToList<Bing.WebResult>();
            }
            catch (Exception ex)
            {

            }

            return bingResults;

        }
        
        
    }
}
