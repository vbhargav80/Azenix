using System;
using System.Collections.Generic;
using System.Text;

namespace Azenix.Tests
{
    public class TestDataGenerator
    {
        public const String ClientIP1 = "100.0.0.1";
        public const String ClientIP2 = "100.0.0.2";
        public const String ClientIP3 = "100.0.0.3";
        public const String ClientIP4 = "100.0.0.4";
        public const String ClientIP5 = "100.0.0.5";

        public const String Url1 = "GET /page1 HTTP/1.1";
        public const String Url2 = "GET /page2 HTTP/1.1";
        public const String Url3 = "GET /page3 HTTP/1.1";
        public const String Url4 = "GET /page4 HTTP/1.1";
        public const String Url5 = "GET /page5 HTTP/1.1";

        public static List<string> GetMockLogEntries()
        {
            var logEntries = new List<string>();

            logEntries.Add($"{ClientIP1} - - [11/Jul/2018:17:33:01 +0200] \"{Url1}\" 200 3574 \"-\" \"Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/536.6 (KHTML, like Gecko) Chrome/20.0.1092.0 Safari/536.6\"");
            logEntries.Add($"{ClientIP1} - - [11/Jul/2019:17:33:01 +0200] \"{Url4}\" 200 3574 \"-\" \"Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/536.6 (KHTML, like Gecko) Chrome/20.0.1092.0 Safari/536.6\"");
            logEntries.Add($"{ClientIP1} - - [11/Jul/2019:17:33:01 +0200] \"{Url5}\" 200 3574 \"-\" \"Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/536.6 (KHTML, like Gecko) Chrome/20.0.1092.0 Safari/536.6\"");
            logEntries.Add($"{ClientIP1} - - [11/Jul/2019:18:33:01 +0200] \"{Url1}\" 200 3574 \"-\" \"Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/536.6 (KHTML, like Gecko) Chrome/20.0.1092.0 Safari/536.6\"");
            logEntries.Add($"{ClientIP1} - - [11/Jul/2019:18:33:01 +0200] \"{Url3}\" 200 3574 \"-\" \"Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/536.6 (KHTML, like Gecko) Chrome/20.0.1092.0 Safari/536.6\"");

            logEntries.Add($"{ClientIP2} - - [11/Jul/2019:17:33:01 +0200] \"{Url4}\" 200 3574 \"-\" \"Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/536.6 (KHTML, like Gecko) Chrome/20.0.1092.0 Safari/536.6\"");
            logEntries.Add($"{ClientIP2} - - [11/Jul/2018:17:33:01 +0200] \"{Url1}\" 200 3574 \"-\" \"Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/536.6 (KHTML, like Gecko) Chrome/20.0.1092.0 Safari/536.6\"");

            logEntries.Add($"{ClientIP3} - - [11/Jul/2019:18:33:01 +0200] \"{Url5}\" 200 3574 \"-\" \"Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/536.6 (KHTML, like Gecko) Chrome/20.0.1092.0 Safari/536.6\"");
            logEntries.Add($"{ClientIP3} - - [11/Jul/2018:17:33:01 +0200] \"{Url1}\" 200 3574 \"-\" \"Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/536.6 (KHTML, like Gecko) Chrome/20.0.1092.0 Safari/536.6\"");
            logEntries.Add($"{ClientIP3} - - [11/Jul/2018:17:33:01 +0200] \"{Url4}\" 200 3574 \"-\" \"Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/536.6 (KHTML, like Gecko) Chrome/20.0.1092.0 Safari/536.6\"");

            logEntries.Add($"{ClientIP4} - - [11/Jul/2018:17:33:01 +0200] \"{Url4}\" 200 3574 \"-\" \"Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/536.6 (KHTML, like Gecko) Chrome/20.0.1092.0 Safari/536.6\"");

            logEntries.Add($"{ClientIP5} - - [11/Jul/2018:17:33:01 +0200] \"{Url1}\" 200 3574 \"-\" \"Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/536.6 (KHTML, like Gecko) Chrome/20.0.1092.0 Safari/536.6\"");
            logEntries.Add($"{ClientIP5} - - [11/Jul/2019:17:33:01 +0200] \"{Url4}\" 200 3574 \"-\" \"Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/536.6 (KHTML, like Gecko) Chrome/20.0.1092.0 Safari/536.6\"");
            logEntries.Add($"{ClientIP5} - - [11/Jul/2019:17:33:01 +0200] \"{Url2}\" 200 3574 \"-\" \"Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/536.6 (KHTML, like Gecko) Chrome/20.0.1092.0 Safari/536.6\"");
            logEntries.Add($"{ClientIP5} - - [11/Jul/2019:18:33:01 +0200] \"{Url4}\" 200 3574 \"-\" \"Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/536.6 (KHTML, like Gecko) Chrome/20.0.1092.0 Safari/536.6\"");

            
            

            return logEntries;
        }
    }
}
