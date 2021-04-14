using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRNProject_Entities.Concrete;

namespace CRNProject_BusinessLogicalLayer.Abstract
{
    public interface ISecurityPoliciesService
    {
        Task<List<SecurityPolicies>> GetAll();
        Task<SecurityPolicies> GetWithID(int id);
        Task<bool> Add(SecurityPolicies entity);
        Task<bool> Update(SecurityPolicies entity);
        Task<bool> Delete(int id);
        Task<bool> SaveChanges();
    }
}
