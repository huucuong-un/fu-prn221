using Microsoft.AspNetCore.Mvc;
using DiamondPlaze.BusinessObject.Models;
using DiamondPlaze.Service;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.Data;

namespace DiamondPlaze.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : BaseController<Account>
    {
        private readonly IBaseService<Account> _accountService;

        public AccountController(IBaseService<Account> accountService) : base(accountService)
        {
            _accountService = accountService;
        }

      

        [HttpGet("get_all_accounts")]
        public async Task<ActionResult<IEnumerable<Account>>> GetAllAccounts()
        {
            try
            {
                var accounts = await _accountService.GetAllAsync();
                return Ok(accounts);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("get_account_by_id/{id}")]
        public async Task<ActionResult<Account>> GetAccountById(Guid id)
        {
            return await GetById(id);
        }

        [HttpPost("create_account")]
        public async Task<ActionResult<Account>> CreateAccount(Account account)
        {
            return await Create(account);
        }

        [HttpPut("update_account/{id}")]
        public async Task<IActionResult> UpdateAccount(Guid id, Account account)
        {
            return await Update(id, account);
        }

        [HttpDelete("delete_account/{id}")]
        public async Task<IActionResult> DeleteAccount(Guid id)
        {
            return await Delete(id);
        }
        
        
        /*[HttpPost("login")]
      [AllowAnonymous]
      public async Task<ActionResult<ObjectModelResponse>> Login(LoginRequest model)
      {
          try
          {
              // Assuming you have a login method in your service
              var response = await _accountService.LoginAsync(model);
              return Ok(response);
          }
          catch (Exception ex)
          {
              return BadRequest(ex.Message);
          }
      }*/

        /*[HttpPut("change_password/{id}")]
        public async Task<IActionResult> ChangePassword(Guid id, ChangePasswordRequest model)
        {
            try
            {
                // Assuming you have a change password method in your service
                await _accountService.ChangePasswordAsync(id, model);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }*/
    }
}
