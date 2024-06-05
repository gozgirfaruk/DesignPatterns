using ChainOfResponsibility.DAL;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.ChainOfResp
{
    public class Treasurer : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel request)
        {
            ChainContext _context = new ChainContext();
            if (request.Amount <= 50000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount;
                customerProcess.Name = request.Name;
                customerProcess.Employee = "Veznedar - Ayşenur Öztürk";
                customerProcess.Description = "Para Çekme İşlemi Onaylandı";
                _context.CustomerProcesses.Add(customerProcess);
                _context.SaveChanges(); 
            }
            else if (NextApprover!=null) 
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount;
                customerProcess.Name = request.Name;
                customerProcess.Employee = "Veznedar - Ayşenur Öztürk";
                customerProcess.Description = "Para Çekme İşlemi Gerçekleştirilemedi. Şube Müdür Yardımcısına İletildi";
                _context.CustomerProcesses.Add(customerProcess);
                _context.SaveChanges();
                NextApprover.ProcessRequest(request);

            }
        }
    }
}
