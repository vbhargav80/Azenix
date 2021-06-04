using Azenix.Services;
using FluentAssertions;
using Xunit;

namespace Azenix.Tests
{
    public class LogParsingServiceTests
    {

        private readonly ILogParsingService _logParsingService;

        public LogParsingServiceTests()
        {
            _logParsingService = new LogParsingService();
        }

        [Fact]
        public void ShouldParseValidLogFileEntry()
        {
            var logFileEntry = @"50.112.00.11 - admin [11/Jul/2018:17:33:01 +0200] ""GET /asset.css HTTP/1.1"" 200 3574 ""-"" ""Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/536.6 (KHTML, like Gecko) Chrome/20.0.1092.0 Safari/536.6""";
            var parsedLogEvent = _logParsingService.ParseLogEntry(logFileEntry);

            parsedLogEvent.ClientIp.Should().Be("50.112.00.11");
            parsedLogEvent.Uri.Should().Be("GET /asset.css HTTP/1.1");
            parsedLogEvent.HttpStatusCode.Should().Be("200");
            parsedLogEvent.NumBytes.Should().Be("3574");
            parsedLogEvent.Timestamp.Should().Be("11/Jul/2018:17:33:01 +0200");
            parsedLogEvent.UserAgent.Should().Be("Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/536.6 (KHTML, like Gecko) Chrome/20.0.1092.0 Safari/536.6");
        }

        [Fact]
        public void ShouldNotParseInvalidLogFileEntry()
        {
            var logFileEntry = @"50.112.00.11 - admin 11/Jul/2018:17:33:01 +0200] ""GET /asset.css HTTP/1.1"" 200 3574 ""-"" ""Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/536.6 (KHTML, like Gecko) Chrome/20.0.1092.0 Safari/536.6""";
            var parsedLogEvent = _logParsingService.ParseLogEntry(logFileEntry);

            parsedLogEvent.ClientIp.Should().BeEmpty();
            parsedLogEvent.Uri.Should().BeEmpty();
            parsedLogEvent.HttpStatusCode.Should().BeEmpty();
            parsedLogEvent.NumBytes.Should().BeEmpty();
            parsedLogEvent.Timestamp.Should().BeEmpty();
            parsedLogEvent.UserAgent.Should().BeEmpty();
        }
    }
}
