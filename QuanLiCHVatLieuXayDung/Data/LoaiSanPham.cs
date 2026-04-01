using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCHVatLieuXayDung.Data
{
    public class LoaiSanPham
    {
        public int ID { get; set; }
        public string TenLoai { get; set; } = null!;
        public virtual ObservableCollectionListSource<SanPham> SanPhams { get; } = new();
    }
}