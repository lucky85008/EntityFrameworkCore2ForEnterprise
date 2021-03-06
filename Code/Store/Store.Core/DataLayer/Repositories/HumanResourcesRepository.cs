using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Store.Core.DataLayer.Contracts;
using Store.Core.EntityLayer.HumanResources;

namespace Store.Core.DataLayer.Repositories
{
    public class HumanResourcesRepository : Repository, IHumanResourcesRepository
    {
        public HumanResourcesRepository(IUserInfo userInfo, StoreDbContext dbContext)
            : base(userInfo, dbContext)
        {
        }

        public IQueryable<Employee> GetEmployees(int pageSize = 10, int pageNumber = 1)
            => DbContext.Paging<Employee>(pageSize, pageNumber);

        public async Task<Employee> GetEmployeeAsync(Employee entity)
            => await DbContext.Set<Employee>().FirstOrDefaultAsync(item => item.EmployeeID == entity.EmployeeID);
    }
}
