using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Drawing;

namespace QLNK
{
    public partial class SuaTienAnTienSu : MaterialForm
    {
        readonly SourceCode _sourceCode = new SourceCode();
        private readonly string[] _itemTienAnTienSu;
        private bool _flagSave;
        public SuaTienAnTienSu(string[] itemTienAnTienSu)
        {
            InitializeComponent();
            _itemTienAnTienSu = itemTienAnTienSu;
            SetNormal(itemTienAnTienSu);
        }

        private void SetNormal(string[] items)
        {
            txtMaNhanKhau.Text = items[1];
            txtTenTienAnTienSu.Text = items[2];
            cbQueQuan.Text = items[3];
            var arr = items[4].Split('/');
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
        }

        private void btnSuaTienAnTienSu_Click(object sender, EventArgs e)
        {
            var ngay = cbNgay.Text;
            var thang = cbThang.Text;
            var nam = cbNam.Text;

            var maTienAnTienSu = _itemTienAnTienSu[0];
            var maNhanKhau = txtMaNhanKhau.Text;
            var tenTienAnTienSu = txtTenTienAnTienSu.Text;
            var noiXetXu = cbQueQuan.Text;
            var ngayThucThi = ngay + "/" + thang + "/" + nam;
            if (!(maTienAnTienSu.Equals("") || maNhanKhau.Equals("") || tenTienAnTienSu.Equals("") ||
                  noiXetXu.Equals("")       || ngay.Equals("")       || thang.Equals("")           ||
                  nam.Equals("")))
            {
                var dialogResult = MessageBox.Show(_sourceCode.MsgboxUpdate,_sourceCode.MsgboxCapUpdate, MessageBoxButtons.YesNo);
                if (dialogResult != DialogResult.Yes) return;
                _flagSave = true;
                if (!_sourceCode.UpdateTienAnTienSu(maTienAnTienSu, maNhanKhau, tenTienAnTienSu, noiXetXu, ngayThucThi)) return;
                Close();
                MessageBox.Show(_sourceCode.SuccessUpdate);
            }
            else
            {
                MessageBox.Show(_sourceCode.ErrorBlank);
            }
        }

        private void SuaTienAnTienSu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_flagSave) return;
            var ngay = cbNgay.Text;
            var thang = cbThang.Text;
            var nam = cbNam.Text;

            var maTienAnTienSu = _itemTienAnTienSu[0];
            var maNhanKhau = txtMaNhanKhau.Text;
            var tenTienAnTienSu = txtTenTienAnTienSu.Text;
            var noiXetXu = cbQueQuan.Text;
            var ngayThucThi = ngay + "/" + thang + "/" + nam;
            if ((maTienAnTienSu.Equals(_itemTienAnTienSu[0]) && maNhanKhau.Equals(_itemTienAnTienSu[1]) &&
                 tenTienAnTienSu.Equals(_itemTienAnTienSu[2]) && noiXetXu.Equals(_itemTienAnTienSu[3]) &&
                 ngayThucThi.Equals(_itemTienAnTienSu[4]))) return;
            var dialogResult = MessageBox.Show(_sourceCode.MsgboxUpdate,
                _sourceCode.MsgboxCapExit,
                MessageBoxButtons.YesNoCancel);
            switch (dialogResult)
            {
                case DialogResult.Yes:
                    if (!(maTienAnTienSu.Equals("") || maNhanKhau.Equals("")||
                          tenTienAnTienSu.Equals("")|| noiXetXu.Equals("")  ||
                          ngay.Equals("")           || thang.Equals("")     || nam.Equals("")))
                    {
                        if (_sourceCode.UpdateTienAnTienSu(maTienAnTienSu, maNhanKhau, tenTienAnTienSu,
                            noiXetXu, ngayThucThi))
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
                    var command = message.WParam.ToInt32() & 0xfff0;
                    if (command == scMove)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }

        private void txtMaNhanKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtTenTienAnTienSu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtMaNhanKhau_TextChanged(object sender, EventArgs e)
        {
            label1.Visible = txtMaNhanKhau.Text != _itemTienAnTienSu[1];
        }

        private void txtTenTienAnTienSu_TextChanged(object sender, EventArgs e)
        {
            label2.Visible = txtTenTienAnTienSu.Text != _itemTienAnTienSu[2];
        }

        private void cbQueQuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Visible = cbQueQuan.Text != _itemTienAnTienSu[3];
        }

        private void cbNgay_SelectedIndexChanged(object sender, EventArgs e)
        {
            var str = _itemTienAnTienSu[4].Split('/');
            label4.Visible = cbNgay.Text != str[0];
        }

        private void cbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            var str = _itemTienAnTienSu[4].Split('/');
            label4.Visible = cbThang.Text != str[1];
        }

        private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            var str = _itemTienAnTienSu[4].Split('/');
            label4.Visible = cbNam.Text != str[2];
        }

        private void btnNhanKhau_Click(object sender, EventArgs e)
        {
            Location = new Point(188, 171);
            var nk = new NhanKhau();
            nk.ShowDialog();
            if (!nk.GetMnk().Equals("") && nk.GetFlagSave())
            {
                txtMaNhanKhau.Text = nk.GetMnk();
            }
            CenterToScreen();
        }
    }
}
