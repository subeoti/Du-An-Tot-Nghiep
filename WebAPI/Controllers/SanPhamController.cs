using DaTa.Model;
using DaTa.ViewModel.NewFolder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.IServices;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanPhamController : ControllerBase
    {
        private readonly ISanPhamServices _sanPhamService;
        public SanPhamController()
        {
            this._sanPhamService = new SanPhamServices();
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAllSanPham()
        {
            var listTT = await _sanPhamService.GetAllSanPham();
            return Ok(listTT);
        }
        [HttpGet("getbyid/{idtt}")]
        public async Task<IActionResult> GetById(Guid idtt)
        {
            var result = await _sanPhamService.GetByID(idtt);
            return Ok(result);
        }
        //[HttpGet("checktrung")]
        //public async Task<IActionResult> CheckTrungSP(SanPhamRequest request)
        //{
        //    var result = await _sanPhamService.CheckTrungTT(request);
        //    return Ok(result);
        //}
        [HttpPost("save")]
        public async Task<IActionResult> CreateOrUpdateThuocTinh(string ten, string ma, string mota, int gia, DateTime ngaytao, int trangthai, Guid idnsx, Guid idthieu, Guid idloaisp, Guid idchatlieu, Guid idkhuyenm)
        {
            var nv = await _sanPhamService.SaveSanPham(ten, ma,mota, gia, ngaytao, trangthai, idnsx, idthieu, idloaisp, idchatlieu, idkhuyenm);
            if (nv == null)
            {
                return BadRequest();
            }
            return Ok(nv);
        }
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> CreateOrUpdateSanPham(Guid id)
        {
            var tt = await _sanPhamService.DeleteSanPham(id);
            return Ok();
        }
    }
}
