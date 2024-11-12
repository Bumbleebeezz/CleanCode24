using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersices.mock_sample
{
    public class MockSampleService
    {
        private readonly IMockRepository _mockRepository;
        public MockSampleService(IMockRepository mockRepository)
        {
            _mockRepository = mockRepository;
        }

        public string GetItem(int id)
        {
            return _mockRepository.Get(id);
        }
        public void DeleteItem(int id) 
        { 
            _mockRepository.Delete(id); 
        }
        public void AddItem(int id)
        {
            _mockRepository.Add(id);
        }
    }
}
