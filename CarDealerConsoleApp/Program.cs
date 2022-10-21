using CarDealer.DataAccess.Context;
using CarDealer.DataAccess.Model;
using CarDealer.DataAccess.Model.Repositories;
using CarDealer.DataAccess.UnitOfWork;

using (var context = new CarDealerContext())
{
    var unitOfWork = new UnitOfWork(context);
    var colorRepo = new ColorRepository(context);
    var brandRepo = new BrandRepository(context);
    var dealerRepo = new DealerRepository(context);
    var dealerCarRepo = new DealerCarRepository(context);
    var carRepo = new CarRepository(context);

    try
    {
        unitOfWork.BeginTransaction();

        var blackColor = new Color { Name = "Black" };
        colorRepo.Add(blackColor);

        var volvoBrand = new Brand { Name = "VOLVO" };
        brandRepo.Add(volvoBrand);

        var dealerVolvoSweeden = new Dealer { Name = "VOLVO Sweeden", Phone = "77772020322" };
        dealerRepo.Add(dealerVolvoSweeden);
        //int two = 2;
        //int zero = 0;
        //int errorresult = two / zero;
        var volvoS80Black = new Car { Brand = volvoBrand, Color = blackColor, Model = "S80" };
        carRepo.Add(volvoS80Black);

        var dealerCar = new DealerCar { Dealer = dealerVolvoSweeden, Price = 2000, Car = volvoS80Black };
        dealerCarRepo.Add(dealerCar);

        unitOfWork.CommitTransaction();
    }
    catch
    {
        Console.WriteLine("Error");
        unitOfWork.RollbackTransaction();
    }


}