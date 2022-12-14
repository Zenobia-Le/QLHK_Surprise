using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Drawing;

namespace QLNK
{
    public partial class SuaNhanKhau : MaterialForm
    {
        readonly SourceCode _sourceCode = new SourceCode();
        private readonly string[] _itemNhanKhau;
        private bool _flagSave;
        public SuaNhanKhau(string[] itemNhanKhau)
        {
            InitializeComponent();
            _itemNhanKhau = itemNhanKhau;
            SetNormal(itemNhanKhau);
        }

        private void SetNormal(string[] items)
        {
            txtHoTen.Text = items[1];
            var arr = items[2].Split('/');
            switch (arr[0])
            {
                case "01": cbNgay.SelectedIndex = 0; break;
                case "02": cbNgay.SelectedIndex = 1; break;
                case "03": cbNgay.SelectedIndex = 2; break;
                case "04": cbNgay.SelectedIndex = 3; break;
                case "05": cbNgay.SelectedIndex = 4; break;
                case "06": cbNgay.SelectedIndex = 5; break;
                case "07": cbNgay.SelectedIndex = 6; break;
                case "08": cbNgay.SelectedIndex = 7; break;
                case "09": cbNgay.SelectedIndex = 8; break;
                case "10": cbNgay.SelectedIndex = 9; break;
                case "11": cbNgay.SelectedIndex = 10; break;
                case "12": cbNgay.SelectedIndex = 11; break;
                case "13": cbNgay.SelectedIndex = 12; break;
                case "14": cbNgay.SelectedIndex = 13; break;
                case "15": cbNgay.SelectedIndex = 14; break;
                case "16": cbNgay.SelectedIndex = 15; break;
                case "17": cbNgay.SelectedIndex = 16; break;
                case "18": cbNgay.SelectedIndex = 17; break;
                case "19": cbNgay.SelectedIndex = 18; break;
                case "20": cbNgay.SelectedIndex = 19; break;
                case "21": cbNgay.SelectedIndex = 20; break;
                case "22": cbNgay.SelectedIndex = 21; break;
                case "23": cbNgay.SelectedIndex = 22; break;
                case "24": cbNgay.SelectedIndex = 23; break;
                case "25": cbNgay.SelectedIndex = 24; break;
                case "26": cbNgay.SelectedIndex = 25; break;
                case "27": cbNgay.SelectedIndex = 26; break;
                case "28": cbNgay.SelectedIndex = 27; break;
                case "29": cbNgay.SelectedIndex = 28; break;
                case "30": cbNgay.SelectedIndex = 29; break;
                case "31": cbNgay.SelectedIndex = 30; break;
            }
            switch (arr[1])
            {
                case "01": cbThang.SelectedIndex = 0; break;
                case "02": cbThang.SelectedIndex = 1; break;
                case "03": cbThang.SelectedIndex = 2; break;
                case "04": cbThang.SelectedIndex = 3; break;
                case "05": cbThang.SelectedIndex = 4; break;
                case "06": cbThang.SelectedIndex = 5; break;
                case "07": cbThang.SelectedIndex = 6; break;
                case "08": cbThang.SelectedIndex = 7; break;
                case "09": cbThang.SelectedIndex = 8; break;
                case "10": cbThang.SelectedIndex = 9; break;
                case "11": cbThang.SelectedIndex = 10; break;
                case "12": cbThang.SelectedIndex = 11; break;
            }
            switch (arr[2])
            {
                case "1960": cbNam.SelectedIndex = 0; break;
                case "1961": cbNam.SelectedIndex = 1; break;
                case "1962": cbNam.SelectedIndex = 2; break;
                case "1963": cbNam.SelectedIndex = 3; break;
                case "1964": cbNam.SelectedIndex = 4; break;
                case "1965": cbNam.SelectedIndex = 5; break;
                case "1966": cbNam.SelectedIndex = 6; break;
                case "1967": cbNam.SelectedIndex = 7; break;
                case "1968": cbNam.SelectedIndex = 8; break;
                case "1969": cbNam.SelectedIndex = 9; break;
                case "1970": cbNam.SelectedIndex = 10; break;
                case "1971": cbNam.SelectedIndex = 11; break;
                case "1972": cbNam.SelectedIndex = 12; break;
                case "1973": cbNam.SelectedIndex = 13; break;
                case "1974": cbNam.SelectedIndex = 14; break;
                case "1975": cbNam.SelectedIndex = 15; break;
                case "1976": cbNam.SelectedIndex = 16; break;
                case "1977": cbNam.SelectedIndex = 17; break;
                case "1978": cbNam.SelectedIndex = 18; break;
                case "1979": cbNam.SelectedIndex = 19; break;
                case "1980": cbNam.SelectedIndex = 20; break;
                case "1981": cbNam.SelectedIndex = 21; break;
                case "1982": cbNam.SelectedIndex = 22; break;
                case "1983": cbNam.SelectedIndex = 23; break;
                case "1984": cbNam.SelectedIndex = 24; break;
                case "1985": cbNam.SelectedIndex = 25; break;
                case "1986": cbNam.SelectedIndex = 26; break;
                case "1987": cbNam.SelectedIndex = 27; break;
                case "1988": cbNam.SelectedIndex = 28; break;
                case "1989": cbNam.SelectedIndex = 29; break;
                case "1990": cbNam.SelectedIndex = 30; break;
                case "1991": cbNam.SelectedIndex = 31; break;
                case "1992": cbNam.SelectedIndex = 32; break;
                case "1993": cbNam.SelectedIndex = 33; break;
                case "1994": cbNam.SelectedIndex = 34; break;
                case "1995": cbNam.SelectedIndex = 35; break;
                case "1996": cbNam.SelectedIndex = 36; break;
                case "1997": cbNam.SelectedIndex = 37; break;
                case "1998": cbNam.SelectedIndex = 38; break;
                case "1999": cbNam.SelectedIndex = 39; break;
                case "2000": cbNam.SelectedIndex = 40; break;
                case "2001": cbNam.SelectedIndex = 41; break;
                case "2002": cbNam.SelectedIndex = 42; break;
                case "2003": cbNam.SelectedIndex = 43; break;
                case "2004": cbNam.SelectedIndex = 44; break;
                case "2005": cbNam.SelectedIndex = 45; break;
                case "2006": cbNam.SelectedIndex = 46; break;
                case "2007": cbNam.SelectedIndex = 47; break;
                case "2008": cbNam.SelectedIndex = 48; break;
                case "2009": cbNam.SelectedIndex = 49; break;
                case "2010": cbNam.SelectedIndex = 50; break;
                case "2011": cbNam.SelectedIndex = 51; break;
                case "2012": cbNam.SelectedIndex = 52; break;
                case "2013": cbNam.SelectedIndex = 53; break;
                case "2014": cbNam.SelectedIndex = 54; break;
                case "2015": cbNam.SelectedIndex = 55; break;
            }
            switch (items[4])
            {
                case "An Giang": cbQueQuan.SelectedIndex = 0; break;
                case "Bà Rịa - Vũng Tàu": cbQueQuan.SelectedIndex = 1; break;
                case "Bạc Liêu": cbQueQuan.SelectedIndex = 2; break;
                case "Bắc Kạn": cbQueQuan.SelectedIndex = 3; break;
                case "Bắc Giang": cbQueQuan.SelectedIndex = 4; break;
                case "Bắc Ninh": cbQueQuan.SelectedIndex = 5; break;
                case "Bến Tre": cbQueQuan.SelectedIndex = 6; break;
                case "Bình Dương": cbQueQuan.SelectedIndex = 7; break;
                case "Bình Định": cbQueQuan.SelectedIndex = 8; break;
                case "Bình Phước": cbQueQuan.SelectedIndex = 9; break;
                case "Bình Thuận": cbQueQuan.SelectedIndex = 10; break;
                case "Cà Mau": cbQueQuan.SelectedIndex = 11; break;
                case "Cao Bằng": cbQueQuan.SelectedIndex = 12; break;
                case "Cần Thơ": cbQueQuan.SelectedIndex = 13; break;
                case "Đà Nẵng": cbQueQuan.SelectedIndex = 14; break;
                case "Đắk Lắk": cbQueQuan.SelectedIndex = 15; break;
                case "Đắk Nông": cbQueQuan.SelectedIndex = 16; break;
                case "Đồng Nai": cbQueQuan.SelectedIndex = 17; break;
                case "Đồng Tháp": cbQueQuan.SelectedIndex = 18; break;
                case "Điện Biên": cbQueQuan.SelectedIndex = 19; break;
                case "Gia Lai": cbQueQuan.SelectedIndex = 20; break;
                case "Hà Giang": cbQueQuan.SelectedIndex = 21; break;
                case "Hà Nam": cbQueQuan.SelectedIndex = 22; break;
                case "Hà Nội": cbQueQuan.SelectedIndex = 23; break;
                case "Hà Tĩnh": cbQueQuan.SelectedIndex = 24; break;
                case "Hải Dương": cbQueQuan.SelectedIndex = 25; break;
                case "Hải Phòng": cbQueQuan.SelectedIndex = 26; break;
                case "Hòa Bình": cbQueQuan.SelectedIndex = 27; break;
                case "Hậu Giang": cbQueQuan.SelectedIndex = 28; break;
                case "Hưng Yên": cbQueQuan.SelectedIndex = 29; break;
                case "TPHCM": cbQueQuan.SelectedIndex = 30; break;
                case "Khánh Hòa": cbQueQuan.SelectedIndex = 31; break;
                case "Kiên Giang": cbQueQuan.SelectedIndex = 32; break;
                case "Kon Tum": cbQueQuan.SelectedIndex = 33; break;
                case "Lai Châu": cbQueQuan.SelectedIndex = 34; break;
                case "Lào Cai": cbQueQuan.SelectedIndex = 35; break;
                case "Lạng Sơn": cbQueQuan.SelectedIndex = 36; break;
                case "Lâm Đồng": cbQueQuan.SelectedIndex = 37; break;
                case "Long An": cbQueQuan.SelectedIndex = 38; break;
                case "Nam Định": cbQueQuan.SelectedIndex = 39; break;
                case "Nghệ An": cbQueQuan.SelectedIndex = 40; break;
                case "Ninh Bình": cbQueQuan.SelectedIndex = 41; break;
                case "Ninh Thuận": cbQueQuan.SelectedIndex = 42; break;
                case "Phú Thọ": cbQueQuan.SelectedIndex = 43; break;
                case "Phú Yên": cbQueQuan.SelectedIndex = 44; break;
                case "Quảng Bình": cbQueQuan.SelectedIndex = 45; break;
                case "Quảng Nam": cbQueQuan.SelectedIndex = 46; break;
                case "Quảng Ngãi": cbQueQuan.SelectedIndex = 47; break;
                case "Quảng Ninh": cbQueQuan.SelectedIndex = 48; break;
                case "Quảng Trị": cbQueQuan.SelectedIndex = 49; break;
                case "Sóc Trăng": cbQueQuan.SelectedIndex = 50; break;
                case "Sơn La": cbQueQuan.SelectedIndex = 51; break;
                case "Tây Ninh": cbQueQuan.SelectedIndex = 52; break;
                case "Thái Bình": cbQueQuan.SelectedIndex = 53; break;
                case "Thái Nguyên": cbQueQuan.SelectedIndex = 54; break;
                case "Thanh Hóa": cbQueQuan.SelectedIndex = 55; break;
                case "Thừa Thiên Huế": cbQueQuan.SelectedIndex = 56; break;
                case "Tiền Giang": cbQueQuan.SelectedIndex = 57; break;
                case "Trà Vinh": cbQueQuan.SelectedIndex = 58; break;
                case "Tuyên Quang": cbQueQuan.SelectedIndex = 59; break;
                case "Vĩnh Long": cbQueQuan.SelectedIndex = 60; break;
                case "Vĩnh Phúc": cbQueQuan.SelectedIndex = 61; break;
                case "Yên Bái": cbQueQuan.SelectedIndex = 62; break;
            }
            switch (items[5])
            {
                case "Phật giáo": cbTonGiao.SelectedIndex = 0; break;
                case "Công giáo": cbTonGiao.SelectedIndex = 1; break;
                case "Tin Lành": cbTonGiao.SelectedIndex = 2; break;
                case "Cao Đài": cbTonGiao.SelectedIndex = 3; break;
                case "Hồi giáo": cbTonGiao.SelectedIndex = 4; break;
                case "Bahá í": cbTonGiao.SelectedIndex = 5; break;
                case "Minh Sư Đạo": cbTonGiao.SelectedIndex = 6; break;
                case "Minh Lý Đạo": cbTonGiao.SelectedIndex = 7; break;
            }
            switch (items[6])
            {
                case "Kinh": cbDanToc.SelectedIndex = 0; break;
                case "Tày": cbDanToc.SelectedIndex = 1; break;
                case "Thái": cbDanToc.SelectedIndex = 2; break;
                case "Mường": cbDanToc.SelectedIndex = 3; break;
                case "Khơ Me": cbDanToc.SelectedIndex = 4; break;
                case "HMông": cbDanToc.SelectedIndex = 5; break;
                case "Nùng": cbDanToc.SelectedIndex = 6; break;
                case "Hoa": cbDanToc.SelectedIndex = 7; break;
                case "Dao": cbDanToc.SelectedIndex = 8; break;
                case "Gia Rai": cbDanToc.SelectedIndex = 9; break;
                case "Ê Đê": cbDanToc.SelectedIndex = 10; break;
                case "Ba Na": cbDanToc.SelectedIndex = 11; break;
                case "Xơ Đăng": cbDanToc.SelectedIndex = 12; break;
                case "Sán Chay": cbDanToc.SelectedIndex = 13; break;
                case "Cơ Ho": cbDanToc.SelectedIndex = 14; break;
                case "Chăm": cbDanToc.SelectedIndex = 15; break;
                case "Sán Dìu": cbDanToc.SelectedIndex = 16; break;
                case "Hrê": cbDanToc.SelectedIndex = 17; break;
                case "Ra Glai": cbDanToc.SelectedIndex = 18; break;
                case "MNông": cbDanToc.SelectedIndex = 19; break;
                case "XTiêng": cbDanToc.SelectedIndex = 20; break;
                case "Bru-Vân Kiều": cbDanToc.SelectedIndex = 21; break;
                case "Thổ": cbDanToc.SelectedIndex = 22; break;
                case "Khơ Mú": cbDanToc.SelectedIndex = 23; break;
                case "Cơ Tu": cbDanToc.SelectedIndex = 24; break;
                case "Giáy": cbDanToc.SelectedIndex = 25; break;
                case "Giẻ Triêng": cbDanToc.SelectedIndex = 26; break;
                case "Tà Ôi": cbDanToc.SelectedIndex = 27; break;
                case "Mạ": cbDanToc.SelectedIndex = 28; break;
                case "Co": cbDanToc.SelectedIndex = 29; break;
                case "Chơ Ro": cbDanToc.SelectedIndex = 30; break;
                case "Xinh Mun": cbDanToc.SelectedIndex = 31; break;
                case "Hà Nhì": cbDanToc.SelectedIndex = 32; break;
                case "Chu Ru": cbDanToc.SelectedIndex = 33; break;
                case "Lào": cbDanToc.SelectedIndex = 34; break;
                case "Kháng": cbDanToc.SelectedIndex = 35; break;
                case "La Chí": cbDanToc.SelectedIndex = 36; break;
                case "Phú Lá": cbDanToc.SelectedIndex = 37; break;
                case "La Hủ": cbDanToc.SelectedIndex = 38; break;
                case "La Ha": cbDanToc.SelectedIndex = 39; break;
                case "Pà Thẻn": cbDanToc.SelectedIndex = 40; break;
                case "Chứt": cbDanToc.SelectedIndex = 41; break;
                case "Lự": cbDanToc.SelectedIndex = 42; break;
                case "Lô Lô": cbDanToc.SelectedIndex = 43; break;
                case "Mảng": cbDanToc.SelectedIndex = 44; break;
                case "Cờ Lao": cbDanToc.SelectedIndex = 45; break;
                case "Bố Y": cbDanToc.SelectedIndex = 46; break;
                case "Cống": cbDanToc.SelectedIndex = 47; break;
                case "Ngái": cbDanToc.SelectedIndex = 48; break;
                case "Si La": cbDanToc.SelectedIndex = 49; break;
                case "Pu Péo": cbDanToc.SelectedIndex = 50; break;
                case "Rơ măm": cbDanToc.SelectedIndex = 51; break;
                case "Brâu": cbDanToc.SelectedIndex = 52; break;
                case "Ơ Đu": cbDanToc.SelectedIndex = 53; break;
                case "Thành phần khác": cbDanToc.SelectedIndex = 54; break;
            }
            txtCMND.Text = items[7];
            txtMaHoKhau.Text = items[8];
            txtNgheNghiep.Text = items[9];
            switch (items[3])
            {
                case "Nam": rdNam.Checked = true; break;
                case "Nữ": rdNu.Checked = true; break;
            }
        }

        private void btnSuaNhanKhau_Click(object sender, EventArgs e)
        {
            string maNhanKhau = _itemNhanKhau[0];
            string hoTen = txtHoTen.Text;
            string ngay = cbNgay.Text;
            string thang = cbThang.Text;
            string nam = cbNam.Text;
            string ngaySinh = ngay + "/" + thang + "/" + nam;
            string gioiTinh = (rdNam.Checked && !rdNu.Checked) ? "Nam" : "Nữ";
            string danToc = cbDanToc.Text;
            string queQuan = cbQueQuan.Text;
            string tonGiao = cbTonGiao.Text;
            string cmnd = txtCMND.Text;
            string maHoKhau = txtMaHoKhau.Text;
            string ngheNghiep = txtNgheNghiep.Text;

            if (!(maNhanKhau.Equals("") || hoTen.Equals("") || (!rdNam.Checked && !rdNu.Checked) ||
                  ngay.Equals("") || thang.Equals("") || nam.Equals("") || danToc.Equals("") ||
                  queQuan.Equals("") || tonGiao.Equals("") || cmnd.Equals("") ||
                  maHoKhau.Equals("") || ngheNghiep.Equals("")))
            {
                var dialogResult = MessageBox.Show(_sourceCode.MsgboxUpdate, _sourceCode.MsgboxCapUpdate, MessageBoxButtons.YesNo);
                if (dialogResult != DialogResult.Yes) return;
                _flagSave = true;
                if (!_sourceCode.UpdateNhanKhau(maNhanKhau, hoTen, ngaySinh, gioiTinh, queQuan, tonGiao, danToc, cmnd, maHoKhau, ngheNghiep))
                    return;
                Close();
                MessageBox.Show(_sourceCode.SuccessUpdate);
            }
            else
            {
                MessageBox.Show(_sourceCode.ErrorBlank);
            }
        }

        private void SuaNhanKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_flagSave) return;
            var ngay = cbNgay.Text;
            var thang = cbThang.Text;
            var nam = cbNam.Text;
            var maNhanKhau = _itemNhanKhau[0];
            var hoTen = txtHoTen.Text;
            var ngaySinh = ngay + "/" + thang + "/" + nam;
            var gioiTinh = (rdNam.Checked && !rdNu.Checked) ? "Nam" : "Nữ";
            var danToc = cbDanToc.Text;
            var queQuan = cbQueQuan.Text;
            var tonGiao = cbTonGiao.Text;
            var cmnd = txtCMND.Text;
            var maHoKhau = txtMaHoKhau.Text;
            var ngheNghiep = txtNgheNghiep.Text;

            if ((maNhanKhau.Equals(_itemNhanKhau[0]) && hoTen.Equals(_itemNhanKhau[1]) && ngaySinh.Equals(_itemNhanKhau[2]) &&
                 gioiTinh.Equals(_itemNhanKhau[3]) && queQuan.Equals(_itemNhanKhau[4]) && tonGiao.Equals(_itemNhanKhau[5]) &&
                 danToc.Equals(_itemNhanKhau[6]) && cmnd.Equals(_itemNhanKhau[7]) && maHoKhau.Equals(_itemNhanKhau[8]) &&
                 ngheNghiep.Equals(_itemNhanKhau[9])))
                return;
            var dialogResult = MessageBox.Show(_sourceCode.MsgboxUpdate, _sourceCode.MsgboxCapExit, MessageBoxButtons.YesNoCancel);
            switch (dialogResult)
            {
                case DialogResult.Yes:
                    if (!(maNhanKhau.Equals("") || hoTen.Equals("")     || (!rdNam.Checked && !rdNu.Checked)    ||
                          ngay.Equals("")       || thang.Equals("")     || nam.Equals("")   || danToc.Equals("")||
                          queQuan.Equals("")    || tonGiao.Equals("")   || cmnd.Equals("")  ||
                          maHoKhau.Equals("")   || ngheNghiep.Equals("")))
                    {
                        if (_sourceCode.UpdateNhanKhau(maNhanKhau, hoTen, ngaySinh, gioiTinh, queQuan,
                            tonGiao, danToc, cmnd, maHoKhau, ngheNghiep))
                        {
                            MessageBox.Show(_sourceCode.SuccessUpdate);
                        }
                    }
                    else
                    {
                        MessageBox.Show(_sourceCode.ErrorBlank);
                        e.Cancel = true;
                    }
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }

        //---------------------------------------------------------Prevent form from moving

        protected override void WndProc(ref Message message)
        {
            const int wmSyscommand = 0x0112;
            const int scMove = 0xF010;

            switch (message.Msg)
            {
                case wmSyscommand:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == scMove)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtMaHoKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        
        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            label1.Visible = txtHoTen.Text != _itemNhanKhau[1];
        }

        private void cbNgay_SelectedIndexChanged(object sender, EventArgs e)
        {
            var str = _itemNhanKhau[2].Split('/');
            label2.Visible = cbNgay.Text != str[0];
        }

        private void cbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            var str = _itemNhanKhau[2].Split('/');
            label2.Visible = cbThang.Text != str[1];
        }

        private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            var str = _itemNhanKhau[2].Split('/');
            label2.Visible = cbNam.Text != str[2];
        }

        private void cbQueQuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Visible = cbQueQuan.Text != _itemNhanKhau[4];
        }

        private void cbDanToc_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Visible = cbDanToc.Text != _itemNhanKhau[6];
        }

        private void cbTonGiao_SelectedIndexChanged(object sender, EventArgs e)
        {
            label6.Visible = cbTonGiao.Text != _itemNhanKhau[5];
        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            var isGender = _itemNhanKhau[3].Equals("Nam");
            label4.Visible = (rdNam.Checked == false && isGender) || (rdNam.Checked && isGender == false);
        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {
            var isGender = _itemNhanKhau[3].Equals("Nữ");
            label4.Visible = (rdNu.Checked == false && isGender) || (rdNu.Checked && isGender == false);
        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {
            label7.Visible = txtCMND.Text != _itemNhanKhau[7];
        }

        private void txtMaHoKhau_TextChanged(object sender, EventArgs e)
        {
            label8.Visible = txtMaHoKhau.Text != _itemNhanKhau[8];
        }

        private void txtNgheNghiep_TextChanged(object sender, EventArgs e)
        {
            label9.Visible = txtNgheNghiep.Text != _itemNhanKhau[9];
        }

        private void btnHoKhau_Click(object sender, EventArgs e)
        {
            Location = new Point(188, 121);
            var hk = new HoKhau();
            hk.ShowDialog();
            if (!hk.GetMhk().Equals("") && hk.GetFlagSave())
            {
                txtMaHoKhau.Text = hk.GetMhk();
            }
            CenterToScreen();
        }
    }
}
