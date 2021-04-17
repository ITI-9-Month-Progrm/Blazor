using Microsoft.AspNetCore.Components;
using Model_Libraries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskDay01.Pages.Lab01
{
    public partial class TraineeUpdate
    {
        [Parameter]
        public int Trainee_ID { get; set; }

        List<Trainee> trainees;
        public Trainee traineeEdited;
        public bool saved;
        protected override Task OnInitializedAsync()
        {
           
            trainees = MyMocaData.trainees;

            traineeEdited = trainees.FirstOrDefault(T => T.Trainee_ID == Trainee_ID);


            return base.OnInitializedAsync();
        }
        public void HandleValidSubmit()
        {
            saved = false;

            if (traineeEdited.Trainee_ID == 0) //new
            {
                trainees.Add(traineeEdited);
            }
            else //edit existing
            {
                
                saved = true;
            }
        }
        protected void HandleInvalidSubmit()
        {
        }
    }
}
