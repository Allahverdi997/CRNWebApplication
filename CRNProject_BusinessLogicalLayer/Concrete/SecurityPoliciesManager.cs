using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRNProject_BusinessLogicalLayer.Abstract;
using CRNProject_DataAccessLayer.Abstract;
using CRNProject_Entities.Concrete;

namespace CRNProject_BusinessLogicalLayer.Concrete
{
    public class SecurityPoliciesManager : ISecurityPoliciesService
    {
        public ISecurityPoliciesDal securityPoliciesDal { get; set; }

        public SecurityPoliciesManager(ISecurityPoliciesDal _securityPoliciesDal)
        {
            securityPoliciesDal = _securityPoliciesDal;
        }
        public async Task<bool> Add(SecurityPolicies entity)
        {
            return await securityPoliciesDal.Add(entity);
        }

        public async Task<bool> Delete(int id)
        {
            SecurityPolicies entity = await securityPoliciesDal.Get(x => x.Id == id);
            var result = await securityPoliciesDal.Delete(entity);
            return result == true ? true : false;
        }

        public async Task<List<SecurityPolicies>> GetAll()
        {
            return await securityPoliciesDal.GetAll();
        }

        public async Task<SecurityPolicies> GetWithID(int id)
        {
            return await securityPoliciesDal.Get(x => x.Id == id);
        }

        public async Task<bool> SaveChanges()
        {
            return await securityPoliciesDal.SaveChanges();
        }

        public async Task<bool> Update(SecurityPolicies entity)
        {
            return await securityPoliciesDal.Update(entity);
        }
    }
}
