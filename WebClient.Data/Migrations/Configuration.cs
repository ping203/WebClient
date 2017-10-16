using System.Data.Common;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using WebClient.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using WebClient.Data;
using WebClient.Common;

internal sealed class Configuration : DbMigrationsConfiguration<WebClient.Data.WebClientDbContext>
{
    public Configuration()
    {
        AutomaticMigrationsEnabled = true;
    }

    protected override void Seed(WebClient.Data.WebClientDbContext context)
    {
        //CreateSlide(context);
        //  This method will be called after migrating to the latest version.
        CreatePage(context);
        CreateContactDetail(context);

        CreateConfigTitle(context);
        CreateFooter(context);
        CreateUser(context);

    }
    private void CreateConfigTitle(WebClientDbContext context)
    {

        if (!context.SYSTEMCONFIGs.Any(x => x.Code == "HomeTitle"))
        {
            context.SYSTEMCONFIGs.Add(new SYSTEMCONFIG()
            {
                Code = "HomeTitle",
                ValueString = "Trang chủ WebClient",

            });
        }
        if (!context.SYSTEMCONFIGs.Any(x => x.Code == "HomeMetaKeyword"))
        {
            context.SYSTEMCONFIGs.Add(new SYSTEMCONFIG()
            {
                Code = "HomeMetaKeyword",
                ValueString = "Trang chủ WebClient",

            });
        }
        if (!context.SYSTEMCONFIGs.Any(x => x.Code == "HomeMetaDescription"))
        {
            context.SYSTEMCONFIGs.Add(new SYSTEMCONFIG()
            {
                Code = "HomeMetaDescription",
                ValueString = "Trang chủ WebClient",

            });
        }
    }
    private void CreateUser(WebClientDbContext context)
    {
        var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new WebClientDbContext()));

        var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new WebClientDbContext()));

        var user = new ApplicationUser()
        {
            //Email truong: daihoctg@tgu.edu.vn
            UserName = "TienGiangUniversity",
            Email = "tuyetnhi2908@gmail.com",
            EmailConfirmed = true,
            BirthDay = DateTime.Now,
            FullName = "Technology Education"

        };
        if (manager.Users.Count(x => x.UserName == "tedu") == 0)
        {
            manager.Create(user, "123654$");

            if (!roleManager.Roles.Any())
            {
                roleManager.Create(new IdentityRole { Name = "Admin" });
                roleManager.Create(new IdentityRole { Name = "User" });
            }

            var adminUser = manager.FindByEmail("tuyetnhi2908@gmail.com");

            manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });
        }

    }

    private void CreateFooter(WebClientDbContext context)
    {
        if (context.FOOTERs.Count(x => x.ID == CommonConstants.DefaultFooterId) == 0)
        {
            string content = "Footer";
            context.FOOTERs.Add(new FOOTER()
            {
                ID = CommonConstants.DefaultFooterId,
                Content = content
            });
            context.SaveChanges();
        }
    }

    //private void CreateSlide(WebClientDbContext context)
    //{
    //    if (context.SLIDEs.Count() == 0)
    //    {
    //        List<SLIDE> listSlide = new List<SLIDE>()
    //        {
    //            new SLIDE() {
    //                Name ="Slide 1",
    //                DisplayOrder =1,
    //                Status =true,
    //                Url ="#",
    //                Image ="/Assets/client/images/bag.jpg",
    //                Content =@"	<h2>FLAT 50% 0FF</h2>
    //                        <label>FOR ALL PURCHASE <b>VALUE</b></label>
    //                        <p>Lorem ipsum dolor sit amet, consectetur 
    //                    adipisicing elit, sed do eiusmod tempor incididunt ut labore et </ p >
    //                <span class=""on-get"">GET NOW</span>" },
    //            new SLIDE() {
    //                Name ="Slide 2",
    //                DisplayOrder =2,
    //                Status =true,
    //                Url ="#",
    //                Image ="/Assets/client/images/bag1.jpg",
    //            Content=@"<h2>FLAT 50% 0FF</h2>
    //                        <label>FOR ALL PURCHASE <b>VALUE</b></label>

    //                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et </ p >

    //                        <span class=""on-get"">GET NOW</span>"},
    //        };
    //        context.SLIDEs.AddRange(listSlide);
    //        context.SaveChanges();
    //    }
    //}

    private void CreatePage(WebClientDbContext context)
    {
        if (context.PAGEs.Count() == 0)
        {
            try
            {
                var page = new PAGE()
                {
                    Name = "Giới thiệu",
                    Alias = "gioi-thieu",
                    PContent = @"Trường Đại học Tiền Giang mong muốn được hợp tác với các tổ chức, cá nhân trong và ngoài nước
về giáo dục, đào tạo, nghiên cứu, ứng dụng và chuyển giao khoa học - công nghệ.",
                    Status = true

                };
                context.PAGEs.Add(page);
                context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    Trace.WriteLine($"Entity of type \"{eve.Entry.Entity.GetType().Name}\" in state \"{eve.Entry.State}\" has the following validation error.");
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Trace.WriteLine($"- Property: \"{ve.PropertyName}\", Error: \"{ve.ErrorMessage}\"");
                    }
                }
            }

        }
    }

    private void CreateContactDetail(WebClientDbContext context)
    {
        if (context.ContactDetails.Count() == 0)
        {
            try
            {
                var contactDetail = new WebClient.Model.Models.ContactDetail()
                {
                    Name = "Trường đại học Tiền Giang",
                    Address = "119 Ấp Bắc - Phường 05 - Thành phố Mỹ Tho - Tỉnh Tiền Giang.",
                    Email = "daihoctg@tgu.edu.vn",
                    Lat = 37.0625,
                    Lng = 95.677068,
                    Phone = "0273 3 872 624 - 0273 6 250 200",
                    Website = "https://tgu.edu.vn",
                    Other = "",
                    Status = true

                };
                context.ContactDetails.Add(contactDetail);
                context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    Trace.WriteLine($"Entity of type \"{eve.Entry.Entity.GetType().Name}\" in state \"{eve.Entry.State}\" has the following validation error.");
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Trace.WriteLine($"- Property: \"{ve.PropertyName}\", Error: \"{ve.ErrorMessage}\"");
                    }
                }
            }

        }
    }
}