// classes/Validators/QuestionTwo/EAlternativeValidator.cs
using System.Text.RegularExpressions;
using Classes.Validators;

namespace Classes.Validators.QuestionTwo
{
    class EAlternativeValidator: IValidator
    {
        public string get_regex_pattern()
        {
            return @"^(MM|HH)(h?(mh)*m?)$";
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
