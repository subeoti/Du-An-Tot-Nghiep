﻿using DaTa.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.IServices;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaiSPController : ControllerBase
    {
        private readonly ThuocTinhIServices service;
        private readonly CHGiayDBContext _dbContext;
        public LoaiSPController()
        {
            service = new ThuocTinhServices();
            _dbContext = new CHGiayDBContext();
        }
        [HttpGet("GetAllLoaiSP")]
        public async Task<IActionResult> GetAllLoaiSP()
        {
            var cl = await service.GetAllLoaiSP();
            return Ok(cl);
        }
        [Route("TimKiemLoaiSP")]
        [HttpGet]
        public List<LoaiSanPham> GetAllLoaiSP(string? name)
        {
            return _dbContext.LoaiSanPhams.Where(v => v.Ten.Contains(name)).ToList();
        }
        [Route("GetLoaiSPById")]
        [HttpGet]
        public async Task<IActionResult> GetLoaiSPById(Guid id)
        {
            var cl = await service.GetLoaiSPById(id);
            if (cl == null) return BadRequest();
            return Ok(cl);
        }
        [HttpPost("ThemLoaiSP")]
        public async Task<IActionResult> Add(string ten, int trangthai)
        {

            var nv = await service.AddLoaiSP(ten, trangthai);
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
            var bv = await service.UpdateLoaiSp(id, ten, trangthai);
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
