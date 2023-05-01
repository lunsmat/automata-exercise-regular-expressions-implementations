using System.Text.RegularExpressions;

namespace Classes.Validators
{
    class NameValidator: IValidator
    {
        /**
         * Nome, nome do meio e sobrenome:
         * 1. Nome, nome do meio e sobrenome devem vir separados por um espaço apenas
         * 2. O nome do meio é opcional
         * 3. Nome e sobrenome devem ser ambos não vazios
         * 4. Não deve aceitar caracteres especiais ou números
         * 5. O primeiro símbolo do nome e sobrenome, e do nome do meio se existir, deve ser
         * do alfabeto Γ e os outros símbolos devem ser do alfabeto Σ
         * Ex. de sentenças aceitas: Ada Lovelace, Alan Turing, Stephen Cole Kleene
         * Ex. de cadeias rejeitadas: 1Alan, Alan, A1an, A1an Turing, Alan turing
         */
        public bool validate(string arg)
        {
            Regex validator = new Regex(
                @"^[A-Z][a-z]+([\s][A-Z][a-z]+){1,2}$",
                RegexOptions.Compiled
            );

            Match matcher = validator.Match(arg);

            return matcher.Success;
        }
    }
}
