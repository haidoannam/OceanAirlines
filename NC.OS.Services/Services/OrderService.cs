﻿using NC.OS.Data.Infrastructure;
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
        private readonly IEntityBaseRepository<User> _userRepository;
        private readonly IUnitOfWork _unitOfWork;

        public OrderService(IEntityBaseRepository<User> userRepository, IUnitOfWork unitOfWork)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
        }

        public OrderResultModel GetEstimatePriceAndTotal(OrderModel orderModel)
        {
            var result = new OrderResultModel
            {
                Time = CalculateTime(orderModel.Package.From, orderModel.Package.To)
            };
            var sizeType = CalculateSize(orderModel.Package.Height, orderModel.Package.Depth, orderModel.Package.Breadth);
            var price = CalculatePrice(orderModel.Package.Weight, sizeType);
            result.Total = price;

            return result;

        }
        private double CalculateTime(string from, string to)
        {


            return 0;
        }
        private double CalculatePrice(double weight, string sizeType)
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
        private string CalculateSize(double height, double depth, double breath)
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

        private string CalculateHeightType(double height)
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