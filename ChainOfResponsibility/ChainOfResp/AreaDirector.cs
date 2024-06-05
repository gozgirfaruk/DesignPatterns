using ChainOfResponsibility.DAL;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.ChainOfResp
{
    public class AreaDirector : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel request)
        {
            ChainContext _context = new ChainContext();
            if (request.Amount <= 500000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount;
                customerProcess.Name = request.Name;
                customerProcess.Employee = "Bölge Müdürü - Ömer Faruk Gözegir";
                customerProcess.Description = "Para Çekme İşlemi Onaylandı";
                _context.CustomerProcesses.Add(customerProcess);
                _context.SaveChanges();
            }
            else
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount;
                customerProcess.Name = request.Name;
                customerProcess.Employee = "Bölge Müdürü - Ömer Faruk Gözegir";
                customerProcess.Description = "Para Çekme İşlemi Gerçekleştirilemedi.Günlük para çekme limiti aşıldığığı için daha sonra tekrar deneyiniz.";
                _context.CustomerProcesses.Add(customerProcess);
                _context.SaveChanges();

            }
        }
    }
}
