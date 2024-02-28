using DaTa.Model;
using DaTa.ViewModel.NewFolder;
using Microsoft.EntityFrameworkCore;
using WebAPI.IServices;

namespace WebAPI.Services
{
    public class ThuocTinhServices : ThuocTinhIServices
    {
        private readonly CHGiayDBContext _context;
        public ThuocTinhServices()
        {
            this._context = new CHGiayDBContext();
        }
        #region ChatLieu
        public async Task<ChatLieu> AddChatLieu(string ten, int trangthai)
        {
            try
            {
                var existingColor = await _context.ChatLieus.FirstOrDefaultAsync(x => x.Ten.Trim().ToUpper() == ten.Trim().ToUpper());
                if (existingColor != null)
                {
                    return null;
                }
                ChatLieu kc = new ChatLieu()
                {
                    Id = Guid.NewGuid(),
                    Ten = ten,
                    Status = 1
                };
                _context.ChatLieus.Add(kc);
                _context.SaveChanges();
                return kc;

            }
            catch (Exception)
            {

                throw;

            }
        }
        public async Task<bool> DeleteChatLieu(Guid id)
        {
            try
            {
                var cl = await _context.ChatLieus.FirstOrDefaultAsync(cl => cl.Id == id);
                if (cl != null)
                {
                    _context.ChatLieus.Remove(cl);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<List<ChatLieu>> GetAllChatLieu()
        {
            try
            {
                return await _context.ChatLieus.OrderByDescending(x => x.Status).ToListAsync();
            }
            catch (Exception)
            {

                throw;

            }
        }
        public async Task<ChatLieu> GetChatLieuById(Guid id)
        {
            try
            {
                var nv = await _context.ChatLieus.FirstOrDefaultAsync(nv => nv.Id == id);
                return nv;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<ChatLieu> UpdateChatLieu(Guid id, string ten, int trangthai)
        {
            try
            {
                var cl = await _context.ChatLieus.FirstOrDefaultAsync(x => x.Id == id);
                if (cl != null)
                {
                    var existingColor = await _context.ChatLieus.FirstOrDefaultAsync(x => x.Ten.Trim().ToUpper() == ten.Trim().ToUpper());
                    if (existingColor != null)
                    {
                        return null; // Trả về null để báo hiệu tên trùng
                    }
                    cl.Ten = ten;
                    cl.Status = 1;
                    _context.ChatLieus.Update(cl);
                    _context.SaveChanges();
                    return cl;
                }

                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
        #region LoaiSP
        public async Task<LoaiSanPham> AddLoaiSP(string ten, int trangthai)
        {
            try
            {
                var existingColor = await _context.LoaiSanPhams.FirstOrDefaultAsync(x => x.Ten.Trim().ToUpper() == ten.Trim().ToUpper());
                if (existingColor != null)
                {
                    return null;
                }
                LoaiSanPham lsp = new LoaiSanPham()
                {
                    ID = Guid.NewGuid(),
                    Ten = ten,
                    Status = 1
                };
                _context.LoaiSanPhams.Add(lsp);
                _context.SaveChanges();
                return lsp;

            }
            catch (Exception)
            {

                throw;

            }
        }
        public async Task<bool> DeleteLoaiSP(Guid id)
        {
            try
            {
                var lsp = await _context.LoaiSanPhams.FirstOrDefaultAsync(lsp => lsp.ID == id);
                if (lsp != null)
                {
                    _context.LoaiSanPhams.Remove(lsp);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<List<LoaiSanPham>> GetAllLoaiSP()
        {
            try
            {
                return await _context.LoaiSanPhams.OrderByDescending(x => x.Status).ToListAsync();
            }
            catch (Exception)
            {

                throw;

            }
        }
        public async Task<LoaiSanPham> UpdateLoaiSp(Guid id, string ten, int trangthai)
        {
            try
            {
                var lsp = await _context.LoaiSanPhams.FirstOrDefaultAsync(x => x.ID == id);
                if (lsp != null)
                {
                    var existingColor = await _context.LoaiSanPhams.FirstOrDefaultAsync(x => x.Ten.Trim().ToUpper() == ten.Trim().ToUpper());
                    if (existingColor != null)
                    {
                        return null; // Trả về null để báo hiệu tên trùng
                    }
                    lsp.Ten = ten;
                    lsp.Status = 1;
                    _context.LoaiSanPhams.Update(lsp);
                    _context.SaveChanges();
                    return lsp;
                }

                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<LoaiSanPham> GetLoaiSPById(Guid id)
        {
            try
            {
                var lsp = await _context.LoaiSanPhams.FirstOrDefaultAsync(nv => nv.ID == id);
                return lsp;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
        #region NSX
        public async Task<NSX> AddNSX(string ten, int trangthai)
        {
            try
            {
                var existingColor = await _context.NSXs.FirstOrDefaultAsync(x => x.Ten.Trim().ToUpper() == ten.Trim().ToUpper());
                if (existingColor != null)
                {
                    return null;
                }
                NSX nsx = new NSX()
                {
                    Id = Guid.NewGuid(),
                    Ten = ten,
                    Status = 1
                };
                _context.NSXs.Add(nsx);
                _context.SaveChanges();
                return nsx;

            }
            catch (Exception)
            {

                throw;

            }
        }
        public async Task<bool> DeleteNSX(Guid id)
        {
            try
            {
                var nsx = await _context.NSXs.FirstOrDefaultAsync(nv => nv.Id == id);
                if (nsx != null)
                {
                    _context.NSXs.Remove(nsx);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<List<NSX>> GetAllNSX()
        {
            try
            {
                return await _context.NSXs.OrderByDescending(x => x.Status).ToListAsync();
            }
            catch (Exception)
            {

                throw;

            }
        }
        public async Task<NSX> GetIdNSX(Guid id)
        {
            try
            {
                var nsx = await _context.NSXs.FirstOrDefaultAsync(nv => nv.Id == id);
                return nsx;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<NSX> UpdateNSX(Guid id, string ten, int trangthai)
        {
            try
            {
                var nsx = await _context.NSXs.FirstOrDefaultAsync(x => x.Id == id);
                if (nsx != null)
                {
                    var existingColor = await _context.NSXs.FirstOrDefaultAsync(x => x.Ten.Trim().ToUpper() == ten.Trim().ToUpper());
                    if (existingColor != null)
                    {
                        return null; // Trả về null để báo hiệu tên trùng
                    }
                    nsx.Ten = ten;
                    nsx.Status = 1;
                    _context.NSXs.Update(nsx);
                    _context.SaveChanges();
                    return nsx;
                }

                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
        #region ThuongHieu
        public async Task<ThuongHieu> AddThuongHieu(string ten, int trangthai)
        {
            try
            {
                var existingColor = await _context.ThuongHieus.FirstOrDefaultAsync(x => x.Ten.Trim().ToUpper() == ten.Trim().ToUpper());
                if (existingColor != null)
                {
                    return null;
                }
                ThuongHieu th = new ThuongHieu()
                {
                    Id = Guid.NewGuid(),
                    Ten = ten,
                    Status = 1
                };
                _context.ThuongHieus.Add(th);
                _context.SaveChanges();
                return th;

            }
            catch (Exception)
            {

                throw;

            }
        }

        public async Task<bool> DeleteTH(Guid id)
        {
            try
            {
                var th = await _context.ThuongHieus.FirstOrDefaultAsync(nv => nv.Id == id);
                if (th != null)
                {
                    _context.ThuongHieus.Remove(th);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<List<ThuongHieu>> GetAllThuongHieu()
        {
            try
            {
                return await _context.ThuongHieus.OrderByDescending(x => x.Status).ToListAsync();
            }
            catch (Exception)
            {

                throw;

            }
        }
        public async Task<ThuongHieu> UpdateThuongHieu(Guid id, string ten, int trangthai)
        {
            try
            {
                var th = await _context.ThuongHieus.FirstOrDefaultAsync(x => x.Id == id);
                if (th != null)
                {
                    var existingColor = await _context.ThuongHieus.FirstOrDefaultAsync(x => x.Ten.Trim().ToUpper() == ten.Trim().ToUpper());
                    if (existingColor != null)
                    {
                        return null; // Trả về null để báo hiệu tên trùng
                    }
                    th.Ten = ten;
                    th.Status = 1;
                    _context.ThuongHieus.Update(th);
                    _context.SaveChanges();
                    return th;
                }

                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<ThuongHieu> GetIdThuongHieu(Guid id)
        {
            try
            {
                var th = await _context.ThuongHieus.FirstOrDefaultAsync(nv => nv.Id == id);
                return th;
            }
            catch (Exception)
            {

                throw;
            }
        }


        #endregion
        #region KhuyenMai
        public async Task<KhuyenMai> AddKhuyemMai(string ten, int trangthai, int giatri, string mota, DateTime ngaybd, DateTime ngaykt)
        {
            try
            {
                var existingColor = await _context.KhuyenMais.FirstOrDefaultAsync(x => x.Ten.Trim().ToUpper() == ten.Trim().ToUpper());
                if (existingColor != null)
                {
                    return null;
                }
                KhuyenMai km = new KhuyenMai()
                {
                    Id = Guid.NewGuid(),
                    Ten = ten,
                    GiaTri= giatri,
                    NgayApDung=ngaybd,
                    NgayKetThuc= ngaykt,
                    MoTa= mota,
                    Status = 1
                };
                _context.KhuyenMais.Add(km);
                _context.SaveChanges();
                return km;

            }
            catch (Exception)
            {

                throw;

            }
        }

        public async Task<KhuyenMai> GetLoaiKMById(Guid id)
        {
            try
            {
                var km = await _context.KhuyenMais.FirstOrDefaultAsync(nv => nv.Id == id);
                return km;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> DeleteKhuyMai(Guid id)
        {
            try
            {
                var km = await _context.KhuyenMais.FirstOrDefaultAsync(nv => nv.Id == id);
                if (km != null)
                {
                    _context.KhuyenMais.Remove(km);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<KhuyenMai> UpdateKhuyenMai(Guid id, string ten, int trangthai, int giatri, string mota, DateTime ngaybd, DateTime ngaykt)
        {
            try
            {
                var km = await _context.KhuyenMais.FirstOrDefaultAsync(x => x.Id == id);
                if (km != null)
                {
                    var existingColor = await _context.KhuyenMais.FirstOrDefaultAsync(x => x.Ten.Trim().ToUpper() == ten.Trim().ToUpper());
                    if (existingColor != null)
                    {
                        return null; // Trả về null để báo hiệu tên trùng
                    }
                    km.Ten = ten;
                    km.MoTa = mota;
                    km.GiaTri= giatri;
                    km.NgayApDung = ngaybd;
                    km.NgayKetThuc= ngaykt;
                    km.Status = 1;
                    _context.KhuyenMais.Update(km);
                    _context.SaveChanges();
                    return km;
                }

                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<KhuyenMai>> GetAllKhuyenMai()
        {
            try
            {
                return await _context.KhuyenMais.OrderByDescending(x => x.Status).ToListAsync();
            }
            catch (Exception)
            {

                throw;

            }
        }
        #endregion
        #region Anh
        public async Task<Anh> AddAnh(string ten,Guid idsp )
        {
            try
            {
                var existingColor = await _context.Anhs.FirstOrDefaultAsync(x => x.AnhSP.Trim().ToUpper() == ten.Trim().ToUpper());
                if (existingColor != null)
                {
                    return null;
                }
                Anh a = new Anh()
                {
                    ID = Guid.NewGuid(),
                    AnhSP = ten,
                    IDSanPham = idsp
                    
                };
                _context.Anhs.Add(a);
                _context.SaveChanges();
                return a;

            }
            catch (Exception)
            {

                throw;

            }
        }

        public Task<Anh> GetAnhById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAnh(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Anh> UpdateAnh(Guid id, string ten, int trangthai, int giatri, string mota, DateTime ngaybd, DateTime ngaykt)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Anh>> GetAllAnh()
        {
            try
            {
                return await _context.Anhs.ToListAsync();
            }
            catch (Exception)
            {

                throw;

            }
        }


        #endregion
        #region KichCo
        public async Task<KichCo> AddKichCo(string ten, int trangthai)
        {
            try
            {
                var existingColor = await _context.KichCos.FirstOrDefaultAsync(x => x.Ten.Trim().ToUpper() == ten.Trim().ToUpper());
                if (existingColor != null)
                {
                    return null;
                }
                KichCo kc = new KichCo()
                {
                    Id = Guid.NewGuid(),
                    Ten = ten,
                    TrangThai = 1
                };
                _context.KichCos.Add(kc);
                _context.SaveChanges();
                return kc;

            }
            catch (Exception)
            {

                throw;

            }
        }

        public async Task<KichCo> GetKichCoById(Guid id)
        {
            try
            {
                var lsp = await _context.KichCos.FirstOrDefaultAsync(nv => nv.Id == id);
                return lsp;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<bool> DeleteKichCo(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<KichCo> UpdateKichCo(Guid id, string ten, int trangthai)
        {
            try
            {
                var kc = await _context.KichCos.FirstOrDefaultAsync(x => x.Id == id);
                if (kc != null)
                {
                    var existingColor = await _context.KichCos.FirstOrDefaultAsync(x => x.Ten.Trim().ToUpper() == ten.Trim().ToUpper());
                    if (existingColor != null)
                    {
                        return null; // Trả về null để báo hiệu tên trùng
                    }
                    kc.Ten = ten;
                    kc.TrangThai = 1;
                    _context.KichCos.Update(kc);
                    _context.SaveChanges();
                    return kc;
                }

                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<KichCo>> GetAllKichCo()
        {
            try
            {
                return await _context.KichCos.OrderByDescending(x => x.TrangThai).ToListAsync();
            }
            catch (Exception)
            {

                throw;

            }
        }
        #endregion
    }
}
