using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Domain.Model;
using Infrastructure.DataBase.Implementations;
using Infrastructure.EntityFramework;

namespace WebApp.Controllers
{
    public class OrdersController : Controller
    {
        private readonly EFUnitOfWork _uow;
        public OrdersController()
        {
            _uow = new EFUnitOfWork();
        }
        public ActionResult Index() => View(_uow.Orders.GetAll());
    }
}
