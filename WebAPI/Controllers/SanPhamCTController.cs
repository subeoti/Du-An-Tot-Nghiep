using DaTa.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.IServices;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanPhamCTController : ControllerBase
    {
        private readonly SanPhamCTIServices service;
        private readonly CHGiayDBContext _dbContext;
        public SanPhamCTController()
        {
            service = new SanPhamCTServices();
            _dbContext = new CHGiayDBContext();
        }
        [HttpGet("GetAllSPCT")]
        public async Task<IActionResult> GetAllSanPhamCT()
        {
            var cl = await service.GetAllSanPhamct();
            return Ok(cl);
        }
        
        [Route("GetSPCTById")]
        [HttpGet]
        public async Task<IActionResult> GetSPCTById(Guid id)
        {
            var cl = await service.GetSPCTByID(id);
            if (cl == null) return BadRequest();
            return Ok(cl);
        }
        [HttpPost("ThemSPCT")]
        public async Task<IActionResult> Add(int ma, int soluong, int trangthai, Guid idkc, Guid idsp)
        {

            var nv = await service.SaveSanPhamCT(ma, soluong, trangthai, idkc, idsp);
            if (nv == null)
            {
                return BadRequest();
            }
            return Ok(nv);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, int ma, int soluong, int trangthai, Guid idkc, Guid idsp)
        {
            var bv = await service.UpdateSanPhamCT(id, ma, soluong, trangthai, idkc, idsp);
            if (bv == null)
            {
                return BadRequest(); // Trả về BadRequest nếu tên trùng
            }

            return Ok(bv);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSanPCT(Guid id)
        {
            var loaiSP = await service.DeleteSanPhamCT(id);
            return Ok(loaiSP);
        }
    }
}
