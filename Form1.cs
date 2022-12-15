namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operationPressed=false;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void DotButtonClick(object sender, EventArgs e)
        {
            if((textBoxArea.Text == "0") || (operationPressed))
                textBoxArea.Clear();

            operationPressed = false;
            Button btn= (Button)sender;
            if(btn.Text == ".")
            {
                if(!textBoxArea.Text.Contains("."))
                    textBoxArea.Text = textBoxArea.Text + btn.Text;
            }else
                textBoxArea.Text = textBoxArea.Text +btn.Text;
        }

       


        private void OperationBtnPress(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            
            if (value != 0) {
                textBoxArea.Text = "0";
                operation = btn.Text;
                labelOperation.Text = value + " " + operation;
                operationPressed = true;
            }
            else
                  {
                operation = btn.Text;
                value = Double.Parse(textBoxArea.Text);
                labelOperation.Text = value + " " + operation;
                operationPressed = true;
                textBoxArea.Text = "0";
            }
        }

      

       

        private void ClearBtnClicked(object sender, EventArgs e)
        {
            string str = textBoxArea.Text;
            textBoxArea.Text = str.Substring(0,str.Length-1);
            if (textBoxArea.Text == "") {
                textBoxArea.Text = "0";
                value = 0;
            }
                

        }

        private void ClearAllClick(object sender, EventArgs e)
        {
            textBoxArea.Text = "0";
            value = 0;
            labelOperation.Text = "";
            operationPressed = false;
        }

        private void EqualBtnClick(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    labelOperation.Text = "";
                    labelOperation.Text = value + " + " + textBoxArea.Text + " = ";
                    textBoxArea.Text = (value + Double.Parse(textBoxArea.Text)).ToString();
                    break;
                case "-":
                    labelOperation.Text = value + " - " + textBoxArea.Text + " = ";
                    textBoxArea.Text = (value - Double.Parse(textBoxArea.Text)).ToString();
                    break;
                case "*":
                    labelOperation.Text = value + " * " + textBoxArea.Text + " = ";
                    textBoxArea.Text = (value * Double.Parse(textBoxArea.Text)).ToString();
                    break;
                case "/":
                    labelOperation.Text = value + " / " + textBoxArea.Text + " = ";
                    textBoxArea.Text = (value / Double.Parse(textBoxArea.Text)).ToString();
                    break;
                default:
                    break;
            }
            value = Double.Parse(textBoxArea.Text);
        }

        
    }
}