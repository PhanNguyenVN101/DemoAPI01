

namespace PhanNguyen_DemoAPI.Models
{
    public class PhanCong
    {
        public string ? NhanVienId { get; set; }
        public string? DuAnId { get; set; }

        public DateTimeOffset ? DeleteDate { get; set; }

        public NhanVien NhanVien { get; set; }
        public DuAn DuAn { get; set; }

    }
}
