using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05
{
    internal class ParseURL
    {
        public static void ParseUrl(string url)
        {
            string protocol = "";
            string server = "";
            string resource = "";

            // Check if the URL starts with a protocol
            int protocolEnd = url.IndexOf("://");
            if (protocolEnd != -1)
            {
                protocol = url.Substring(0, protocolEnd);
                url = url.Substring(protocolEnd + 3); // Remove protocol part
            }

            // Now the remaining part of the URL will be [server]/[resource]
            int serverEnd = url.IndexOf('/');
            if (serverEnd != -1)
            {
                server = url.Substring(0, serverEnd);
                resource = url.Substring(serverEnd + 1); // Extract resource after '/'
            }
            else
            {
                server = url; // If no '/' is present, the entire remaining part is the server
            }

            // Output the parsed parts
            Console.WriteLine($"[protocol] = \"{protocol}\"");
            Console.WriteLine($"[server] = \"{server}\"");
            Console.WriteLine($"[resource] = \"{resource}\"");
        }
    }
}
