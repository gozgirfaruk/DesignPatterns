using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.ChainOfResp
{
    public abstract class Employee
    {
        protected Employee NextApprover;
        public void SetNextApprover(Employee superVisor)
        {
            this.NextApprover = superVisor;
        }
        public abstract void ProcessRequest(CustomerProcessViewModel request);
    }
}
