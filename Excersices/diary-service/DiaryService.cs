using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersices.diary_service
{
    public class DiaryService
    {
        private readonly IDiaryRepository _diaryRepository;
        public DiaryService(IDiaryRepository diaryRepository)
        {
            _diaryRepository = diaryRepository;
        }

        public string GetNotes(int id)
        {
            return _diaryRepository.Get(id);
        }
        public void DeleteNotes(int id)
        {
            _diaryRepository.Delete(id);
        }
        public void AddNotes(int id)
        {
            _diaryRepository.Add(id);
        }
    }
}
