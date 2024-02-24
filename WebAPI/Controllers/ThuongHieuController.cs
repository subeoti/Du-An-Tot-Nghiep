using DaTa.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.IServices;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThuongHieuController : ControllerBase
    {
        private readonly ThuocTinhIServices service;
        private readonly CHGiayDBContext _dbContext;
        public ThuongHieuController()
        {
            service = new ThuocTinhServices();
            _dbContext = new CHGiayDBContext();
        }
        [HttpGet("GetAllThuongHieu")]
        public async Task<IActionResult> GetAllThuongHieu()
        {
            var cl = await service.GetAllThuongHieu();
            return Ok(cl);
        }
        [Route("TimKiemThuongHieu")]
        [HttpGet]
        public List<ThuongHieu> GetAllThuongHieu(string? name)
        {
            return _dbContext.ThuongHieus.Where(v => v.Ten.Contains(name)).ToList();
        }
        [Route("GetThuongHieuById")]
        [HttpGet]
        public async Task<IActionResult> GetThuongHieuById(Guid id)
        {
            var cl = await service.GetIdThuongHieu(id);
            if (cl == null) return BadRequest();
            return Ok(cl);
        }
        [HttpPost("ThemThuongHieu")]
        public async Task<IActionResult> Add(string ten, int trangthai)
        {

            var nv = await service.AddThuongHieu(ten, trangthai);
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
            var bv = await service.UpdateThuongHieu(id, ten, trangthai);
            if (bv == null)
            {
                return BadRequest(); // Trả về BadRequest nếu tên trùng
            }

            return Ok(bv);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteThuongHieu(Guid id)
        {
            var loaiSP = await service.DeleteTH(id);
            return Ok(loaiSP);
        }
    }
}
