﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardTestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriesController : ControllerBase
    {
        [HttpGet]
        public string GetAll()
        {
            return "{" +
  "\"CategoryId\": 1, " +
  "\"CategoryName\": \"Beverages\", " +
  "\"Description\": \"Soft drinks, coffees, teas, beers, and ales\", " +
  "\"Products\": [" +
    "{" +
                "\"ProductId\": 1, " +
      "\"ProductName\": \"Chai\", " +
      "\"SupplierId\": 1, " +
      "\"CategoryId\": 1, " +
      "\"QuantityPerUnit\": \"10 boxes x 20 bags\", " +
      "\"UnitPrice\": 18.0000, " +
      "\"UnitsInStock\": 39, " +
      "\"UnitsOnOrder\": 0, " +
      "\"ReorderLevel\": 10, " +
      "\"Discontinued\": false, " +
      "\"Supplier\": null" +
    "}, " +
    "{" +
                "\"ProductId\": 2, " +
      "\"ProductName\": \"Chang\", " +
      "\"SupplierId\": 1, " +
      "\"CategoryId\": 1, " +
      "\"QuantityPerUnit\": \"24 - 12 oz bottles\", " +
      "\"UnitPrice\": 19.0000, " +
      "\"UnitsInStock\": 17, " +
      "\"UnitsOnOrder\": 40, " +
      "\"ReorderLevel\": 25, " +
      "\"Discontinued\": false, " +
      "\"Supplier\": null" +
"    }, " +
  "  {" +
                "\"ProductId\": 24, " +
      "\"ProductName\": \"Guaraná Fantástica\", " +
      "\"SupplierId\": 10, " +
      "\"CategoryId\": 1, " +
      "\"QuantityPerUnit\": \"12 - 355 ml cans\", " +
      "\"UnitPrice\": 4.5000, " +
      "\"UnitsInStock\": 20, " +
      "\"UnitsOnOrder\": 0, " +
      "\"ReorderLevel\": 0, " +
      "\"Discontinued\": true, " +
      "\"Supplier\": null" +

  "  }, " +
   " {" +
                "\"ProductId\": 34, " +
      "\"ProductName\": \"Sasquatch Ale\", " +
      "\"SupplierId\": 16, " +
      "\"CategoryId\": 1, " +
      "\"QuantityPerUnit\": \"24 - 12 oz bottles\", " +
      "\"UnitPrice\": 14.0000, " +
      "\"UnitsInStock\": 111, " +
      "\"UnitsOnOrder\": 0, " +
      "\"ReorderLevel\": 15, " +
      "\"Discontinued\": false, " +
      "\"Supplier\": null" +

  "  }, " +
  "  {" +
                "\"ProductId\": 35, " +
      "\"ProductName\": \"Steeleye Stout\", " +
      "\"SupplierId\": 16, " +
      "\"CategoryId\": 1, " +
      "\"QuantityPerUnit\": \"24 - 12 oz bottles\", " +
      "\"UnitPrice\": 18.0000, " +
      "\"UnitsInStock\": 20, " +
      "\"UnitsOnOrder\": 0, " +
      "\"ReorderLevel\": 15, " +
      "\"Discontinued\": false, " +
      "\"Supplier\": null" +
  "  }, " +
  "  {" +
                "\"ProductId\": 38, " +
      "\"ProductName\": \"Côte de Blaye\", " +
      "\"SupplierId\": 18, " +
      "\"CategoryId\": 1, " +
      "\"QuantityPerUnit\": \"12 - 75 cl bottles\", " +
      "\"UnitPrice\": 263.5000, " +
      "\"UnitsInStock\": 17, " +
      "\"UnitsOnOrder\": 0, " +
      "\"ReorderLevel\": 15, " +
      "\"Discontinued\": false, " +
      "\"Supplier\": null" +
    "}, " +
   " {" +
                "\"ProductId\": 39, " +
      "\"ProductName\": \"Chartreuse verte\", " +
      "\"SupplierId\": 18, " +
      "\"CategoryId\": 1, " +
      "\"QuantityPerUnit\": \"750 cc per bottle\", " +
      "\"UnitPrice\": 18.0000, " +
      "\"UnitsInStock\": 69, " +
      "\"UnitsOnOrder\": 0, " +
      "\"ReorderLevel\": 5, " +
      "\"Discontinued\": false, " +
      "\"Supplier\": null" +
   " }, " +
  "  {" +
                "\"ProductId\": 43, " +
      "\"ProductName\": \"Ipoh Coffee\", " +
      "\"SupplierId\": 20, " +
      "\"CategoryId\": 1, " +
      "\"QuantityPerUnit\": \"16 - 500 g tins\", " +
      "\"UnitPrice\": 46.0000, " +
      "\"UnitsInStock\": 17, " +
      "\"UnitsOnOrder\": 10, " +
      "\"ReorderLevel\": 25, " +
      "\"Discontinued\": false, " +
      "\"Supplier\": null" +
   " }, " +
 "   {" +
                "\"ProductId\": 67, " +
      "\"ProductName\": \"Laughing Lumberjack Lager\", " +
      "\"SupplierId\": 16, " +
      "\"CategoryId\": 1, " +
      "\"QuantityPerUnit\": \"24 - 12 oz bottles\", " +
      "\"UnitPrice\": 14.0000, " +
      "\"UnitsInStock\": 52, " +
      "\"UnitsOnOrder\": 0, " +
      "\"ReorderLevel\": 10, " +
      "\"Discontinued\": false, " +
      "\"Supplier\": null" +
   " }, " +
    "{" +
                "\"ProductId\": 70, " +
      "\"ProductName\": \"Outback Lager\", " +
      "\"SupplierId\": 7, " +
      "\"CategoryId\": 1, " +
      "\"QuantityPerUnit\": \"24 - 355 ml bottles\", " +
      "\"UnitPrice\": 15.0000, " +
      "\"UnitsInStock\": 15, " +
      "\"UnitsOnOrder\": 10, " +
      "\"ReorderLevel\": 30, " +
      "\"Discontinued\": false, " +
      "\"Supplier\": null" +
  "  }, " +
  "  {" +
                "\"ProductId\": 75, " +
      "\"ProductName\": \"Rhönbräu Klosterbier\", " +
      "\"SupplierId\": 12, " +
      "\"CategoryId\": 1, " +
      "\"QuantityPerUnit\": \"24 - 0.5 l bottles\", " +
      "\"UnitPrice\": 7.7500, " +
      "\"UnitsInStock\": 125, " +
      "\"UnitsOnOrder\": 0, " +
      "\"ReorderLevel\": 25, " +
      "\"Discontinued\": false, " +
      "\"Supplier\": null" +
   " }, " +
  "  {" +
                "\"ProductId\": 76, " +
      "\"ProductName\": \"Lakkalikööri\", " +
      "\"SupplierId\": 23, " +
      "\"CategoryId\": 1, " +
      "\"QuantityPerUnit\": \"500 ml\", " +
      "\"UnitPrice\": 18.0000, " +
      "\"UnitsInStock\": 57, " +
      "\"UnitsOnOrder\": 0, " +
      "\"ReorderLevel\": 20, " +
      "\"Discontinued\": false, " +
      "\"Supplier\": null" +

   " }" +
 " ]" +
"        }";
        }
    }
}