using System.Text.RegularExpressions;

namespace Classes.Validators
{
    class RealNumberValidator: IValidator
    {
        /**
         * Número real com ou sem sinal:
         * 1. Sentenças devem começar com um dos símbolos do alfabeto {+, -, ε}
         * 2. Em seguida, as sentenças devem ter, pelo menos, um símbolo do alfabeto N
         * 3. Em seguida, as sentenças devem ter, exatamente, um símbolo separador “.”
         * 4. Em seguida, as sentenças devem finalizar com, pelo menos, um símbolo de N
         * 5. Exceção: números sem a parte fracionária também devem ser aceitos
         * Ex. de sentenças aceitas: -25.467, 1, -1, +1, 64.2
         * Ex. de cadeias rejeitadas: 1., .2, +64,2
         */
        public bool validate(string arg)
        {
            Regex validator = new Regex(
                @"^([+-]?)([0-9]+)((\.)([0-9]+))?$",
                RegexOptions.Compiled
            );

            Match matcher = validator.Match(arg);

            return matcher.Success;
        }
    }
}
