using Developer_Toolbox.Controllers;
using Developer_Toolbox.Data;
using Developer_Toolbox.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Xunit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

public class ApplicationUsersControllerTests
{
    /*
    private readonly Mock<UserManager<ApplicationUser>> _userManager;
    private readonly Mock<SignInManager<ApplicationUser>> _signInManager;
    private readonly Mock<ApplicationDbContext> _dbContext;
    private readonly Mock<IUserStore<ApplicationUser>> _userStore;
    private readonly Mock<RoleManager<IdentityRole>> _roleManager;

    public ApplicationUsersControllerTests()
    {
        _userStore = new Mock<IUserStore<ApplicationUser>>();
        _userManager = new Mock<UserManager<ApplicationUser>>(_userStore.Object, null, null, null, null, null, null, null, null);
        _signInManager = new Mock<SignInManager<ApplicationUser>>(_userManager.Object, Mock.Of<IHttpContextAccessor>(), Mock.Of<IUserClaimsPrincipalFactory<ApplicationUser>>(), null, null, null, null);
        _roleManager = new Mock<RoleManager<IdentityRole>>(
            Mock.Of<IRoleStore<IdentityRole>>(), null, null, null, null);

        _dbContext = new Mock<ApplicationDbContext>();
    }

    private void SetupUsers(ApplicationDbContext dbContext)
    {
        dbContext.ApplicationUsers.Add(new ApplicationUser { Id = "1", FirstName = "John", LastName = "Doe", Email = "john@example.com", UserName = "john@example.com" });
        dbContext.ApplicationUsers.Add(new ApplicationUser { Id = "2", FirstName = "Jane", LastName = "Smith", Email = "jane@example.com", UserName = "jane@example.com" });
        dbContext.SaveChanges();
    }
    /*

    [Fact]
    public async Task Index_WithNoSearch_ReturnsAllUsers()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TestDb").Options;
        using var context = new ApplicationDbContext(options);
        SetupUsers(context);

        var controller = new ApplicationUsersController(context, _userManager.Object,  _roleManager.Object, _signInManager.Object);

        // Act
        var result = await controller.Index(null);

        // Assert
        var viewResult = Assert.IsType<ViewResult>(result);
        var model = Assert.IsAssignableFrom<IEnumerable<ApplicationUser>>(viewResult.Model);
        Assert.Equal(2, model.Count());
    }

    [Fact]
    public async Task Edit_UserValid_ChangesAndSavesUser()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TestDb").Options;
        using var context = new ApplicationDbContext(options);
        SetupUsers(context);

        var controller = new ApplicationUsersController(context, _userManager.Object, _roleManager.Object, _signInManager.Object);
        var updatedUser = new ApplicationUser { Id = "1", FirstName = "John Updated", LastName = "Doe", Email = "john@example.com", UserName = "john@example.com" };

        // Act
        var result = await controller.Edit("1", updatedUser);

        // Assert
        Assert.IsType<RedirectToActionResult>(result);
        var user = context.ApplicationUsers.FirstOrDefault(u => u.Id == "1");
        Assert.Equal("John Updated", user.FirstName);
    }
    
    [Fact]
    public async Task Delete_UserExists_UserIsDeleted()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TestDb").Options;
        using var context = new ApplicationDbContext(options);
        SetupUsers(context);

        var controller = new ApplicationUsersController(context, _userManager.Object, _roleManager.Object, _signInManager.Object);

        // Act
        var result = await controller.Delete("1");

        // Assert
        Assert.IsType<RedirectToActionResult>(result);
        var user = context.ApplicationUsers.FirstOrDefault(u => u.Id == "1");
        Assert.Null(user);
    }
    */
}

