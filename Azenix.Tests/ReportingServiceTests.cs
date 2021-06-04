using System;
using System.Collections.Generic;
using System.Text;
using Azenix.Repository;
using Azenix.Services;
using FluentAssertions;
using NSubstitute;
using Xunit;

namespace Azenix.Tests
{
    public class ReportingServiceTests
    {
        private readonly IReportingService _reportingService;
        private readonly IRepository _mockRepository;

        public ReportingServiceTests()
        {
            _mockRepository = Substitute.For<IRepository>();
            _mockRepository.GetLogFileEntries().Returns(TestDataGenerator.GetMockLogEntries());

            _reportingService = new ReportingService(_mockRepository, new LogParsingService());
        }

        [Fact]
        public void GetNumUniqueIPAddresses_ReturnsCorrectResult()
        {
            var result = _reportingService.GetNumUniqueIPAddresses();
            result.Should().Be(5);
        }

        [Fact]
        public void GetTopNMostActiveIPs_ReturnsCorrectResult()
        {
            var result = _reportingService.GetTopNMostActiveIPs(3);
            result.Count.Should().Be(3);

            result[0].Should().Be(TestDataGenerator.ClientIP1);
            result[1].Should().Be(TestDataGenerator.ClientIP5);
            result[2].Should().Be(TestDataGenerator.ClientIP3);
        }

        [Fact]
        public void GetTopNVisitedUrls_ReturnsCorrectResult()
        {
            var result = _reportingService.GetTopNVisitedUrls(3);
            result.Count.Should().Be(3);

            result[0].Should().Be(TestDataGenerator.Url4);
            result[1].Should().Be(TestDataGenerator.Url1);
            result[2].Should().Be(TestDataGenerator.Url5);
        }
    }
}
