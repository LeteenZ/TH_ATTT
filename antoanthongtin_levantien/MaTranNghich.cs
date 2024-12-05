using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antoanthongtin_levantien
{
    internal class MaTranNghich
    {
        public MaTranNghich()
        {
        }
        public int TinhDinhThuc(int[,] mt, int n)
        {
            // Nếu ma trận có kích thước 1x1, định thức là phần tử duy nhất. Trả về phần tử duy nhất của ma trận theo modulo 26
            if (n == 1)
            {
                return mt[0, 0] % 26;
            }

            // Khởi tạo biến để lưu trữ giá trị định thức
            long det = 0;
            for (int j = 0; j < n; j++)
            {
                // Cộng vào định thức giá trị của phần tử đầu dòng nhân với định thức của ma trận con
                det += (long)(mt[0, j] * maTranCon(mt, 0, j, n)) % 26;
            }

            // Kiểm tra nếu định thức là âm và điều chỉnh để đảm bảo nó trong phạm vi [0, 25]
            while (det < 0)
                det += 26;

            return (int)det % 26;
        }
        public int maTranCon(int[,] mt, int hang, int cot, int n)
        {
            // Nếu ma trận có kích thước 1x1, trả về phần tử duy nhất. Trả về phần tử duy nhất của ma trận theo modulo 26
            if (n == 1)
            {
                return mt[0, 0] % 26;
            }

            // Khởi tạo ma trận con có kích thước (n-1)x(n-1)
            int[,] mtcon = new int[n - 1, n - 1];
            //khởi tạo vị trí từ 0,0 đến n-1,n-1 khi loại bỏ đi hang, cot được cho
            int mHang = 0, mCot = 0;

            // Lặp qua tất cả các phần tử trong ma trận ban đầu
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // Nếu phần tử không nằm trong hàng 'hang' và cột 'cot', thì thêm vào ma trận con
                    if (i != hang && j != cot)
                    {
                        mtcon[mHang, mCot] = mt[i, j];
                        mCot++;

                        // Nếu đã đi hết một cột, chuyển sang hàng tiếp theo
                        if (mCot == n - 1)
                        {
                            mCot = 0;
                            mHang++;
                        }
                    }
                }
            }

            // Tính dấu của ma trận con, phụ thuộc vào chỉ số hàng và cột
            int s = ((hang + cot) % 2 == 0) ? 1 : -1;

            // Tính định thức của ma trận con và áp dụng dấu
            int kq = s * TinhDinhThuc(mtcon, n - 1);

            // Kiểm tra nếu kq là âm và điều chỉnh để đảm bảo nó trong phạm vi [0, 25]
            while (kq < 0)
                kq += 26;

            return kq % 26;
        }
        public int[,] MaTranNghichDao(int[,] mt, int det_1, int n)
        {
            // Khởi tạo ma trận phụ có kích thước n x n
            int[,] maTranPhu = new int[n, n];

            // Tính ma trận phụ chuyển vị
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // Lấy định thức của ma trận con tương ứng và chuyển vị
                    maTranPhu[j, i] = maTranCon(mt, i, j, n);
                }
            }

            // Nhân với phần tử nghịch đảo của định thức
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // Nhân mỗi phần tử trong ma trận phụ với phần tử nghịch đảo của định thức (mod 26)
                    maTranPhu[i, j] = (maTranPhu[i, j] * det_1);

                    // Kiểm tra nếu giá trị là âm và điều chỉnh
                    while (maTranPhu[i, j] < 0)
                        maTranPhu[i, j] += 26;

                    // Đảm bảo giá trị trong phạm vi [0, 25]
                    maTranPhu[i, j] %= 26;
                }
            }

            return maTranPhu;
        }
    }
}