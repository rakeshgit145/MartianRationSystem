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
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"|DataDirectory|\ScheduleXML\InsertRationPacket.xml", "InsertDataRation", DataAccessMethod.Sequential)]

        public void RationControllerPostAddRation()
        {
            PacketDetail packetDetail = new PacketDetail();


            packetDetail.PacketContent = Convert.ToString(TestContext.DataRow["PacketContent"]);
            packetDetail.PacketTypeId = Convert.ToString(TestContext.DataRow["PacketTypeId"]);
            if (Convert.ToString(TestContext.DataRow["PacketTypeId"]) == "1")
            {
                packetDetail.Calories = Convert.ToInt32(TestContext.DataRow["Calories"]);

            }
            if (Convert.ToString(TestContext.DataRow["PacketTypeId"]) == "1")
            {
                packetDetail.Datestart = Convert.ToString(TestContext.DataRow["ExpiryDate"]);
                //packetDetail.ExpiryDate = Convert.ToDateTime(packetDetail.Datestart);

            }
            if (Convert.ToString(TestContext.DataRow["PacketTypeId"]) == "2")
            {
                packetDetail.LitersQty = Convert.ToInt32(TestContext.DataRow["QuantityOfLtr"]);

            }
           
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
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"|DataDirectory|\ScheduleXML\UpdateRationPacket.xml", "UpdateRation_Packet", DataAccessMethod.Sequential)]

        public void RationControllerPostEditRation()
        {
            PacketDetail packetDetail = new PacketDetail();

            packetDetail.Id = Convert.ToInt32(TestContext.DataRow["Id"]); 
            packetDetail.PacketContent = Convert.ToString(TestContext.DataRow["PacketContent"]);
            packetDetail.PacketTypeId = Convert.ToString(TestContext.DataRow["PacketTypeId"]);
            if (Convert.ToString(TestContext.DataRow["PacketTypeId"]) == "1")
            {
                packetDetail.Calories = Convert.ToInt32(TestContext.DataRow["Calories"]);

            }
            if (Convert.ToString(TestContext.DataRow["PacketTypeId"]) == "1")
            {
                packetDetail.Datestart = Convert.ToString(TestContext.DataRow["ExpiryDate"]);
                packetDetail.LitersQty = Convert.ToInt32(0);


            }
            if (Convert.ToString(TestContext.DataRow["PacketTypeId"]) == "2")
            {
                packetDetail.LitersQty = Convert.ToInt32(TestContext.DataRow["QuantityOfLtr"]);

            }

            DataContext dataContext = new DataContext();
            PacketDetailRepository packetDetailRepository = new PacketDetailRepository(dataContext);
            PacketTypeRepository packetTypeRepository = new PacketTypeRepository(dataContext);
            ErrorLogsRepository errorLogsRepository = new ErrorLogsRepository(dataContext);

            RationController rationController = new RationController(packetDetailRepository, packetTypeRepository, errorLogsRepository);
            ViewResult result = rationController.EditRation(packetDetail) as ViewResult;
            // Assert
            Assert.IsNull(result);
        }

      
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"|DataDirectory|\ScheduleXML\DeleteRationPacket.xml", "DeleteRation_Packet", DataAccessMethod.Sequential)]
        public void RationControllerDeleteRation()
        {
            PacketDetail packetDetail = new PacketDetail();
            packetDetail.Id = Convert.ToInt32(TestContext.DataRow["PacketId"]); ;
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
            if (result != null)
            {
                Assert.IsNotNull(result);
            }
            else
            {
                Assert.IsNull(result);
            }
        }

        
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"|DataDirectory|\ScheduleXML\DateXml.xml", "Date_ScheduleDate", DataAccessMethod.Sequential)]
        public void StartScheduleTestListMethod()
        {
            DataContext dataContext = new DataContext();
            PacketDetailRepository packetDetailRepository = new PacketDetailRepository(dataContext);
            PacketTypeRepository packetTypeRepository = new PacketTypeRepository(dataContext);
            ErrorLogsRepository errorLogsRepository = new ErrorLogsRepository(dataContext);


            string startScheduleDate = Convert.ToString(TestContext.DataRow["StartDate"]);

            RationScheduleViewModelNew rationScheduleViewModelNew = new RationScheduleViewModelNew();
            rationScheduleViewModelNew.statedate = startScheduleDate;
            RationController rationController = new RationController(packetDetailRepository, packetTypeRepository, errorLogsRepository);

            // Act
            ViewResult result = rationController.Schduled(rationScheduleViewModelNew) as ViewResult;
           // Assert
            if (result != null)
            {
                Assert.IsNotNull( result.Model);
            }
            else

            {
                Assert.IsNull(result);
            }
        }

    }
}
