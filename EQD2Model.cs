using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryan_Lam_EQD2_Calculator
{
    public class EQD2Model
    {
        //DPF = DosePerFraction; TD = TotalDose; ABR = AlphaBetaRtio
        public double DPF { get; set; }
        public double TD { get; set; }
        public double ABR { get; set; }

        public EQD2Model(double DPF, double TD, double ABR)
        {
            this.DPF = DPF;
            this.TD = TD;
            this.ABR = ABR;
        }
    }
}
