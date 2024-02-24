using DaTa.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.IServices;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NSXController : ControllerBase
    {
        private readonly ThuocTinhIServices service;
        private readonly CHGiayDBContext _dbContext;
        public NSXController()
        {
            service = new ThuocTinhServices();
            _dbContext = new CHGiayDBContext();
        }
        [HttpGet("GetAllNSX")]
        public async Task<IActionResult> GetAllNSX()
        {
            var cl = await service.GetAllNSX();
            return Ok(cl);
        }
        [Route("TimKiemNSX")]
        [HttpGet]
        public List<NSX> GetAllNSX(string? name)
        {
            return _dbContext.NSXs.Where(v => v.Ten.Contains(name)).ToList();
        }
        [Route("GetNSXById")]
        [HttpGet]
        public async Task<IActionResult> GetNSXById(Guid id)
        {
            var cl = await service.GetIdNSX(id);
            if (cl == null) return BadRequest();
            return Ok(cl);
        }
        [HttpPost("ThemNSX")]
        public async Task<IActionResult> Add(string ten, int trangthai)
        {

            var nv = await service.AddNSX(ten, trangthai);
            if (nv == null)
            {
                return BadRequest();
            }
            return Ok(nv);
        }

        // PUT api/<NhanVienController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, string ten, int trangthai)
        {
            var bv = await service.UpdateNSX(id, ten, trangthai);
            if (bv == null)
            {
                return BadRequest(); // Trả về BadRequest nếu tên trùng
            }

            return Ok(bv);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNSX(Guid id)
        {
            var loaiSP = await service.DeleteNSX(id);
            return Ok(loaiSP);
        }
    }
}
