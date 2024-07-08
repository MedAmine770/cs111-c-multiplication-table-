using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace cs111_table_multiplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       const int ARRAYROWSIZE = 5 ;
        const int ARRAYCOLSIZE = 5;


        private void btnCreate_Click(object sender, EventArgs e) 
        {
            //declarations
            Label[,] labelArray = new Label[ARRAYROWSIZE, ARRAYCOLSIZE];

            labelArray[0, 0] = lbl1_1;
            labelArray[0, 1] = lbl1_2;
            labelArray[0, 2] = lbl1_3;
            labelArray[0, 3] = lbl1_4;
            labelArray[0, 4] = lbl1_5;

            labelArray[1, 0] = lbl2_1;
            labelArray[1, 1] = lbl2_2;
            labelArray[1, 2] = lbl2_3;
            labelArray[1, 3] = lbl2_4;
            labelArray[1, 4] = lbl2_5;

            labelArray[2, 0] = lbl3_1;
            labelArray[2, 1] = lbl3_2;
            labelArray[2, 2] = lbl3_3;
            labelArray[2, 3] = lbl3_4;
            labelArray[2, 4] = lbl3_5;

            labelArray[3, 0] = lbl4_1;
            labelArray[3, 1] = lbl4_2;
            labelArray[3, 2] = lbl4_3;
            labelArray[3, 3] = lbl4_4;
            labelArray[3, 4] = lbl4_5;

            labelArray[4, 0] = lbl5_1;
            labelArray[4, 1] = lbl5_2;
            labelArray[4, 2] = lbl5_3;
            labelArray[4, 3] = lbl5_4;
            labelArray[4, 4] = lbl5_5;

            //calculations product

            for (int row = 0; row < ARRAYROWSIZE; row++)
            {
                for (int col = 0; col < ARRAYCOLSIZE; col++)
                {
                    labelArray[row, col].Text = Convert.ToString((row+1)*(col+1));
                }

            }



        }
    }
}