using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgBoletimEscolar {
    public class Resultado {
        public double CalcularMedia(double nota1, double nota2, double nota3) {
            var Media = ((nota1 + nota2 + nota3) / 3);

            return Media;

        }
        public double CalcularFrequencia(int nAulas, int nFaltas) {
            var PercFrequencia = (100- (nFaltas * 100) / nAulas);

           return PercFrequencia;

        }
        public string ResultBoletim(double Media, double PercF) {
            if ((Media >= 7) && (PercF >= 75)) {
                return "aprovado";
            }
               return "Reprovado";
            
        }
    }
}
