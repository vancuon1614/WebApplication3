﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models
{
    [Table("TheLoai")]
    public class TheLoai
    {
        [Key]
        public int MaTheLoai {  get; set; }
        [MaxLength(50)]
        public string TenTheLoai { get; set; }  
        /*public List<Sach> LishSach { get; set; }*/
        public List<Sach> Saches { get; set; }


    }
}
