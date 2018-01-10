using System;
using System.Windows.Forms;

namespace EquationSolvingApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            var solver = new EquationSolver(new PolynomialRoots());

            var roots = solver.Solve(new[] { double.Parse(textBoxA.Text),
                                             double.Parse(textBoxB.Text),
                                             double.Parse(textBoxC.Text) });

            textBoxRoot1.Text = roots[0].ToString("F3");
            textBoxRoot2.Text = roots[1].ToString("F3");
        }
    }
}
