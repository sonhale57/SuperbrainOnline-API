namespace SuperbrainOnline_API.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hocsinh")]
    public partial class Hocsinh
    {
        public int id { get; set; }

        public int? iduser { get; set; }

        public int? enable { get; set; }

        public int? idChiNhanh { get; set; }

        public DateTime? updatetime { get; set; }

        public DateTime? dateCreate { get; set; }

        [StringLength(50)]
        public string block1 { get; set; }

        [StringLength(500)]
        public string imageupload { get; set; }

        [StringLength(50)]
        public string MAHS { get; set; }

        [StringLength(500)]
        public string ten { get; set; }

        public DateTime? namsinh { get; set; }

        [StringLength(50)]
        public string sex { get; set; }

        [StringLength(500)]
        public string dienthoai { get; set; }

        [StringLength(500)]
        public string truong { get; set; }

        [StringLength(500)]
        public string matkhau { get; set; }

        [StringLength(500)]
        public string userLog { get; set; }

        [StringLength(500)]
        public string Lop { get; set; }

        [Column(TypeName = "ntext")]
        public string ghichu { get; set; }

        [StringLength(50)]
        public string Block2 { get; set; }

        [StringLength(500)]
        public string PHHS_ten { get; set; }

        [StringLength(500)]
        public string PHHS_ngaysinh { get; set; }

        [StringLength(500)]
        public string PHHS_dienthoai { get; set; }

        [StringLength(500)]
        public string PHHS_facebook { get; set; }

        [StringLength(500)]
        public string PHHS_diachi { get; set; }

        [StringLength(500)]
        public string PHHS_quan { get; set; }

        [StringLength(500)]
        public string email { get; set; }

        [StringLength(500)]
        public string nghenghiep { get; set; }

        [StringLength(500)]
        public string PHHS_quanhe { get; set; }

        [StringLength(500)]
        public string PHHS_mongmuon { get; set; }

        [StringLength(500)]
        public string PHHS_bietqua { get; set; }

        [StringLength(500)]
        public string PHHS_mkt { get; set; }

        public int? type { get; set; }

        public int? Flag { get; set; }

        [StringLength(50)]
        public string Test_L { get; set; }

        [StringLength(50)]
        public string Test_T { get; set; }

        [StringLength(50)]
        public string Test_R { get; set; }

        [StringLength(50)]
        public string Test_W { get; set; }

        [StringLength(500)]
        public string pass_test { get; set; }

        public int? FirstLogin { get; set; }

        [StringLength(500)]
        public string machinhanh { get; set; }

        public int? idnhansu { get; set; }

        public int? status { get; set; }

        public bool? Tunghoc { get; set; }

        public bool? IsUseful { get; set; }

        [StringLength(500)]
        public string PHHS_bietappqua { get; set; }
    }
}
