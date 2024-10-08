using Microsoft.AspNetCore.Identity;
using WebApplication3.ChucNangPhanQuyen;

namespace WebApplication3.Data
{
    public class DataSeed
    {
        public static async Task KhoiTaoDuLieuMacDinh(IServiceProvider dichVu)
        {
            var quaLyNguoiDung = dichVu.GetService<UserManager<IdentityUser>>();
            var quaLyVaiTro = dichVu.GetService<RoleManager<IdentityRole>>();

            // them 1 vai tro vao csdl 
            await quaLyVaiTro.CreateAsync(new IdentityRole(PhanQuyen.Admin.ToString()));
            await quaLyVaiTro.CreateAsync(new IdentityRole(PhanQuyen.User.ToString()));

            // tao thong tin mac dinh cho admin 
            // UserName, Email, xac thuc mail
            var quanTri = new IdentityUser
            {
                UserName = "testadmin@gmail.com",
                Email = "testadmin@gmail.com",
                EmailConfirmed = true,
            };

            var nguoiDungTrongCsdl = await quaLyNguoiDung.FindByEmailAsync(quanTri.Email);
            // neu khong tt trong csdl
            if (nguoiDungTrongCsdl is null)
            {
                //Tao tk admin moi voi mk la 12345
                var ketqua = await quaLyNguoiDung.CreateAsync(quanTri, "Admin12345");
                if (ketqua.Succeeded)
                {
                    await quaLyNguoiDung.AddToRoleAsync(quanTri, PhanQuyen.Admin.ToString());
                }
                else

                    foreach (var loi in ketqua.Errors)
                    {
                        Console.Write(loi.Description);
                    }
            }
        }
    }
}

