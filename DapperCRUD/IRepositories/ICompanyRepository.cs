using DapperCRUD.Entities;
using DapperCRUD.ViewModels;

namespace DapperCRUD.IRepositories
{
    public interface ICompanyRepository
    {
        public Task<IEnumerable<Company>> GetCompanies();
        public Task<Company> GetCompany(int id);
        public Task<Company> CreateCompany(CompanyVM company);
        public Task UpdateCompany(int id, CompanyVM company);
        public Task DeleteCompany(int id);
        public Task<Company> GetCompanyByEmployeeId(int id);
        public Task<Company> GetCompanyEmployeesMultipleResults(int id);
        public Task<List<Company>> GetCompaniesEmployeesMultipleMapping();

    }
}
