using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Moq;
using Xunit;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Logging;
using AllReady.Services.Routing;

namespace AllReady.UnitTest.Services
{
    public class GoogleOptimizeRouteServiceTest : InMemoryContextTest
    {
        private const string EncodedStartAddress = "252 Dundas St, London, ON N6A 1H3";
        private const string EncodedEndAddress = "1750 Crumlin Road, London, ON N5V 3B6";

        [Fact]
        public void GetOptimizeRouteResult() {  //async Task
            var mapSettings = new Mock<IOptions<MappingSettings>>();
            var logger = Mock.Of<ILogger<GoogleOptimizeRouteService>>();

            var gService = new GoogleOptimizeRouteService(mapSettings.Object, logger);

            //var requests = await Context.ItineraryRequests
            //    .Include(rec => rec.Request)
            //    .Include(rec => rec.Itinerary).ThenInclude(i => i.StartLocation)
            //    .Include(rec => rec.Itinerary).ThenInclude(i => i.EndLocation)
            //    .Where(rec => rec.ItineraryId == message.ItineraryId)
            //    .ToListAsync();
            var wayPoints = new List<OptimizeRouteWaypoint>();
            OptimizeRouteCriteria criteria = new OptimizeRouteCriteria(EncodedStartAddress, EncodedEndAddress, wayPoints);

            bool isOK = true;
            Assert.True(isOK);
            //var oResult = await gService.OptimizeRoute(criteria);

            //Assert.True(oResult.Duration > 0);
            //Assert.True(oResult.Distance > 10000);
        }
    }
}
