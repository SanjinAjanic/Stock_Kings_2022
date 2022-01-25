using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stock_Kings.ViewModels;

namespace Stock_Kings.Pages
{
    public class LoginModel : PageModel
    {
        private readonly SignInManager<IdentityUser> signInManager;

        [BindProperty]
        public Login Model { get; set; }

        public LoginModel(SignInManager<IdentityUser>signInManager)
        {


            this.signInManager = signInManager;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync(string returnUr1 = null)
        {
            if (ModelState.IsValid)
            {
              var identityResult = await signInManager.PasswordSignInAsync(Model.Email, Model.Password, Model.RememberMe, false) ;
                if (identityResult.Succeeded)
                {
                    if (returnUr1 == null || returnUr1 == "/")
                    {
                        return RedirectToPage("Index");
                    }
                    else
                    {
                        return RedirectToPage(returnUr1);
                    }
                }

                ModelState.AddModelError("", "Username or Password incorrect");
            }

            return Page();
        }
    }
}
