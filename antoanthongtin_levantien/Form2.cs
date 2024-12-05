using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace antoanthongtin_levantien
{
    public partial class Form2 : Form
    {
        int[] pc1 = new int[56]
        {
            57, 49, 41, 33, 25, 17, 9,
            1,  58, 50, 42, 34, 26, 18,
            10, 2,  59, 51, 43, 35, 27,
            19, 11, 3,  60, 52, 44, 36,
            63, 55, 47, 39, 31, 23, 15,
            7,  62, 54, 46, 38, 30, 22,
            14, 6,  61, 53, 45, 37, 29,
            21, 13, 5,  28, 20, 12, 4
        };
        int[] pc2 = new int[48]
        {
            14, 17, 11, 24, 1,  5,  3,  28,
            15, 6,  21, 10, 23, 19, 12, 4,
            26, 8,  16, 7,  27, 20, 13, 2,
            41, 52, 31, 37, 47, 55, 30, 40,
            51, 45, 33, 48, 44, 49, 39, 56,
            34, 53, 46, 42, 50, 36, 29, 32
        };
        Dictionary<int, int> dichVong = new Dictionary<int, int>
        {
            {1,1}, {2,1}, {3,2}, {4,2}, {5,2}, {6,2}, {7,2}, {8,2}, {9,1}, {10,2}, {11,2}, {12,2}, {13,2}, {14,2}, {15,2}, {16,1}
        };
        int[] IP = {
            58, 50, 42, 34, 26, 18, 10, 2,
            60, 52, 44, 36, 28, 20, 12, 4,
            62, 54, 46, 38, 30, 22, 14, 6,
            64, 56, 48, 40, 32, 24, 16, 8,
            57, 49, 41, 33, 25, 17, 9, 1,
            59, 51, 43, 35, 27, 19, 11, 3,
            61, 53, 45, 37, 29, 21, 13, 5,
            63, 55, 47, 39, 31, 23, 15, 7
        };
        int[] EP = {
            32, 1, 2, 3, 4, 5, 4, 5,
            6, 7, 8, 9, 8, 9, 10, 11,
            12, 13, 12, 13, 14, 15, 16, 17,
            16, 17, 18, 19, 20, 21, 20, 21,
            22, 23, 24, 25, 24, 25, 26, 27,
            28, 29, 28, 29, 30, 31, 32, 1
        };
        int[] PF = {
            16, 7, 20, 21, 29, 12, 28, 17,
            1, 15, 23, 26, 5, 18, 31, 10,
            2, 8, 24, 14, 32, 27, 3, 9,
            19, 13, 30, 6, 22, 11, 4, 25
        };
        int[] IP1 = {
            40, 8, 48, 16, 56, 24, 64, 32,
            39, 7, 47, 15, 55, 23, 63, 31,
            38, 6, 46, 14, 54, 22, 62, 30,
            37, 5, 45, 13, 53, 21, 61, 29,
            36, 4, 44, 12, 52, 20, 60, 28,
            35, 3, 43, 11, 51, 19, 59, 27,
            34, 2, 42, 10, 50, 18, 58, 26,
            33, 1, 41, 9, 49, 17, 57, 25
        };
        int[,,] Sbox = new int[8, 4, 16]
        {
            // S-box 1
            {
                {14, 4, 13, 1, 2, 15, 11, 8, 3, 10, 6, 12, 5, 9, 0, 7},
                {0, 15, 7, 4, 14, 2, 13, 1, 10, 6, 12, 11, 9, 5, 3, 8},
                {4, 1, 14, 8, 13, 6, 2, 11, 15, 12, 9, 7, 3, 10, 5, 0},
                {15, 12, 8, 2, 4, 9, 1, 7, 5, 11, 3, 14, 10, 0, 6, 13}
            },
            // S-box 2
            {
                {15, 1, 8, 14, 6, 11, 3, 4, 9, 7, 2, 13, 12, 0, 5, 10},
                {3, 13, 4, 7, 15, 2, 8, 14, 12, 0, 1, 10, 6, 9, 11, 5},
                {0, 14, 7, 11, 10, 4, 13, 1, 5, 8, 12, 6, 9, 3, 2, 15},
                {13, 8, 10, 1, 3, 15, 4, 2, 11, 6, 7, 12, 0, 5, 14, 9}
            },
            // S-box 3
            {
                {10, 0, 9, 14, 6, 3, 15, 5, 1, 13, 12, 7, 11, 4, 2, 8},
                {13, 7, 0, 9, 3, 4, 6, 10, 2, 8, 5, 14, 12, 11, 15, 1},
                {13, 6, 4, 9, 8, 15, 3, 0, 11, 1, 2, 12, 5, 10, 14, 7},
                {1, 10, 13, 0, 6, 9, 8, 7, 4, 15, 14, 3, 11, 5, 2, 12}
            },
            // S-box 4
            {
                {7, 13, 14, 3, 0, 6, 9, 10, 1, 2, 8, 5, 11, 12, 4, 15},
                {13, 8, 11, 5, 6, 15, 0, 3, 4, 7, 2, 12, 1, 10, 14, 9},
                {10, 6, 9, 0, 12, 11, 7, 13, 15, 1, 3, 14, 5, 2, 8, 4},
                {3, 15, 0, 6, 10, 1, 13, 8, 9, 4, 5, 11, 12, 7, 2, 14}
            },
            // S-box 5
            {
                {2, 12, 4, 1, 7, 10, 11, 6, 8, 5, 3, 15, 13, 0, 14, 9},
                {14, 11, 2, 12, 4, 7, 13, 1, 5, 0, 15, 10, 3, 9, 8, 6},
                {4, 2, 1, 11, 10, 13, 7, 8, 15, 9, 12, 5, 6, 3, 0, 14},
                {11, 8, 12, 7, 1, 14, 2, 13, 6, 15, 0, 9, 10, 4, 5, 3}
            },
            // S-box 6
            {
                {12, 1, 10, 15, 9, 2, 6, 8, 0, 13, 3, 4, 14, 7, 5, 11},
                {10, 15, 4, 2, 7, 12, 9, 5, 6, 1, 13, 14, 0, 11, 3, 8},
                {9, 14, 15, 5, 2, 8, 12, 3, 7, 0, 4, 10, 1, 13, 11, 6},
                {4, 3, 2, 12, 9, 5, 15, 10, 11, 14, 1, 7, 6, 0, 8, 13}
            },
            // S-box 7
            {
                {4, 11, 2, 14, 15, 0, 8, 13, 3, 12, 9, 7, 5, 10, 6, 1},
                {13, 0, 11, 7, 4, 9, 1, 10, 14, 3, 5, 12, 2, 15, 8, 6},
                {1, 4, 11, 13, 12, 3, 7, 14, 10, 15, 6, 8, 0, 5, 9, 2},
                {6, 11, 13, 8, 1, 4, 10, 7, 9, 5, 0, 15, 14, 2, 3, 12}
            },
            // S-box 8
            {
                {13, 2, 8, 4, 6, 15, 11, 1, 10, 9, 3, 14, 5, 0, 12, 7},
                {1, 15, 13, 8, 10, 3, 7, 4, 12, 5, 6, 11, 0, 14, 9, 2},
                {7, 11, 4, 1, 9, 12, 14, 2, 0, 6, 10, 13, 15, 3, 5, 8},
                {2, 1, 14, 7, 4, 10, 8, 13, 15, 12, 9, 0, 3, 5, 6, 11}
            }
        };

        public Form2()
        {
            InitializeComponent();
        }

        private void mởFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Text Files|*.txt";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    txtBanma1.Text = sr.ReadLine();
                    txtKhoa1.Text = sr.ReadLine();
                    sr.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đọc thất bại");
            }
        }

        private void lưuFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Filter = "Text Files|*.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = File.CreateText(saveFileDialog1.FileName);
                    sw.WriteLine(txtBanro1.Text);
                    sw.WriteLine(txtKhoa1.Text);
                    sw.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lưu thất bại");
            }
        }

        private void mãHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string XOR(string a, string b)
        {
            string result = "";

            for (int i = 0; i < a.Length; i++)
            {
                result += (a[i] == b[i]) ? '0' : '1';
            }

            return result;
        }

        public bool kiemTra()
        {
            if (txtBanma1.Text.Length != 16 || txtKhoa1.Text.Length != 16 || string.IsNullOrEmpty(txtBanma1.Text) || string.IsNullOrEmpty(txtKhoa1.Text))
                return true;
            return false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (kiemTra())
                {
                    MessageBox.Show("Vui lòng nhập lại!");
                    return;
                }
                txtBanro1.Text = "";
                string banmabd = txtBanma1.Text.ToLower();
                string khoabd = txtKhoa1.Text.ToLower();

                //xu ly khoa
                string khoa = "";
                string khoapc1 = "";
                foreach (char c in khoabd)
                {
                    khoapc1 += Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0');
                }

                for (int i = 0; i < 56; i++)
                {
                    khoa += khoapc1[pc1[i] - 1];
                }

                List<string> CD = new List<string>();
                string C = khoa.Substring(0, 28);
                string D = khoa.Substring(28);
                string temp = "";

                for (int i = 1; i < 17; i++)
                {
                    temp = C.Substring(0, dichVong[i]);
                    C = C.Substring(dichVong[i]) + temp;

                    temp = D.Substring(0, dichVong[i]);
                    D = D.Substring(dichVong[i]) + temp;

                    CD.Add(C + D);
                }

                List<string> Ki = new List<string>();
                string kh = "";
                for (int i = 0; i < 16; i++)
                {
                    kh = CD[i];
                    temp = "";
                    for (int j = 0; j < 48; j++)
                    {
                        temp += kh[pc2[j] - 1];
                    }
                    Ki.Add(temp);
                }

                //xu ly ban ma
                string banma = "";
                string banmaip = "";
                foreach (char c in banmabd)
                {
                    banma += Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0');
                }

                for (int i = 0; i < 64; i++)
                {
                    banmaip += banma[IP[i] - 1];
                }

                string sboxstring = "";
                string L = banmaip.Substring(0, 32);
                string R = banmaip.Substring(32);
                string ER = "", P = "";

                for (int i = 15; i >= 0; i--)
                {
                    sboxstring = "";
                    temp = "";
                    ER = "";
                    P = "";
                    for (int j = 0; j < 48; j++)
                    {
                        ER += R[EP[j] - 1];
                    }

                    string er_k = XOR(ER, Ki[i]);
                    int sbox = 0;
                    for (int k = 0; k < 8; k++)
                    {
                        int row = Convert.ToInt32($"{er_k[0]}{er_k[5]}", 2);
                        int col = Convert.ToInt32(er_k.Substring(1, 4), 2);

                        sboxstring += Convert.ToString(Sbox[sbox, row, col], 2).PadLeft(4, '0');
                        sbox++;
                        er_k = er_k.Substring(6);
                    }

                    for (int l = 0; l < 32; l++)
                    {
                        P += sboxstring[PF[l] - 1];
                    }

                    temp = L;
                    L = R;
                    R = XOR(temp, P);
                }

                string kq = "";
                temp = R + L;
                for (int i = 0; i < 64; i++)
                {
                    kq += temp[IP1[i] - 1];
                }

                txtBanro1.Text = Convert.ToString(Convert.ToInt64(kq, 2), 16).ToUpper().PadLeft(16, '0');
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập lại!");
            }
        }
    }
}
