using ApiIdentityEndpoint.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ApiIdentityEndpoint.Data;

public class AppDbContext(DbContextOptions options) 
    : IdentityDbContext<User>(options);


