using CarDealer.DataAccess.Context;
using CarDealer.DataAccess.Model;
using CarDealer.DataAccess.Model.Repositories;

using (var ctx = new CarDealerContext())
{
    var BlackColor = new Color { ColorName = "black" };
    var RedColor = new Color { ColorName = "red" };

    var volkswagen = new Dealer { SupplierName = "Volkswagen", PhoneNumber = "12345678" };
    var MercedesBenz = new Dealer { SupplierName = "MercedesBenz", PhoneNumber = "454545454" };

    var mercedes = new CarModelName { CarModel = "Mercedes" };
    var audi = new CarModelName { CarModel = "Audi" };

    var mercedesE220 = new CarModel { Model = "E220", };
    var audiA6 = new CarModel { Model = "A6" };

    var blackMercedesE220 = new DealerCar { Qty = 1 };
    var redAudiA6 = new DealerCar { Qty =3 };

    var colorRepository = new ColorRepositiry(ctx);
    var dealerRepository = new DealerRepository(ctx);
    var carModelNameRepository = new CarModelNameRepository(ctx);

    var carModel= new CarModelRepository(ctx);
    var dealerCar = new DealerCarRepository(ctx);

    colorRepository.Add(BlackColor);
    colorRepository.Add(RedColor);
    dealerRepository.Add(volkswagen);
    dealerRepository.Add(MercedesBenz);
    carModelNameRepository.Add(mercedes);
    carModelNameRepository.Add(audi);
    carModel.Add(mercedesE220);
    carModel.Add(audiA6);
    dealerCar.Add(blackMercedesE220);
    dealerCar.Add(redAudiA6);
}