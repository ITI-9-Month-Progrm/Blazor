using Microsoft.AspNetCore.Components;
using Model_Libraries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task03.Services;

namespace Task03.Pages.Lab02
{
    public partial class UpdateTrainee
    {
        [Parameter]
        public int Trainee_Id { get; set; }

        Trainee traineeEdited;

        [Inject]
        public ITraineeDataService traineeDataService { get; set; }

        protected bool Saved;

        //used to show state of form
        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;

        protected override async Task OnInitializedAsync()
        {
            traineeEdited = await traineeDataService.GetTrainee(Trainee_Id);

            if (traineeEdited == null) //new employee is being created
            {
                //add some defaults
                traineeEdited = new Trainee ();
            }
        }

        public void HandleValidSubmit()
        {
            Saved = false;

            if (traineeEdited.Trainee_ID == 0) //new
            {

                traineeDataService.postTrainee(traineeEdited);

                StatusClass = "alert-success";
                Message = "New employee added successfully.";
                Saved = true;
            }
            else //edit existing
            {
                traineeDataService.putTrainee(Trainee_Id,traineeEdited);

                StatusClass = "alert-success";
                Message = "Employee updated successfully.";
                Saved = true;
            }
        }

        protected void HandleInvalidSubmit()
        {
            StatusClass = "alert-danger";
            Message = "There are some validation errors. Please try again.";
        }

    }
}
