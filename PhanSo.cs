using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PhanSo
    {

        private int tuSo;
        private int mauSo;

        // Constructor
        public PhanSo(int tuSo, int mauSo)
        {
            if (mauSo == 0)
            {
                throw new ArgumentException("Mẫu số không được bằng 0.");
            }
            this.tuSo = tuSo;
            this.mauSo = mauSo;
            RutGon();
        }

        // Phương thức rút gọn phân số
        private void RutGon()
        {
            int gcd = GCD(tuSo, mauSo);
            tuSo /= gcd;
            mauSo /= gcd;
        }

        // Tính ước chung lớn nhất
        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Phương thức cộng
        public PhanSo Cong(PhanSo ps)
        {
            int tu = this.tuSo * ps.mauSo + ps.tuSo * this.mauSo;
            int mau = this.mauSo * ps.mauSo;
            return new PhanSo(tu, mau);
        }

        // Phương thức trừ
        public PhanSo Tru(PhanSo ps)
        {
            int tu = this.tuSo * ps.mauSo - ps.tuSo * this.mauSo;
            int mau = this.mauSo * ps.mauSo;
            return new PhanSo(tu, mau);
        }

        // Phương thức nhân
        public PhanSo Nhan(PhanSo ps)
        {
            int tu = this.tuSo * ps.tuSo;
            int mau = this.mauSo * ps.mauSo;
            return new PhanSo(tu, mau);
        }

        // Phương thức chia
        public PhanSo Chia(PhanSo ps)
        {
            if (ps.tuSo == 0)
            {
                throw new DivideByZeroException("Chia cho phân số có tử số bằng 0.");
            }
            int tu = this.tuSo * ps.mauSo;
            int mau = this.mauSo * ps.tuSo;
            return new PhanSo(tu, mau);
        }

        // Phương thức kiểm tra phân số có bằng nhau không
        public bool BangNhau(PhanSo ps)
        {
            return this.tuSo == ps.tuSo && this.mauSo == ps.mauSo;
        }

        // Phương thức in phân số
        public override string ToString()
        {
            return $"{tuSo}/{mauSo}";
        }
    }
    }

