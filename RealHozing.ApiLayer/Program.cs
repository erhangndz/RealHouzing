using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.BusinessLayer.Concrete;
using RealHouzing.Consume.ViewComponents.Default;
using RealHouzing.DataAccessLayer.Abstract;
using RealHouzing.DataAccessLayer.Concrete;
using RealHouzing.DataAccessLayer.EntityFramework;
using RealHouzing.EntityLayer.Concrete;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<Context>();
builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();

builder.Services.AddScoped<IProductDal, EfProductDal>();
builder.Services.AddScoped<IProductService, ProductManager>();

builder.Services.AddScoped<IWhatWeDoDal, EfWhatWeDoDal>();
builder.Services.AddScoped<IWhatWeDoService, WhatWeDoManager>();

builder.Services.AddScoped<IBuyLeaseDal, EfBuyLeaseDal>();
builder.Services.AddScoped<IBuyLeaseService, BuyLeaseManager>();

builder.Services.AddScoped<IBlogDal, EfBlogDal>();
builder.Services.AddScoped<IBlogService, BlogManager>();

builder.Services.AddScoped<IPostingDal, EfPostingDal>();
builder.Services.AddScoped<IPostingService, PostingManager>();

builder.Services.AddScoped<IServiceDal, EfServiceDal>();
builder.Services.AddScoped<IServiceService, ServiceManager>();

builder.Services.AddScoped<ITestimonialDal, EfTestimonialDal>();
builder.Services.AddScoped<ITestimonialService, TestimonialManager>();

builder.Services.AddScoped<IVideoandAboutDal, EfVideoandAboutDal>();
builder.Services.AddScoped<IVideoandAboutService, VideoandAboutManager>();

builder.Services.AddScoped<ISubscribeDal, EfSubscribeDal>();
builder.Services.AddScoped<ISubscribeService, SubscribeManager>();

builder.Services.AddScoped<IAboutDal, EfAboutDal>();
builder.Services.AddScoped<IAboutService, AboutManager>();

builder.Services.AddScoped<ITeamDal, EfTeamDal>();
builder.Services.AddScoped<ITeamService, TeamManager>();

builder.Services.AddScoped<IContactDal, EfContactDal>();
builder.Services.AddScoped<IContactService, ContactManager>();

builder.Services.AddScoped<IMessageDal, EfMessageDal>();
builder.Services.AddScoped<IMessageService, MessageManager>();









builder.Services.AddControllers();
builder.Services.AddControllersWithViews()
    .AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();


app.MapControllers();

app.Run();

app.UseStaticFiles();

app.UseEndpoints(endpoints =>
{
	endpoints.MapDefaultControllerRoute();
});