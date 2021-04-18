using Model_Libraries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task03.Services
{
    public interface ITraineeDataService
    {
        Task<List<Trainee>> GetTrainees();
        Task<Trainee> GetTrainee(int traineeId);
        Task postTrainee(Trainee trainee);
        Task putTrainee(int traineeId, Trainee trainee);
        Task deleteTrainee(int traineeId);

    }
}
