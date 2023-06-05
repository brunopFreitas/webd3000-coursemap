using Microsoft.EntityFrameworkCore;
using w0448225CourseMap.Data;
using w0448225CourseMap.Models;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages(
    options => {
        options.Conventions.AuthorizeFolder("/AcademicYear");
        options.Conventions.AuthorizeFolder("/AdvisingAssignment");
        options.Conventions.AuthorizeFolder("/CourseOffering");
        options.Conventions.AuthorizeFolder("/Course");
        options.Conventions.AuthorizeFolder("/CourseOffering");
        options.Conventions.AuthorizeFolder("/CoursePrerequisite");
        options.Conventions.AuthorizeFolder("/Diploma");
        options.Conventions.AuthorizeFolder("/DiplomaYear");
        options.Conventions.AuthorizeFolder("/DiplomaYearSection");
        options.Conventions.AuthorizeFolder("/Instructor");
        options.Conventions.AuthorizeFolder("/Semester");
    }
);

    builder.Services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("NSCCCourseMapProdDB")));
        //options.UseSqlServer(builder.Configuration.GetConnectionString("NSCCCourseMapDevDB")));

    builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<ApplicationDbContext>();

var app = builder.Build();

using (var scope = app.Services.CreateScope()) {
    var services = scope.ServiceProvider;
    SeedData.Initialize(services);
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();