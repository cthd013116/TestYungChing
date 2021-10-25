using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestYungChing.Models;

namespace TestYungChing.Services
{
    public interface IEmployeeService
    {
       /// <summary>
       /// 取得員工資料
       /// </summary>
       /// <returns></returns>
        ResultModel GetEmployeeData();
        
        /// <summary>
        /// insert 員工資料
        /// </summary>
        /// <param name="_emp"></param>
        /// <returns></returns>
        ResultModel InsertEmployeeData(Models.SQLDB.Employee _emp);

        /// <summary>
        /// 更新員工資料
        /// </summary>
        /// <param name="_emp"></param>
        /// <returns></returns>
        ResultModel UpdateEmployeeData(Models.SQLDB.Employee _emp);

        /// <summary>
        /// 刪除員工資料
        /// </summary>
        /// <param name="_empid"></param>
        /// <returns></returns>
        ResultModel DeleteEmployeeData(string _empid);


    }
}
