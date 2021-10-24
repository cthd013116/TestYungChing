using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestYungChing.Controllers
{
    public class TestYCController : Controller
    {

        /// <summary>
        /// Get：取得資料
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet]
        [Route("~/Get")]
        public string Get()
        {
            return "";
        }

        /// <summary>
        /// Post：新增資料
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("~/Post")]
        public string Post()
        {
            return "";
        }
        
        /// <summary>
        /// Put：Update 資料
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        [Route("~/Put")]
        public string Put()
        {
            return "";
        }
            

        /// <summary>
        ///  Delete：刪除資料
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("~/Delete")]
        public string Delete(int id)
        {
            return "";
        }

       
    }
}
