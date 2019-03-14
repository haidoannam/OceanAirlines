using NC.OS.Data.Infrastructure;
using NC.OS.Data.Repositories;
using NC.OS.Entites;
using NC.OS.Model;
using NC.OS.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC.OS.Services.Services
{
    public class PriceSegment
    {
        public double Size { get; set; }

        public int Price { get; set; }
    }

    public class OrderService : IOrderService
    {
        private readonly IEntityBaseRepository<Order> _orderRepository;
        private readonly IEntityBaseRepository<Paths> _pathRepository;
        private readonly IUnitOfWork _unitOfWork;

        public OrderService(IEntityBaseRepository<Order> orderRepository, IEntityBaseRepository<Paths> pathRepository,IUnitOfWork unitOfWork)
        {
            _orderRepository = orderRepository;
            _pathRepository = pathRepository;
            _unitOfWork = unitOfWork;
        }

        public void SaveOrder(OrderModel orderModel)
        {
            var orders = _orderRepository.GetAll();
            var orderCode = string.Empty;
            if (orders.Any())
            {
                orderCode = $"OS-{orders.Count()}";
            }
            else
                orderCode = $"OS-1";

            var order = new Order
            {
                OrderCode = orderCode,
                SenderName = orderModel.Sender.Name,
                SenderPhone = orderModel.Sender.Phone,
                ReceiverName = orderModel.Receiver.Name,
                ReceiverPhone = orderModel.Receiver.Phone,
                ReveiverAddress = orderModel.Receiver.Address,
                Weight = orderModel.Package.Weight,
                Depth = orderModel.Package.Depth,
                Height = orderModel.Package.Height,
                Breadth = orderModel.Package.Breadth,
                Departure = orderModel.Package.From,
                Arrival = orderModel.Package.To,
                Time = orderModel.Package.Time,
                ToTal = orderModel.Package.Weight,
                Id = Guid.NewGuid()
            };

            _orderRepository.Add(order);
            _unitOfWork.Commit();
        }

         public IList<OrderViewModel> GetAllOrder()
        {
            var result = _orderRepository.GetAll().Select(x => new OrderViewModel
            {
                From = x.Departure,
                To = x.Arrival,
                OrderCode = x.OrderCode,
                Id = x.Id.ToString(),
                SenderName = x.SenderName
            });

            return result.ToList();
        }

        public OrderModel GetOrderDetail(string id)
        {
            var guidId = Guid.Parse(id);
            var result = _orderRepository.FindBy(x => x.Id == guidId).FirstOrDefault();
            if (result !=null)
            {
                var orderModel = new OrderModel
                {
                    Sender = new SenderModel
                    {
                        Name = result.SenderName,
                        Phone = result.SenderPhone
                    },
                    Receiver = new ReceiverModel
                    {
                        Name = result.ReceiverName,
                        Phone = result.ReceiverPhone,
                        Address = result.ReveiverAddress
                    },
                    Package = new PackageModel
                    {
                        From = result.Departure,
                        To = result.Arrival,
                        Breadth = result.Breadth,
                        Height = result.Height,
                        Weight = result.Weight,
                        Depth = result.Depth,
                        Total = result.ToTal,
                        Time = result.Time,

                    }
                };

                return orderModel;
            }

            return null;
        }

        public OrderResultModel GetEstimatePriceAndTotal(PackageModel packageModel)
        {
            var result = new OrderResultModel
            {
                Time = CalculateTime(packageModel.From, packageModel.To)
            };
            var sizeType = CalculateSize(packageModel.Height, packageModel.Depth, packageModel.Breadth);
            var price = CalculatePrice(packageModel.Weight, sizeType);
            result.Total = price;

            return result;

        }
        private decimal CalculateTime(string from, string to)
        {
            var path = _pathRepository.FindBy(x => x.PFrom == from && x.PTo == to).FirstOrDefault();
            
            if (path != null)
            {
                return path.Size * 8;
            }
            //if (path != null)
            //{
            //    if (!string.IsNullOrEmpty(path.Route))
            //    {
            //        var routes = path.Route.Split(',').ToList();
            //        if (routes.Any())
            //        {
            //            foreach(var routesItem in routes)
            //            {
            //                var route = routesItem.TrimStart('(').TrimEnd(')').Split(',');

            //            }
            //        }

            //    }
            //}

            return 0;
        }
        private decimal CalculatePrice(decimal weight, string sizeType)
        {
            if (sizeType == "C")
                if (weight > 5)
                    return 120;
                else
                    if (weight <= 5 && weight >= 1)
                    return 100;
                else
                    return 80;

            if (sizeType == "B")
                if (weight > 5)
                    return 88;
                else
                    if (weight <= 5 && weight >= 1)
                    return 68;
                else
                    return 48;

            if (sizeType == "A")
                if (weight > 5)
                    return 80;
                else
                    if (weight <= 5 && weight >= 1)
                    return 60;
                else
                    return 40;

            return 0;

        }
        private string CalculateSize(decimal height, decimal depth, decimal breath)
        {
            var sizeTypeHeight = CalculateHeightType(height);
            var sizeTypeDepth = CalculateHeightType(depth);
            var sizeTypeBreath = CalculateHeightType(breath);

            var listType = new List<string>();
            listType.Add(sizeTypeHeight);
            listType.Add(sizeTypeDepth);
            listType.Add(sizeTypeBreath);

            if (listType.Any(x => x.Contains("C")))
                return "C";
            if (listType.Any(x => x.Contains("B")))
                return "B";
            if (listType.Any(x => x.Contains("A")))
                return "A";

            return "A";
        }

        private string CalculateHeightType(decimal height)
        {
            if (height > 200)
                return "C";
            if(height <= 200 || height >= 40)
                return "B";
            if (height <= 25)
                return "A";
            return "A";
        }

       

    }
}
