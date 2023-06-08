using FPT_Exchange_Data.DTO.Filters;
using FPT_Exchange_Data.DTO.Request.Post;
using FPT_Exchange_Data.DTO.Request.Put;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FPT_Exchange_Service.Implementations
{
    public interface IUserService
    {
        Task<IActionResult> GetUser(Guid id);
        Task<IActionResult> GetUsers(UserFilterModel filter);
        Task<IActionResult> RegisterCustomer(RegisterCustomerRequest request);
        Task<IActionResult> AddAvatar(Guid id, IFormFile file);
        Task<IActionResult> UpdateCustomer(Guid id, UpdateCustomerRequest request);
        Task<IActionResult> DeleteCustomer(Guid id);
    }
}
