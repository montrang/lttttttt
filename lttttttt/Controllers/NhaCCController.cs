using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lttttttt.Models;

namespace lttttttt.Controllers
{
    public class NhaCCController : Controller
    {
        //khai báo data model để làm việc với data base
        LTQLDbContext db = new LTQLDbContext();
        // GET: NhaCC
        public ActionResult Index()
        {
            return View(db.NhaCCs.ToList());
        }
        //mặc định là phương thức HTTPget
        //action trả về một view cho client để nhập thông tin khách hàng
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        //Phương thức HTTPPost để nhận dữu liệu từ client gửi lên
        [HttpPost]
        
        // viết codde cho actions create(tạo mới thông tin một khách hàng)
        public ActionResult Create(NhaCC ncc)
        {
            //kiểm tra dữ liệu ở model
            if(ModelState.IsValid)
            {
                //khách hàng là dữ liệu của đối tượng khách hàng mà client gửi lên
                db.NhaCCs.Add(ncc);
                //Lưu thông tin thay đổi với database
                db.SaveChanges();
                // Điều hướng đến trang index nếu thực hiện thành công
                return RedirectToAction("Index");
            }
            // nếu trả về view nhập thông tin khách hàng
            return View();
        }

    }
}