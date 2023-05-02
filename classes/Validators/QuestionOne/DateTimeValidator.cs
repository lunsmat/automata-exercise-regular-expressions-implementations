using System.Text.RegularExpressions;
using Classes.Validators;

namespace Classes.Validators.QuestionOne
{
    class DateTimeValidator: IValidator
    {
        /**
         * Data e horário:
         * 1. Sentenças devem ter o formato dd/mm/aaaa hh:mm:ss, onde d, m, a, h, m, s N. ∈
         * Ex. de sentenças aceitas: 31/08/2019 20:14:55, 99/99/9999 23:59:59
         * Ex. de cadeias rejeitadas: 99/99/9999 3:9:9, 9/9/99 99:99:99, 99/99/999903:09:09
         */
        public bool validate(string arg)
        {
            Regex validator = new Regex(
                @"^([0-9]{2}\/){2}[0-9]{4}\s([0-9]{2}:){2}[0-9]{2}$",
                RegexOptions.Compiled
            );

            Match matcher = validator.Match(arg);

            return matcher.Success;
        }
    }
}
