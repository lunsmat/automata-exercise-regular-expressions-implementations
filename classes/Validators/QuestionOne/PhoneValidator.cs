using System.Text.RegularExpressions;
using Classes.Validators;

namespace Classes.Validators.QuestionOne
{
    class PhoneValidator: IValidator
    {
        /**
         * Telefone:
         * 1. Sentenças devem ter um dos formatos seguintes
         * (xx) 9xxxx-xxxx
         * (xx) 9xxxxxxxx
         * xx 9xxxxxxxx
         * onde x N. ∈
         * Ex. de sentenças aceitas: (91) 99999-9999, (91) 999999999, 91 999999999
         * Ex. de cadeias rejeitadas: (91) 59999-9999, 99 99999-9999, (94)95555-5555
         */
        public bool validate(string arg)
        {
            Regex validator = new Regex(
                @"^((\([0-9]{2}\)\s9[0-9]{4}(-)?)|([0-9]{2}\s9[0-9]{4}))[0-9]{4}$",
                RegexOptions.Compiled
            );

            Match matcher = validator.Match(arg);

            return matcher.Success;
        }
    }
}
