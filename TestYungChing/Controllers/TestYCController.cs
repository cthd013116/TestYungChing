using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestYungChing.Models;
using TestYungChing.Models.SQLDB;
using TestYungChing.Services;

namespace TestYungChing.Controllers
{
    public class TestYCController : Controller
    {

        private readonly IEmployeeService _empservice;
        /// <summary>
        /// Get：取得資料
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet]
        [Route("~/Get")]
        public string Get()
        {
            
            //取得全部資料
            ResultModel r = _empservice.GetEmployeeData();
            return "";
        }

        /// <summary>
        /// Post：新增資料
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("~/Post")]
        public string Post([FromBody] Employee _emp)
        {
            ResultModel r = _empservice.InsertEmployeeData(_emp);
            return "";
        }
        
        /// <summary>
        /// Put：Update 資料
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        [Route("~/Put")]
        public string Put([FromBody] Employee _emp)
        {
            ResultModel r = _empservice.UpdateEmployeeData(_emp);
          
            return "";
        }
            

        /// <summary>
        ///  Delete：刪除資料
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("~/Delete")]
        public string Delete([FromBody] Employee _emp)
        {
            string _empid = _emp.EmpId;
            ResultModel r = _empservice.DeleteEmployeeData(_empid);
            return "";
        }

       
    }
}
