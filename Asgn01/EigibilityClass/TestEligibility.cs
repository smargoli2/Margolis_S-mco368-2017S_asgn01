using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EigibilityClass
{
    public class TestEligibility
    {
        private Boolean naturalCitizen;
        private int birthYr;
        private int yearsInUS;
        private int termsServed;
        private Boolean rebelled;
        DateTime today = DateTime.Now;


        public TestEligibility(Boolean citizen, int birthYr, int yearsInUS, int terms, Boolean rebelled)
        {
         
            naturalCitizen = citizen;
            this.birthYr = birthYr;
            this.yearsInUS = yearsInUS;
            termsServed = terms;
            this.rebelled = rebelled;
        }
    

        public Boolean isEligible()
        {
            if (naturalCitizen == true && (today.Year - birthYr >= 35) 
                && yearsInUS > 13 && termsServed < 2 && rebelled == false)
            {
                return true;
            }
            return false;
        }
    }
}
