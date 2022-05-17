using Microsoft.AspNetCore.SignalR;
using signalRd1.Models;
namespace signalRd1.Hubs
{
    public class Emp:Hub
    {
        context db;
        public Emp(context db)
        {
            this.db = db;
        }

        public void addEmp(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();

            Clients.All.SendAsync("whenAdd", employee);
        }


    }
}
