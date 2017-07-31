using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_5and6Solution
{
    class Tax
    {
        private int ID;
        private char name;
        private double monSal;
        private double fedTaxPer;
        private double stateTaxPer;
        private double monFedAmt;
        private double monStateAmt;
        private double monSalNet;
        private int payPer;
        private string aPaycheck;

        public Tax() { }


        //add constructor
        public Tax(int employeeID, char employeeName, double monthlySalary, int payPeriods)
        {
            ID = employeeID;
            name = employeeName;
            monSal = monthlySalary;
            payPer = payPeriods;
            DetermineTaxBracket(monthlySalary);
            DetermineCheckAmount(fedTaxPer, stateTaxPer);
            aPaycheck = OutputData();

        }



        public double MonFedAmt
        {
            get
            {
                return monFedAmt;
            }
        }

        public double MonStateAmt
        {
            get
            {
                return monStateAmt;
            }
        }

        public double MonSalNet
        {
  
          get
            {
                return monSalNet;
            }
        }


        public void DetermineTaxBracket(double monSal)
        {
            if ((monSal * 12) <= 10000)
            {
                fedTaxPer = 0.10;
                stateTaxPer = 0.03;
            }
            else if ((monSal * 12) <= 37000)
            {
                fedTaxPer = 0.15;
                stateTaxPer = 0.05;
            }
            else if ((monSal * 12)<= 91000)
            {
                fedTaxPer = 0.25;
                stateTaxPer = 0.07;
            }
            else if ((monSal * 12) >= 91000)
            {
                fedTaxPer = 0.30;
                stateTaxPer = 0.09;
            }

        }

        public void DetermineCheckAmount(double fedTaxPer, double stateTaxPer)
        {
            monFedAmt = fedTaxPer * monSal;
            monStateAmt = stateTaxPer * monSal;
            monSalNet = monSal - (monFedAmt - monStateAmt);
        }

        public string OutputData()
        {
            string aP = "Check #\tGross Wages\tState Taxes\tFederal Taxes\tNet\n";
            double payPd, mSS = 0.0, mFAS = 0.0, mSAS = 0.0, mSNS = 0.0;
            for (payPd = 1; payPd <=payPer;  payPd++)
            {
                aP += payPd + "\t" + monSal.ToString("C") + "\t" + monFedAmt.ToString("C") + "\t" + 
                    monStateAmt.ToString("C") + "\t" + monSalNet.ToString("C") + "\n";
                mSS += monSal;
                mFAS += monFedAmt;
                mSAS += monStateAmt;
                mSNS += monSalNet;
            }

            aP += payPd + "\t" + mSS.ToString("C") + "\t" + mFAS.ToString("C") + "\t" +
                              mSAS.ToString("C") + "\t" + mSNS.ToString("C") + "\n";
            return aP;
        }
        public string APaycheck
        {
            get
            {
                return aPaycheck;
            }
        }
        public override string ToString()
        {
            return payPer.ToString() + monSal.ToString("C") + "\n" + aPaycheck;
        }
    }


}
