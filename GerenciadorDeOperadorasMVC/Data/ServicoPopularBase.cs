using GerenciadorDeOperadorasMVC.Models;
using GerenciadorDeOperadorasMVC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeOperadorasMVC.Data
{
    public class ServicoPopularBase
    {

        private GerenciadorDeOperadorasMVCContext _context;

        public ServicoPopularBase(GerenciadorDeOperadorasMVCContext context)
        {
            _context = context;
        }

        public void Popular()
        {
            if (_context.Operadora.Any() ||
                _context.Beneficiario.Any() ||
                _context.RegistroPlano.Any())
            {
                return; //BD já foi populada
            }

            Operadora o1 = new Operadora(new int(), "Bradesco Saúde");
            Operadora o2 = new Operadora(new int(), "NotreDame Intermédica");
            Operadora o3 = new Operadora(new int(), "Hapvida Assistência Médica");
            Operadora o4 = new Operadora(new int(), "Amil Assistência Médica");

            Beneficiario b1 = new Beneficiario(new int(), "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 280.0, o1);
            Beneficiario b2 = new Beneficiario(new int(), "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 320.0, o2);
            Beneficiario b3 = new Beneficiario(new int(), "Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 15), 280.0, o1);
            Beneficiario b4 = new Beneficiario(new int(), "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 350.0, o4);
            Beneficiario b5 = new Beneficiario(new int(), "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 250.0, o3);
            Beneficiario b6 = new Beneficiario(new int(), "Alex Pink", "bob@gmail.com", new DateTime(1997, 3, 4), 320.0, o2);

            RegistroPlano r1 = new RegistroPlano(new int(), new DateTime(2022, 09, 25), 1400.0, StatusPlano.Faturado, b1);
            RegistroPlano r2 = new RegistroPlano(new int(), new DateTime(2022, 09, 4), 7000.0, StatusPlano.Faturado, b5);
            RegistroPlano r3 = new RegistroPlano(new int(), new DateTime(2022, 09, 13), 4000.0, StatusPlano.Cancelado, b4);
            RegistroPlano r4 = new RegistroPlano(new int(), new DateTime(2022, 09, 1), 6720.0, StatusPlano.Faturado, b1);
            RegistroPlano r5 = new RegistroPlano(new int(), new DateTime(2022, 09, 21), 3000.0, StatusPlano.Faturado, b3);
            RegistroPlano r6 = new RegistroPlano(new int(), new DateTime(2022, 09, 15), 1680.0, StatusPlano.Faturado, b1);
            RegistroPlano r7 = new RegistroPlano(new int(), new DateTime(2022, 09, 28), 13000.0, StatusPlano.Faturado, b2);
            RegistroPlano r8 = new RegistroPlano(new int(), new DateTime(2022, 09, 11), 4000.0, StatusPlano.Faturado, b4);
            RegistroPlano r9 = new RegistroPlano(new int(), new DateTime(2022, 09, 14), 11000.0, StatusPlano.Faturado, b6);
            RegistroPlano r10 = new RegistroPlano(new int(), new DateTime(2022, 09, 7), 9000.0, StatusPlano.Faturado, b6);
            RegistroPlano r11 = new RegistroPlano(new int(), new DateTime(2022, 09, 13), 6000.0, StatusPlano.Faturado, b2);
            RegistroPlano r12 = new RegistroPlano(new int(), new DateTime(2022, 09, 25), 7000.0, StatusPlano.Faturado, b3);
            RegistroPlano r13 = new RegistroPlano(new int(), new DateTime(2022, 09, 29), 10000.0, StatusPlano.Faturado, b4);
            RegistroPlano r14 = new RegistroPlano(new int(), new DateTime(2022, 09, 4), 3000.0, StatusPlano.Faturado, b5);
            RegistroPlano r15 = new RegistroPlano(new int(), new DateTime(2022, 09, 12), 5040.0, StatusPlano.Faturado, b1);
            RegistroPlano r16 = new RegistroPlano(new int(), new DateTime(2022, 10, 5), 2000.0, StatusPlano.Faturado, b4);
            RegistroPlano r17 = new RegistroPlano(new int(), new DateTime(2022, 10, 1), 12000.0, StatusPlano.Faturado, b1);
            RegistroPlano r18 = new RegistroPlano(new int(), new DateTime(2022, 10, 24), 6000.0, StatusPlano.Faturado, b3);
            RegistroPlano r19 = new RegistroPlano(new int(), new DateTime(2022, 10, 22), 8000.0, StatusPlano.Faturado, b5);
            RegistroPlano r20 = new RegistroPlano(new int(), new DateTime(2022, 10, 15), 8000.0, StatusPlano.Faturado, b6);
            RegistroPlano r21 = new RegistroPlano(new int(), new DateTime(2022, 10, 17), 9000.0, StatusPlano.Faturado, b2);
            RegistroPlano r22 = new RegistroPlano(new int(), new DateTime(2022, 10, 24), 4000.0, StatusPlano.Faturado, b4);
            RegistroPlano r23 = new RegistroPlano(new int(), new DateTime(2022, 10, 19), 11000.0, StatusPlano.Cancelado, b2);
            RegistroPlano r24 = new RegistroPlano(new int(), new DateTime(2022, 10, 12), 8000.0, StatusPlano.Faturado, b5);
            RegistroPlano r25 = new RegistroPlano(new int(), new DateTime(2022, 10, 31), 7000.0, StatusPlano.Faturado, b3);
            RegistroPlano r26 = new RegistroPlano(new int(), new DateTime(2022, 10, 6), 5000.0, StatusPlano.Faturado, b4);
            RegistroPlano r27 = new RegistroPlano(new int(), new DateTime(2022, 10, 13), 9000.0, StatusPlano.Faturado, b1);
            RegistroPlano r28 = new RegistroPlano(new int(), new DateTime(2022, 10, 7), 4000.0, StatusPlano.Faturado, b3);
            RegistroPlano r29 = new RegistroPlano(new int(), new DateTime(2022, 10, 23), 12000.0, StatusPlano.Faturado, b5);
            RegistroPlano r30 = new RegistroPlano(new int(), new DateTime(2022, 10, 12), 5000.0, StatusPlano.Faturado, b2);

            _context.Operadora.AddRange(o1, o2, o3, o4);

            _context.Beneficiario.AddRange(b1, b2, b3, b4, b5, b6);

            _context.RegistroPlano.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19, r20, r21, r22, r23, r24, r25, r26, r27, r28, r29, r30);

            _context.SaveChanges();
        }
    }
}

