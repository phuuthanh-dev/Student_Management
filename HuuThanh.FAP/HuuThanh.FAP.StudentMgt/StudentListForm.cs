namespace HuuThanh.FAP.StudentMgt
{
    public partial class StudentListForm : Form
    {
        List<Student> _ds = new List<Student>();
        public StudentListForm()
        {
            InitializeComponent();
        }

        private void SayHello(object sender, EventArgs e)
        {
            MessageBox.Show("Xin chào. This is 1st message that comes from VS2022 & .NET6",
                "Notification!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        private void SayGoodbye(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Goodbye. Do you really want to exit?",
                "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void OpenImage(object sender, EventArgs e)
        {
            DialogResult result = dlgOpenFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                //MessageBox.Show(dlgOpenFile.FileName);
                lblFileName.Text = "Image: " + dlgOpenFile.FileName;

                picAvatar.Image = new Bitmap(dlgOpenFile.FileName);
            }
        }

        private void pnlImage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadData(object sender, EventArgs e)
        {
            _ds.Add(new Student() { Id = "SE1", Name = "An", Address = "Dương Đông" });
            _ds.Add(new Student() { Id = "SE2", Name = "Dương", Address = "Tân Bình" });
            _ds.Add(new Student() { Id = "SE3", Name = "Dũng", Address = "Tân An" });
            _ds.Add(new Student() { Id = "SE4", Name = "Thành", Address = "Bảo Lộc" });

            dgvStudentList.DataSource = _ds;
        }

        private void ShowAStudent(object sender, EventArgs e)
        {
            // ta sẽ xài các hàm, thuộc tính của dgv qua dấu .
            // toàn bộ những gì trên form đều là các object trỏ vùng new
            // DataGridView dgv = new DataGridView();
            //              dgv.DataSource = danh sách sv;
            //              dgv.Click += chừa chỗ cái hàm của ai đó
            //              dgv.Click thì làm gì, gọi hàm này
            //              xài các chấm khác để biết dòng nào được chọn, lấy từng cell
            if (dgvStudentList.SelectedRows.Count > 0)
            {
                // lấy ra dòng đầu tiên trong nhiều dòng vừa chọn,
                // trích từng cell ra, 3 cells
                DataGridViewRow selectedRow = dgvStudentList.SelectedRows[0];
                txtId.Text = selectedRow.Cells[0].Value.ToString();
                txtName.Text = selectedRow.Cells[1].Value.ToString();
                txtAddress.Text = selectedRow.Cells[2].Value.ToString();

            }
        }

        private void AddNewStudent(object sender, EventArgs e)
        {
            Student x = new Student();
            x.Id = txtId.Text;
            x.Name = txtName.Text;
            x.Address = txtAddress.Text;
            _ds.Add(x);
            //refresh cái grid
            dgvStudentList.DataSource = null;
            dgvStudentList.DataSource = _ds;
        }

        private void SearchStudents(object sender, EventArgs e)
        {
            dgvResult.DataSource = null;
            string keyword = txtKeyword.Text.ToLower();
            List<Student> result = _ds.Where(xxx =>
            {
                return (xxx.Name.ToLower().Contains(keyword)) || (xxx.Address.ToLower().Contains(keyword));
            }
            ).ToList();
            dgvResult.DataSource = result;
        }
    }
}
