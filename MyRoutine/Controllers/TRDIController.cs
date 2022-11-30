using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyRoutine.Class;
using MyRoutine.Models;
using System.Data;
using System.Reflection;
using X.PagedList;

namespace MyRoutine.Controllers
{
    public class TRDIController : Controller
    {
        private readonly TRProcessControlContext _context;
        private readonly IConfiguration _configuration;

        private List<string> authorityList = new List<string>()
        {
            "1", "2", "9"
        };

        private List<string> roleList;


        public TRDIController(TRProcessControlContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public IActionResult Index(int? page)
        {
            ViewBag.SearchType = new SelectList(new List<string> { "OperatorId", "OperatorName" });

            //var data = _context.Operators.ToList();
            var data = _context.Operators.ToPagedList(page ?? 1, 10);
            return View(data);
        }


        public IActionResult Create()
        {
            ViewBag.AuthorityList = new SelectList(authorityList);
            ViewBag.RoleList = _context.Roles.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Operator opObject)
        {
            ViewBag.AuthorityList = new SelectList(authorityList);
            ViewBag.RoleList = _context.Roles.ToList();

            SQLConnection sqlConnection = new SQLConnection(_configuration.GetConnectionString("TRProcessControl"));

            DataTable response;


            try
            {
                sqlConnection.OpenConnection();

                Dictionary<string, string> parameters = new Dictionary<string, string>();
                parameters.Add("@OPID", opObject.OperatorId);
                parameters.Add("@OPName", "TEST");
                parameters.Add("@OPRole", "R002");
                parameters.Add("@OPLevel", opObject.Authority);

                //parameters = opObject.GetType()
                //            .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                //            .ToDictionary(prop => prop.Name, prop => (string)prop.GetValue(opObject, null));

                response = sqlConnection.ExecuteStoredProcedure("sprAddOperatorNCIM", parameters);


                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                return Content("<script language='javascript' type='text/javascript'>alert('" + ex.Message + "Failed');</script>");
            }
            finally
            {
                sqlConnection.CloseConnection();
            }


            //for(int i=0; i< opObject.)

            //foreach (var param in opObject)
            //{

            //}




            //sqlConnection.ExecuteStoredProcedure("sprAddOperatorNCIM",)

            //opObject.UpdDate = DateTime.Now;
            //opObject.AddDate = DateTime.Now;
            //opObject.Password = opObject.OperatorId.Substring(opObject.OperatorId.Length - 4); 

            try
            {
                //_context.Operators.Add(opObject);
                //_context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
