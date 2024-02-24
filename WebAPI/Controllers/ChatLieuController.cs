using DaTa.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.IServices;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatLieuController : ControllerBase
    {
        private readonly ThuocTinhIServices service;
        private readonly CHGiayDBContext _dbContext;
        public ChatLieuController()
        {
            service = new ThuocTinhServices();
            _dbContext = new CHGiayDBContext();
        }
        [HttpGet("GetAllChatLieu")]
        public async Task<IActionResult> GetAllChatLieu()
        {
            var cl = await service.GetAllChatLieu();
            return Ok(cl);
        }
        [Route("TimKiemChatLieu")]
        [HttpGet]
        public List<ChatLieu> GetAllChatLieu(string? name)
        {
            return _dbContext.ChatLieus.Where(v => v.Ten.Contains(name)).ToList();
        }
        [Route("GetChatLieuById")]
        [HttpGet]
        public async Task<IActionResult> GetChatLieuById(Guid id)
        {
            var cl = await service.GetChatLieuById(id);
            if (cl == null) return BadRequest();
            return Ok(cl);
        }
        [HttpPost("ThemChatLieu")]
        public async Task<IActionResult> Add(string ten, int trangthai)
        {

            var nv = await service.AddChatLieu(ten, trangthai);
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
            var bv = await service.UpdateChatLieu(id, ten, trangthai);
            if (bv == null)
            {
                return BadRequest(); // Trả về BadRequest nếu tên trùng
            }

            return Ok(bv);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChatLieu(Guid id)
        {
            var loaiSP = await service.DeleteChatLieu(id);
            return Ok(loaiSP);
        }
    }
}
