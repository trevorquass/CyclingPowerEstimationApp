using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CyclingPowerEstimation
{
    public class Geolocation
    {
        public string Country = null;
        public string City = null;

        public Geolocation() { }
        public Geolocation(string country, string city)
        {
            Country = country;
            City = city;
        }

        public static Geolocation GetLocation()
        {
            return GetLocation("");
        }

        public static Geolocation GetLocation(string ipAddress)
        {
            try
            {
                string ipUrl = "http://checkip.dyndns.org";
                string geoUrl = "http://smart-ip.net/geoip-xml";

                Match match;
                if (ipAddress == null || ipAddress == "")
                {
                    using (WebClient webClient = new WebClient())
                    {
                        ipAddress = webClient.DownloadString(ipUrl);
                        match = Regex.Match(ipAddress, @"\:\s+([^<]+)", RegexOptions.IgnoreCase);
                        if (match.Success)
                        {
                            ipAddress = match.Groups[1].Value;
                        }
                    }
                }
            
                var location = new Geolocation();

                using (WebClient webClient = new WebClient())
                {
                    var data = webClient.DownloadString(geoUrl + ipAddress);
                    
                    match = Regex.Match(data, @"countryName>([^<]+)", RegexOptions.IgnoreCase);
                    if (match.Success)
                    {
                        location.Country = match.Groups[1].Value;
                    }

                    match = Regex.Match(data, @"city>([^<]+)", RegexOptions.IgnoreCase);
                    if (match.Success)
                    {
                        location.City = match.Groups[1].Value;
                    }

                    if (location.City == null && location.Country == null)
                    {
                        return null;
                    }
                    return location;
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
