using System.Collections.Generic;

namespace GerenciadorDeOperadorasMVC.Models.ViewModels
{
    public class BeneficiarioFormularioViewModel
    {   
        public Beneficiario Beneficiario { get; set; }
        public ICollection<Operadora> Operadoras { get; set; }
    }
}
