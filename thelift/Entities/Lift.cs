using System;
using System.Collections.Generic;
using System.Text;

namespace Lift.Entities
{
    public class Lift
    {
        public int Capacity { get; set; }
        public List<Person> People { get; set; }
        public int CurrentFloor { get; set; }

        public Lift(int capacity)
        {
            this.CurrentFloor = 0;
            this.Capacity = capacity;
            
            Floor floor = new Floor();
            Person person = new Person();
        }
        // this function will act as a command to call the lift in which direction 

        




        public void LiftOperation( Direction direction){
            if(direction == direction.movingUp){
                MoveUp();
            }
            else if(direction == direction.movingDown){
                MoveDown();
            }
        }




        private void MoveUp()
        {
            this.CurrentFloor = this.CurrentFloor + 1;
            People.Add(person.DestinationFloor);
  //          floor.PeopleWaitingForLift -=1;    
        }

        private void MoveDown()
        {
            this.CurrentFloor = this.CurrentFloor -1;
            
            People.Add(person.DestinationFloor);
//            floor.PeopleWaitingForLift -=1;
        }
    }
}
