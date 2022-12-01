using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Services
{
    internal class UserService:User
    {
        public void ShareStatus(Status value)
        {
            Statuses.Add(value);

        }
        public int GetStatusById(int? Id)
        {

            return
    
    }
        public void List<Status>  GetAllStatuses()
        {
            List<Status> results = Status.FindAll();
            if (results.Count != 0)
            {
                return results;
            }
            else
            {
                Console.WriteLine("\nNo found.");
                return
        }
            public void FilterStatusByDate(DateTime time)
            {
                return
            }

        }
    }
