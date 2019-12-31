using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Contracts;
using DAL.Data;
using DAL.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using WebUI.Controllers;
using WebUI.Models;

namespace RationUnitTest
{
    [TestClass]
    public class RationUnitTest
    {   
        //******************Test Case For Dashboard Initialization Method******************//
        [TestMethod]
        public void RationControllerDashboard()
        {
            PacketDetail packetDetail = new PacketDetail();
            DataContext dataContext = new DataContext();
            PacketDetailRepository packetDetailRepository = new PacketDetailRepository(dataContext);
            PacketTypeRepository packetTypeRepository = new PacketTypeRepository(dataContext);
            ErrorLogsRepository errorLogsRepository = new ErrorLogsRepository(dataContext);     
            
            RationController rationController = new RationController(packetDetailRepository, packetTypeRepository, errorLogsRepository);
            ViewResult result = rationController.Dashboard() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }


        //******************Test Case to Get Add Ration View******************//
        [TestMethod]
        public void RationControllerGetAddRation()
        {
            DataContext dataContext = new DataContext();
            PacketDetailRepository packetDetailRepository = new PacketDetailRepository(dataContext);
            PacketTypeRepository packetTypeRepository = new PacketTypeRepository(dataContext);
            ErrorLogsRepository errorLogsRepository = new ErrorLogsRepository(dataContext);

            RationController rationController = new RationController(packetDetailRepository, packetTypeRepository, errorLogsRepository);
            ViewResult result = rationController.AddRation() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }

        //******************Test Case to Add Ration Record(POST)******************//
        [TestMethod]
        public void RationControllerPostAddRation()
        {
            PacketDetail packetDetail = new PacketDetail();
            packetDetail.PacketContent = "Bread";
            packetDetail.PacketTypeId = "1";
            packetDetail.ExpiryDate = DateTime.Now;
            packetDetail.Calories = 2500;
            DataContext dataContext = new DataContext();
            PacketDetailRepository packetDetailRepository = new PacketDetailRepository(dataContext);
            PacketTypeRepository packetTypeRepository = new PacketTypeRepository(dataContext);
            ErrorLogsRepository errorLogsRepository = new ErrorLogsRepository(dataContext);

            RationController rationController = new RationController(packetDetailRepository, packetTypeRepository, errorLogsRepository);
            ViewResult result = rationController.AddRation(packetDetail) as ViewResult;
            // Assert
            Assert.IsNull(result);
        }


        //******************Test Case to Add Water Ration Record(POST)******************//
        [TestMethod]
        public void RationControllerPostWaterAddRation()
        {
            PacketDetail packetDetail = new PacketDetail();
            packetDetail.PacketContent = null;
            packetDetail.PacketTypeId = "2";
            packetDetail.ExpiryDate = null;
            packetDetail.LitersQty = 2;
            DataContext dataContext = new DataContext();
            PacketDetailRepository packetDetailRepository = new PacketDetailRepository(dataContext);
            PacketTypeRepository packetTypeRepository = new PacketTypeRepository(dataContext);
            ErrorLogsRepository errorLogsRepository = new ErrorLogsRepository(dataContext);

            RationController rationController = new RationController(packetDetailRepository, packetTypeRepository, errorLogsRepository);
            ViewResult result = rationController.AddRation(packetDetail) as ViewResult;
            // Assert
            Assert.IsNull(result);
        }


        //******************Test Case to Get Edit Ration View******************//
        [TestMethod]
        public void RationControllerGetEditRation()
        {
            int PacketId = 1;
            DataContext dataContext = new DataContext();
            PacketDetailRepository packetDetailRepository = new PacketDetailRepository(dataContext);
            PacketTypeRepository packetTypeRepository = new PacketTypeRepository(dataContext);
            ErrorLogsRepository errorLogsRepository = new ErrorLogsRepository(dataContext);

            RationController rationController = new RationController(packetDetailRepository, packetTypeRepository, errorLogsRepository);
            ViewResult result = rationController.EditRation(PacketId) as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }

        //******************Test Case to Update Ration Record(POST)******************//
        [TestMethod]
        public void RationControllerPostEditRation()
        {
            PacketDetail packetDetail = new PacketDetail();
            packetDetail.Id = 1;
            packetDetail.PacketContent = null;
            packetDetail.PacketTypeId = "2";
            packetDetail.ExpiryDate = DateTime.Now;
            packetDetail.Calories = 0;
            packetDetail.LitersQty = 2;

            DataContext dataContext = new DataContext();
            PacketDetailRepository packetDetailRepository = new PacketDetailRepository(dataContext);
            PacketTypeRepository packetTypeRepository = new PacketTypeRepository(dataContext);
            ErrorLogsRepository errorLogsRepository = new ErrorLogsRepository(dataContext);

            RationController rationController = new RationController(packetDetailRepository, packetTypeRepository, errorLogsRepository);
            ViewResult result = rationController.EditRation(packetDetail) as ViewResult;
            // Assert
            Assert.IsNull(result);
        }

        //******************Test Case to Delete Ration Record(POST)******************//
        [TestMethod]
        public void RationControllerDeleteRation()
        {
            PacketDetail packetDetail = new PacketDetail();
            packetDetail.Id = 1;
            DataContext dataContext = new DataContext();
            PacketDetailRepository packetDetailRepository = new PacketDetailRepository(dataContext);
            PacketTypeRepository packetTypeRepository = new PacketTypeRepository(dataContext);
            ErrorLogsRepository errorLogsRepository = new ErrorLogsRepository(dataContext);

            RationController rationController = new RationController(packetDetailRepository, packetTypeRepository, errorLogsRepository);
            JsonResult result = rationController.DeleteRation(packetDetail) as JsonResult;
            // Assert
            Assert.IsNotNull(result);            
        }

        //******************Test Case to Get Ration Schedule******************//
        [TestMethod]
        public void RationControllerGetSchudle()
        {

            DataContext dataContext = new DataContext();
            PacketDetailRepository packetDetailRepository = new PacketDetailRepository(dataContext);
            PacketTypeRepository packetTypeRepository = new PacketTypeRepository(dataContext);
            ErrorLogsRepository errorLogsRepository = new ErrorLogsRepository(dataContext);

            RationController rationController = new RationController(packetDetailRepository, packetTypeRepository, errorLogsRepository);
            ViewResult result = rationController.Schduled() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }

        //******************Test Case to Get Ration Schedule(POST)******************//
        [TestMethod]
        public void RationControllerPostSchudle()
        {

            //RationScheduleViewModel rationScheduleViewModel =new RationScheduleViewModel();
            RationScheduleViewModelNew rationScheduleViewModel = new RationScheduleViewModelNew();
            rationScheduleViewModel.StartDate = DateTime.Now;
            DataContext dataContext = new DataContext();
            PacketDetailRepository packetDetailRepository = new PacketDetailRepository(dataContext);
            PacketTypeRepository packetTypeRepository = new PacketTypeRepository(dataContext);
            ErrorLogsRepository errorLogsRepository = new ErrorLogsRepository(dataContext);

            RationController rationController = new RationController(packetDetailRepository, packetTypeRepository, errorLogsRepository);
            ViewResult result = rationController.Schduled(rationScheduleViewModel) as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void RationControllerNewPostSchudle()
        {

            //RationScheduleViewModel rationScheduleViewModel =new RationScheduleViewModel();
            DataContext dataContext = new DataContext();
            PacketDetailRepository packetDetailRepository = new PacketDetailRepository(dataContext);
            PacketTypeRepository packetTypeRepository = new PacketTypeRepository(dataContext);
            ErrorLogsRepository errorLogsRepository = new ErrorLogsRepository(dataContext);


            List<RationScheduleViewModelNew> rationDate = new List<RationScheduleViewModelNew>();


            for (int i = 0; i < 3; i++)
            {
                RationScheduleViewModelNew rationScheduleViewModel = new RationScheduleViewModelNew();

                if (i==0)
                {
                    rationScheduleViewModel.StartDate = DateTime.Now;
                    rationDate.Add(rationScheduleViewModel);

                }
                else
                {
                    rationScheduleViewModel.StartDate = DateTime.Now.AddDays(i);
                    rationDate.Add(rationScheduleViewModel);

                }
            }
            


            foreach (var item in rationDate)
            {
                RationScheduleViewModelNew rationSchedule = new RationScheduleViewModelNew();
                rationSchedule.StartDate = item.StartDate;
                RationController rationController = new RationController(packetDetailRepository, packetTypeRepository, errorLogsRepository);
                ViewResult result = rationController.Schduled(rationSchedule) as ViewResult;
                // Assert

                Assert.IsNotNull(result);

            }
        }


    }
}
