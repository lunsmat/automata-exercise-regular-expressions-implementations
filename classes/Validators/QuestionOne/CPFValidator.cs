using System.Text.RegularExpressions;
using Classes.Validators;

namespace Classes.Validators.QuestionOne
{
    class CPFValidator: IValidator
    {
        /**
         * CPF:
         * 1. Sentenças devem ter o formato xxx.xxx.xxx-xx, onde x N ∈
         * Ex. de sentenças aceitas: 123.456.789-09, 000.000.000-00
         * Ex. de cadeias rejeitadas: 123.456.789-0, 111.111.11-11
         */
        public bool validate(string arg)
        {
            Regex validator = new Regex(
                @"^([0-9]{3}\.){2}[0-9]{3}-[0-9]{2}$",
                RegexOptions.Compiled
            );

            Match matcher = validator.Match(arg);

            return matcher.Success;
        }
    }
}
