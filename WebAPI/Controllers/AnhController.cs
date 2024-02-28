using DaTa.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        // PUT api/<NhanVienController>/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> Put(Guid id, string ten, int trangthai)
        //{
        //    var bv = await service.UpdateAnh(id, ten, trangthai);
        //    if (bv == null)
        //    {
        //        return BadRequest(); // Trả về BadRequest nếu tên trùng
        //    }

        //    return Ok(bv);
        //}

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnh(Guid id)
        {
            var loaiSP = await service.DeleteAnh(id);
            return Ok(loaiSP);
        }
    }
}
