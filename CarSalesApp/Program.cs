using CarSalesApp.Data;
// Method to display list of cars
static void displayCars(List<Car> cars)
{
    foreach (Car car in cars)
    {
        Console.WriteLine(car);
    }
}
// Connect and open database
using var db = new CarSalesDbContext();
// Load all car records from database
var cars = db.Cars.ToList();
// Display all car records from memory list
displayCars(cars);