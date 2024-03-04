using DaTa.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.IServices;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KichCoController : ControllerBase
    {
        private readonly ThuocTinhIServices service;
        private readonly CHGiayDBContext _dbContext;
        public KichCoController()
        {
            service = new ThuocTinhServices();
            _dbContext = new CHGiayDBContext();
        }
        [HttpGet("GetAllKichCo")]
        public async Task<IActionResult> GetAllKichCo()
        {
            var cl = await service.GetAllKichCo();
            return Ok(cl);
        }
        [Route("TimKiemKichCo")]
        [HttpGet]
        public List<KichCo> GetAllKichCo(string? name)
        {
            return _dbContext.KichCos.Where(v => v.Ten.Contains(name)).ToList();
        }
        [Route("GetKichCoById")]
        [HttpGet]
        public async Task<IActionResult> GetKichCoById(Guid id)
        {
            var cl = await service.GetKichCoById(id);
            if (cl == null) return BadRequest();
            return Ok(cl);
        }
        [HttpPost("ThemKichCo")]
        public async Task<IActionResult> Add(string ten, int trangthai)
        {

            var nv = await service.AddKichCo(ten, trangthai);
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
            var bv = await service.UpdateKichCo(id, ten, trangthai);
            if (bv == null)
            {
                return BadRequest(); // Trả về BadRequest nếu tên trùng
            }

            return Ok(bv);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLoaiSP(Guid id)
        {
            var loaiSP = await service.DeleteLoaiSP(id);
            return Ok(loaiSP);
        }
    }
}
