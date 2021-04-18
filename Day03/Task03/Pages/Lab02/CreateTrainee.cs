using Model_Libraries;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task03.Services;

namespace Task03.Pages.Lab02
{
    public partial class CreateTrainee
    {
        public Trainee newTrainee = new Trainee();
        public bool saved;
        //public List<Trainee> trainees;
        [Inject]
        public ITraineeDataService trainneeDataService { get; set; }
        public async void HandleValidSubmit()
        {
            await trainneeDataService.postTrainee(newTrainee);
          
        }
        protected void HandleInvalidSubmit()
        {
        }
    }
}
