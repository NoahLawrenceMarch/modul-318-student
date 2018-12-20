using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SwissTransport
{
    [TestClass]
    public class TransportTest
    {
        private ITransport testee;

        [TestMethod]
        public void Locations()
        {
            testee = new Transport();
            var stations = testee.GetStations("Adligenswil,");

            Assert.AreEqual(10, stations.StationList.Count);
        }

        [TestMethod]
        public void StationBoard()
        {
            testee = new Transport();
            var stationBoard = testee.GetStationBoard("Adligenswil", "8502007");

            Assert.IsNotNull(stationBoard);
        }

        // Datum und uhrzeit
        [TestMethod]
        public void Connections()
        {
            testee = new Transport();
            var connections = testee.GetConnections("Adligenswil", "Luzern", "20.12.2018", "15.20:00");

            Assert.IsNotNull(connections);
        }
    }
}
