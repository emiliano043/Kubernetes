using ExploringActions;
using ExploringActions.Controllers;
using Microsoft.Extensions.Logging;
using Moq;

namespace TestExploringActions
{
    public class WeatherForecastControllerTest
    {
        [Fact]
        public void Test_WeatherForecastController()
        {
            var logger = new Mock<ILogger<WeatherForecastController>>();
            var controller = new WeatherForecastController(logger.Object);
            var result = controller.Get();
            Assert.NotNull(result);
            Assert.IsType<WeatherForecast[]>(result);
        }
    }
}