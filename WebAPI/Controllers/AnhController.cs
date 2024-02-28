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
    public class AnhController : ControllerBase
    {
        private readonly ThuocTinhIServices service;
        private readonly CHGiayDBContext _dbContext;
        public AnhController()
        {
            service = new ThuocTinhServices();
            _dbContext = new CHGiayDBContext();
        }
        [HttpGet("GetAllAnh")]
        public async Task<IActionResult> GetAllAnh()
        {
            var cl = await service.GetAllAnh();
            return Ok(cl);
        }
        [Route("TimKiemAnh")]
        [HttpGet]
        public List<Anh> GetAllAnh(string? name)
        {
            return _dbContext.Anhs.Where(v => v.AnhSP.Contains(name)).ToList();
        }
        [Route("GetAnhById")]
        [HttpGet]
        public async Task<IActionResult> GetAnhById(Guid id)
        {
            var cl = await service.GetAnhById(id);
            if (cl == null) return BadRequest();
            return Ok(cl);
        }
        [HttpPost("ThemAnh")]
        public async Task<IActionResult> Add(string ten, Guid idsp)
        {

            var nv = await service.AddAnh(ten, idsp);
            if (nv == null)
            {
                return BadRequest();
            }
            return Ok(nv);
        }
       
        [HttpGet]
        public async Task<IActionResult> GetLoaiSpTheoCha(Guid id)
        {
            // Lấy danh sách các theo id sp
            var anh = await _dbContext.Anhs
              .Where(a => a.IDSanPham == id)
              .ToListAsync();
            if (anh == null)
            {
                return BadRequest();
            }
            return Ok(anh);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnh(Guid id)
        {
            var loaiSP = await service.DeleteAnh(id);
            return Ok(loaiSP);
        }
    }
}
