// classes/Validators/QuestionTwo/CAlternativeValidator.cs
using System.Text.RegularExpressions;
using Classes.Validators;

namespace Classes.Validators.QuestionTwo
{
    class CAlternativeValidator: IValidator
    {
        public string get_regex_pattern()
        {
            return @"^(HM|MH)m(h|m)*h$";
        }

        public bool validate(string arg)
        {
            Regex validator = new Regex(
                this.get_regex_pattern(),
                RegexOptions.Compiled
            );

            Match matcher = validator.Match(arg);

            return matcher.Success;
        }
    }
}
