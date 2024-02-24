using DaTa.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.IServices;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhuyenMaiController : ControllerBase
    {
        private readonly ThuocTinhIServices service;
        private readonly CHGiayDBContext _dbContext;
        public KhuyenMaiController()
        {
            service = new ThuocTinhServices();
            _dbContext = new CHGiayDBContext();
        }
        [HttpGet("GetAllKhuyenMai")]
        public async Task<IActionResult> GetAllKhuyenMai()
        {
            var cl = await service.GetAllKhuyenMai();
            return Ok(cl);
        }
        [Route("TimKiemKhuyenMai")]
        [HttpGet]
        public List<KhuyenMai> GetAllKhuyenMai(string? name)
        {
            return _dbContext.KhuyenMais.Where(v => v.Ten.Contains(name)).ToList();
        }
        [Route("GetKhuyenMaiById")]
        [HttpGet]
        public async Task<IActionResult> GetKhuyenMaiById(Guid id)
        {
            var cl = await service.GetLoaiKMById(id);
            if (cl == null) return BadRequest();
            return Ok(cl);
        }
        [HttpPost("ThemKHuyenMai")]
        public async Task<IActionResult> Add(string ten, int trangthai, int giatri, string mota, DateTime ngaybd, DateTime ngaykt)
        {

            var nv = await service.AddKhuyemMai(ten, trangthai, giatri, mota, ngaybd, ngaykt);
            if (nv == null)
            {
                return BadRequest();
            }
            return Ok(nv);
        }

        // PUT api/<NhanVienController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, string ten, int trangthai, int giatri, string mota, DateTime ngaybd, DateTime ngaykt)
        {
            var bv = await service.UpdateKhuyenMai(id, ten, trangthai, giatri, mota, ngaybd, ngaykt);
            if (bv == null)
            {
                return BadRequest(); // Trả về BadRequest nếu tên trùng
            }

            return Ok(bv);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKhuyenMai(Guid id)
        {
            var km = await service.DeleteKhuyMai(id);
            return Ok(km);
        }
    }
}
