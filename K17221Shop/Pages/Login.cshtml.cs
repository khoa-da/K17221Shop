using BusinessObject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace K17221Shop.Pages
{
    public class LoginModel : PageModel
    {

        //private readonly IUserService _userService;
        //public LoginModel(IUserService userService)
        //{
        //    _userService = userService;
        //}

        //[BindProperty]
        //public User user { get; set; } = default!;
        //public string ErrorMessage { get; private set; }

        //public IActionResult OnPost()
        //{

        //    if (!string.IsNullOrWhiteSpace(user.UserEmail) && !string.IsNullOrWhiteSpace(user.UserPassword))
        //    {
        //        try
        //        {
        //            var check = _userService.checkLogin(user.UserEmail, user.UserPassword);
        //            if (check != null)
        //            {
        //                if (check.Status != "Active    ")
        //                {
        //                    ErrorMessage = "You are not allowed access into system";
        //                    return Page();
        //                }
        //                if (check.UserRoleId.Equals(2))
        //                {
        //                    try
        //                    {
        //                        var cart = HttpContext.Session.GetString("cart");
        //                        if (cart != null)
        //                        {
        //                            HttpContext.Session.SetInt32("UserID", check.UserId);
        //                            return RedirectToPage("Cart");
        //                        }
        //                    }
        //                    catch
        //                    {
        //                        HttpContext.Session.SetInt32("UserID", check.UserId);
        //                        return RedirectToPage("Index");
        //                    }
        //                    HttpContext.Session.SetInt32("UserID", check.UserId);
        //                    return RedirectToPage("Index");
        //                }
        //                if(check.UserRoleId.Equals(1))
        //                {
        //                    return RedirectToPage("Admin/UserManagement/ShowUserList");
        //                }
        //            }
        //            ErrorMessage = "Incorect User Name or Password Please Try Again";
        //            return Page();
        //        }
        //        catch
        //        {
        //            ErrorMessage = "Incorect User Name or Password Please Try Again";
        //            return Page();
        //        }
        //    }
        //    return Page();
        //}
    }
}
