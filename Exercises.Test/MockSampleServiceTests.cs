using Excersices.mock_sample;
using Moq;

namespace Exercises.Test
{
    public class MockSampleServiceTests
    {
        private readonly Mock<IMockRepository> _repositoryMock;
        private readonly MockSampleService _mockSampleService;

        public MockSampleServiceTests() 
        { 
            _repositoryMock = new Mock<IMockRepository>();
            _mockSampleService = new MockSampleService( _repositoryMock.Object );
        }

        [Fact]
        public void GetItem_WithValidId_ReturnsItem()
        {
            // Arrange
            int id = 1;
            string expectedItem = "test item";
            _repositoryMock.Setup(repo => repo.Get(id)).Returns( expectedItem );

            // Act
            var result = _mockSampleService.GetItem( id );

            // Assert
            Assert.Equal( expectedItem, result );
            _repositoryMock.Verify(repo => repo.Get(id), Times.Once());
        }
    }
}
