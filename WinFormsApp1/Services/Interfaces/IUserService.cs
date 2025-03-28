using WinFormsApp1.Entity;
using WinFormsApp1.Dto;
    
namespace WinFormsApp1.Services.Interfaces;

public interface User
{
    Task<User> Create(UsersDto Dto);
}