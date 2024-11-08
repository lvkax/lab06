namespace lab06
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void cbPyramid_Checked(object sender, EventArgs e)
        {
            cbSphere.Checked = false;
            lbHeight.Visible = true;
            tbHeight.Visible = true;
            lbLenOrRad.Text = "¬вед≥ть довжину:";
        }

        private void cbSphere_Checked(object sender, EventArgs e)
        {
            cbPyramid.Checked = false;
            lbHeight.Visible = false;
            tbHeight.Visible = false;
            lbLenOrRad.Text = "¬вед≥ть рад≥ус";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (cbPyramid.Checked == true)
            {

                double a = double.Parse(tbLenOrRad.Text);
                double h = double.Parse(tbHeight.Text);
                iSolid pyramid = new Pyramid(a, h);
                string VolPyr = pyramid.GetVolume().ToString();
                tbVolume.Text = VolPyr;
            }
            else if (cbSphere.Checked == true)
            {
                double r = double.Parse(tbLenOrRad.Text);
                iSolid sphere = new Sphere(r);
                string VolSp = sphere.GetVolume().ToString();
                tbVolume.Text = VolSp;
            }
            else tbVolume.Text = "No Data";
        }
    }
}