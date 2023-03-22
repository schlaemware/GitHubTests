namespace Domain.Test {
    [TestClass]
    public class ExampleServiceTests {
        [TestMethod]
        [DataRow(2, 3)]
        [DataRow(5, 0)]
        public void AdditionTest(int source, int toAdd) {
            ExampleService service = new();

            int result = service.Addition(source, toAdd);

            Assert.AreEqual(result, 0);
        }
    }
}