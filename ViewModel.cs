using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryan_Lam_EQD2_Calculator
{
    class ViewModel
    {
        public static double CalculateEQD2(EQD2Model model)
        {
            //Calculates and Rounds to Nearest 2 Decimal Places
            return Math.Round((model.TD * ((model.DPF + model.ABR) / (2 + model.ABR))), 2);
        }
    }
}
