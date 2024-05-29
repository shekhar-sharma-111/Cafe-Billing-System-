using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void TeaCb_CheckedChanged(object sender, EventArgs e)
        {
            if(TeaCb.Checked==true) { TeaTb.Enabled = true; }
            if (TeaCb.Checked==false) { 
                TeaTb.Enabled = false;
                TeaTb.Text = "0";
            }
            
        }

        private void CoffeeCb_CheckedChanged(object sender, EventArgs e)
        {
            if (CoffeeCb.Checked == true) { CoffeeTb.Enabled = true; }
            if (CoffeeCb.Checked == false)
            {
                CoffeeTb.Enabled = false;
                CoffeeTb.Text = "0";
            }
        }

        private void FruitjuiceCb_CheckedChanged(object sender, EventArgs e)
        {
            if (FruitjuiceCb.Checked==true) { FruitjuiceTb.Enabled = true; }
            if (FruitjuiceCb.Checked == false)
            {
                FruitjuiceTb.Enabled = false;
                FruitjuiceTb.Text = "0";
            }
        }

        private void ColasodaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ColasodaCb.Checked==true) { ColasodaTb.Enabled = true; }
            if (ColasodaCb.Checked == false)
            {
                ColasodaTb.Enabled = false;
                ColasodaTb.Text = "0";
            }
        }

        private void IcecreamCb_CheckedChanged(object sender, EventArgs e)
        {
            if (IcecreamCb.Checked == true) { IcecreamTb.Enabled = true; }
            if (IcecreamCb.Checked == false)
            {
                IcecreamTb.Enabled = false;
                IcecreamTb.Text = "0";
            }
        }

        private void ChocolatesCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ChocolatesCb.Checked==true) { ChocolatesTb.Enabled = true; }
            if (ChocolatesCb.Checked == false)
            {
                ChocolatesTb.Enabled = false;
                ChocolatesTb.Text = "0";
            }
        }

        private void CakesCb_CheckedChanged(object sender, EventArgs e)
        {
            if (CakesCb.Checked == true) { CakesTb.Enabled = true; }
            if (CakesCb.Checked == false)
            {
                CakesTb.Enabled = false;
                CakesTb.Text = "0";
            }


        }

        private void BurgersCb_CheckedChanged(object sender, EventArgs e)
        {
            if (BurgersCb.Checked==true) { BurgersTb.Enabled = true; }
            if (BurgersCb.Checked == false)
            {
                BurgersTb.Enabled = false;
                BurgersTb.Text = "0";
            }

        }

        private void PizzasCb_CheckedChanged(object sender, EventArgs e)
        {
            if (PizzasCb.Checked==true) { PizzasTb.Enabled = true; }
            if (PizzasCb.Checked == false)
            {
                PizzasTb.Enabled = false;
                PizzasTb.Text = "0";
            }

        }

        private void RollsCb_CheckedChanged(object sender, EventArgs e)
        {
            if (RollsCb.Checked==true) { RollsTb.Enabled = true; }
            if (RollsCb.Checked == false)
            {
               RollsTb.Enabled = false;
                RollsTb.Text = "0";
            }

        }

        private void TacosCb_CheckedChanged(object sender, EventArgs e)
        {
            if (TacosCb.Checked == true) { TacosTb.Enabled = true; }
            if (TacosCb.Checked == false)
            {
                TacosTb.Enabled = false;
                TacosTb.Text = "0";
            }

        }

        private void FriesCb_CheckedChanged(object sender, EventArgs e)
        {
            if (FriesCb.Checked == true) { FriesTb.Enabled = true; }
            if (FriesCb.Checked == false)
            {
                FriesTb.Enabled = false;
                FriesTb.Text = "0";
            }

        }

        private void NoodlesCb_CheckedChanged(object sender, EventArgs e)
        {
            if (NoodlesCb.Checked==true) { NoodlesTb.Enabled = true; }
            if (NoodlesCb.Checked == false)
            {
                NoodlesTb.Enabled = false;
                NoodlesTb.Text = "0";
            }


        }
        private void TaxCb_CheckedChanged(object sender, EventArgs e)
        {
            if (TaxCb.Checked == true) { 
                TaxTb.Enabled = true;
                TaxTb.Text = "18";
            }
            if (TaxCb.Checked == false)
            {
                TaxTb.Enabled = false;
                TaxTb.Text = "0";
            }
        }


        private void closelbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //unit price for food items
        double teaup = 40, coffeeup = 40, fruitjuiceup = 60, colasodaup = 40;
        double burgerup = 60, rollup = 50, pizzaup = 100, tacoup = 80, friesup = 60, noodlesup = 80;

        private void DiscountCb_CheckedChanged(object sender, EventArgs e)
        {
            if (DiscountCb.Checked == true)
            {
                DiscountTb.Enabled = true;
                DiscountTb.Text = "10";
            }
            if (DiscountCb.Checked == false)
            {
                DiscountTb.Enabled = false;
                DiscountTb.Text = "0";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(ReceiptTb.Text, new Font("Equinox Typeface", 14,FontStyle.Regular),Brushes.DarkRed,new Point(140));
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeaCb.Checked = false;
            CoffeeCb.Checked = false;
            ColasodaCb.Checked = false;
            FruitjuiceCb.Checked = false;   
            IcecreamCb.Checked= false;
            ChocolatesCb.Checked = false;
            CakesCb.Checked = false;
            BurgersCb.Checked = false;
            PizzasCb.Checked = false;
            RollsCb.Checked = false;
            NoodlesCb.Checked = false;
            TacosCb.Checked = false;
            FriesCb.Checked = false;
            ReceiptTb.Clear();
            Subtotal = 0;
            Tax = 0;
            Grandtotal = 0;
            Discount = 0;
            Discountlbl.Text= "Rs/-";
            Grandtotallbl.Text= "Rs/-";
            Taxlbl.Text = "Rs/-";
            Subtotallbl.Text = "Rs/-";
           

        }

        double icecreamup = 100, chocolateup = 70, cakesup = 100;
        //variable to hold total price for each items

        double teatp, coffeetp, fruitjuicetp, colasodatp, burgertp, rolltp, pizzatp, tacotp, friestp, noodlestp, icecreamtp, chocolatetp, caketp;
        double Subtotal = 0,Tax,Grandtotal,Discount;
        private void button2_Click(object sender, EventArgs e)
        {
            teatp = teaup * Convert.ToDouble(TeaTb.Text);
            coffeetp = coffeeup * Convert.ToDouble(CoffeeTb.Text);
            fruitjuicetp = fruitjuiceup * Convert.ToDouble(FruitjuiceTb.Text);
            colasodatp = colasodaup * Convert.ToDouble(ColasodaTb.Text);
            burgertp = burgerup * Convert.ToDouble(BurgersTb.Text);
            rolltp = rollup * Convert.ToDouble(RollsTb.Text);
            pizzatp = pizzaup * Convert.ToDouble(PizzasTb.Text);
            tacotp = tacoup * Convert.ToDouble(TacosTb.Text);
            friestp = friesup * Convert.ToDouble(FriesTb.Text);
            noodlestp = noodlesup * Convert.ToDouble(NoodlesTb.Text);  
            icecreamtp = icecreamup * Convert.ToDouble(IcecreamTb.Text);    
            chocolatetp = chocolateup * Convert.ToDouble(ChocolatesTb.Text);
            caketp = cakesup * Convert.ToDouble(CakesTb.Text);
            //add items on receipt
            ReceiptTb.Clear();
            Subtotal = 0;

            ReceiptTb.AppendText(Environment.NewLine);
            ReceiptTb.AppendText("\t------SHEKHAR RESTAURANT------\t\t"+Datelbl.Text+Environment.NewLine);
            ReceiptTb.AppendText("\t***************************************"+Environment.NewLine);
            ReceiptTb.AppendText(Environment.NewLine);
            ReceiptTb.AppendText("\tITEMS\tQUANTITY\tPRICE"+Environment.NewLine);
            ReceiptTb.AppendText("\t----------------------------------------------------------------------" + Environment.NewLine);
            //updating subtotal
            //drinks
            if (TeaCb.Checked == true)
            {   
                ReceiptTb.AppendText("\t tea:\t\t" +TeaTb.Text+"\tRs."+teatp+Environment.NewLine);
                Subtotal = Subtotal + teatp;
                Subtotallbl.Text = "Rs:" + Subtotal;
            }
            if (CoffeeCb.Checked == true)
            {
                ReceiptTb.AppendText("\t coffee:\t\t" + CoffeeTb.Text + "\tRs." + coffeetp + Environment.NewLine);
                Subtotal = Subtotal + coffeetp;
                Subtotallbl.Text = "Rs:" + Subtotal;
            }
            if (FruitjuiceCb.Checked == true)
            {
                ReceiptTb.AppendText("\t fruit juice:\t" + FruitjuiceTb.Text + "\tRs." + fruitjuicetp + Environment.NewLine);
                Subtotal = Subtotal + fruitjuicetp;
                Subtotallbl.Text = "Rs:" + Subtotal;
            }
            if (ColasodaCb.Checked == true)
            {
                ReceiptTb.AppendText("\t cola soda:\t" + ColasodaTb.Text + "\tRs." + colasodatp + Environment.NewLine);
                Subtotal = Subtotal + colasodatp;
                Subtotallbl.Text = "Rs:" + Subtotal;

            }

            //DESSERTS subtotal update
            if (IcecreamCb.Checked == true)
            {
                ReceiptTb.AppendText("\ticecream:\t\t" + IcecreamTb.Text + "\tRs." + icecreamtp + Environment.NewLine);
                Subtotal = Subtotal + icecreamtp;
                Subtotallbl.Text = "Rs:" + Subtotal;
            }
            if (ChocolatesCb.Checked == true)
            {
                ReceiptTb.AppendText("\t chocolates:\t" + ChocolatesTb.Text + "\tRs." + chocolatetp + Environment.NewLine);
                Subtotal = Subtotal + chocolatetp;
                Subtotallbl.Text = "Rs:" + Subtotal;
            }
            if (CakesCb.Checked == true)
            {
                ReceiptTb.AppendText("\t cake:\t\t" + CakesTb.Text + "\tRs." + caketp + Environment.NewLine);
                Subtotal = Subtotal + caketp;
                Subtotallbl.Text = "Rs:" + Subtotal;
            }

            //food items subtotal update
               if (BurgersCb.Checked == true)
               {
                ReceiptTb.AppendText("\t burger:\t\t" + BurgersTb.Text + "\tRs." + burgertp + Environment.NewLine);
                Subtotal = Subtotal + burgertp;
                Subtotallbl.Text = "Rs:" + Subtotal;
               }
                if (PizzasCb.Checked == true)
                {
                    ReceiptTb.AppendText("\t pizza:\t\t" + PizzasTb.Text + "\tRs." + pizzatp + Environment.NewLine);
                    Subtotal = Subtotal + pizzatp;
                    Subtotallbl.Text = "Rs:" + Subtotal;
                }
                if (RollsCb.Checked == true)
                {
                    ReceiptTb.AppendText("\t rolls:\t\t" + RollsTb.Text + "\tRs." + rolltp + Environment.NewLine);
                    Subtotal = Subtotal + rolltp;
                    Subtotallbl.Text = "Rs:" + Subtotal;
                }
                if (TacosCb.Checked == true)
                {
                    ReceiptTb.AppendText("\t taco:\t\t" + TacosTb.Text + "\tRs." + tacotp + Environment.NewLine);
                    Subtotal = Subtotal + tacotp;
                    Subtotallbl.Text = "Rs:" + Subtotal;
                }
                if (NoodlesCb.Checked == true)
                {
                    ReceiptTb.AppendText("\t noodles:\t\t" + NoodlesTb.Text + "\tRs." + noodlestp + Environment.NewLine);
                    Subtotal = Subtotal + noodlestp;
                    Subtotallbl.Text = "Rs:" + Subtotal;
                }
                if (FriesCb.Checked == true)
                {
                    ReceiptTb.AppendText("\t fries:\t\t" + FriesTb.Text + "\tRs." + friestp + Environment.NewLine);
                    Subtotal = Subtotal + friestp;
                    Subtotallbl.Text = "Rs:" + Subtotal;
                }
            // calculating taxes
            Tax=Subtotal*Convert.ToDouble(TaxTb.Text) /100;
            Discount=Subtotal*Convert.ToDouble(DiscountTb.Text) /100;
            Grandtotal = Subtotal + Tax -Discount;
            Discountlbl.Text = "Rs:" + Discount;
            Taxlbl.Text = "Rs:" + Tax;
            Grandtotallbl.Text = "Rs:" + Grandtotal;
            ReceiptTb.AppendText("\t-----------------------------------"+Environment.NewLine);
            ReceiptTb.AppendText("\tSUBTOTAL :\t\t" + Subtotallbl.Text + Environment.NewLine);
            ReceiptTb.AppendText("\tDISCOUNT"+DiscountTb.Text+ "%:\t\t" + Discountlbl.Text + Environment.NewLine);
            ReceiptTb.AppendText("\tTaxes:"+TaxTb.Text+" % :\t\t" + Taxlbl.Text + Environment.NewLine);
            ReceiptTb.AppendText("\t-----------------------------------" + Environment.NewLine);
            ReceiptTb.AppendText("\tGRAND TOTAL :\t\t" + Grandtotallbl.Text + Environment.NewLine);


        }
    }
}
