using Model_Libraries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskDay01.Pages
{
    public partial class AddTrainee
    {
        public Trainee newTrainee = new Trainee();
        public bool saved;
        public List<Trainee> trainees = MyMocaData.trainees;
        public void HandleValidSubmit()
        {
            var lastID = trainees[trainees.Count() - 1];
            newTrainee.Trainee_ID = lastID.Trainee_ID + 1;
            trainees.Add(newTrainee);
        }
        protected void HandleInvalidSubmit()
        {
        }
    }
}
