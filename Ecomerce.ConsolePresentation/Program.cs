// See https://aka.ms/new-console-template for more information
using Ecomerce.Aplication.Abstractions;
using Ecomerce.Aplication.RealEstates.Create;
using Ecomerce.Aplication.Users.Create;
using Ecomerce.Aplication.Users.Queries;
using Ecomerce.Aplication.Vehicles.Create;
using Ecomerce.Infrastructure;
using MediatR;
using Microsoft.Extensions.DependencyInjection;



var diContainer = new ServiceCollection()
    .AddSingleton<IVehicleRepository, VehicleRepository>()
    .AddSingleton<IRealEstateRepository, RealEstateRepository>()
    .AddSingleton<IUserRepository, UserRepository>()
    .AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(IUserRepository).Assembly))
    .BuildServiceProvider();
    

var mediator = diContainer.GetRequiredService<IMediator>();

var newUser = await mediator.Send(new CreateUser("Alan"));
var newVehicle = await mediator.Send(new CreateVehicle("Escape", "Ford", 15000));
var ewRealEstate = await mediator.Send(new CreateRealEstate("Apartment", "New York", 100000));
var user = await mediator.Send(new GetUserById(1));

Console.WriteLine($"User: {user.Name}");
