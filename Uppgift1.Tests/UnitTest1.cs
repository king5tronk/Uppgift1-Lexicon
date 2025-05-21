
namespace Uppgift1.Tests
{
    public class EmployeeTests
    {
        [Fact]
        public void Employee_Creates_WithCorrectValues()
        {
            // Arrange - testdata
            string expectedName = "Test";
            int expectedSalary = 12345;

            // Act - Employee-objektet
            var emp = new Employee(expectedName, expectedSalary);

            // Assert - kontrollera att värdena blev rätt
            Assert.Equal(expectedName, emp.Name);
            Assert.Equal(expectedSalary, emp.Salary);

            // TODO: Lägg till fler tester
        }
    }
}