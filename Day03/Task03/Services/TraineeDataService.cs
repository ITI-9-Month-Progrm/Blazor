using Model_Libraries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Task03.Services
{
    //Consume this API in your WebAssembly Blazor App
    public class TraineeDataService : ITraineeDataService
    {
        readonly HttpClient httpClient;
        public TraineeDataService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task deleteTrainee(int traineeId)
        {
            await httpClient.DeleteAsync("/api/Trainees/" + traineeId);
        }

        public async Task<Trainee> GetTrainee(int traineeId)
        {
            return await httpClient.GetFromJsonAsync<Trainee>("/api/Trainees/" + traineeId);
        }

        public async Task<List<Trainee>> GetTrainees()
        {
            return await httpClient.GetFromJsonAsync<List<Trainee>>("/api/Trainees");
        }

        public async Task postTrainee(Trainee trainee)
        {
            await httpClient.PostAsJsonAsync("/api/Trainees", trainee);
        }

        public async Task putTrainee(int traineeId, Trainee trainee)
        {
            await httpClient.PutAsJsonAsync("/api/Trainees/" + traineeId, trainee);
        }
    }
}
